namespace SingleResponsibility.GoodExamples;

/// <summary>
/// GOOD EXAMPLE - Employee class following Single Responsibility Principle
/// 
/// This class has ONE RESPONSIBILITY: Managing employee data
/// 
/// BENEFITS:
/// - Easy to understand - just employee information
/// - Easy to test - no external dependencies
/// - Changes to employee data structure only affect this class
/// - Other responsibilities delegated to appropriate classes
/// </summary>
public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Department { get; set; }
    public decimal BaseSalary { get; set; }
    public DateTime HireDate { get; set; }

    public Employee(int id, string name, string email, string department, decimal baseSalary)
    {
        Id = id;
        Name = name;
        Email = email;
        Department = department;
        BaseSalary = baseSalary;
        HireDate = DateTime.Now;
    }

    /// <summary>
    /// Only methods that directly relate to employee data
    /// </summary>
    public int GetYearsOfService()
    {
        return DateTime.Now.Year - HireDate.Year;
    }

    public string GetFullInfo()
    {
        return $"{Name} ({Id}) - {Department}";
    }
}

/// <summary>
/// GOOD EXAMPLE - Separate class for salary calculations
/// 
/// SINGLE RESPONSIBILITY: Calculate employee salaries
/// </summary>
public class SalaryCalculator
{
    private readonly decimal _salesBonus = 0.15m;
    private readonly decimal _seniorityBonus = 0.10m;
    private readonly int _seniorityThreshold = 5;

    public decimal CalculateSalary(Employee employee)
    {
        Console.WriteLine($"[GOOD] SalaryCalculator calculating salary");
        
        decimal totalSalary = employee.BaseSalary;
        
        // Seniority bonus
        if (employee.GetYearsOfService() >= _seniorityThreshold)
        {
            totalSalary += employee.BaseSalary * _seniorityBonus;
        }
        
        // Department bonus
        if (employee.Department == "Sales")
        {
            totalSalary += employee.BaseSalary * _salesBonus;
        }
        
        return totalSalary;
    }

    public decimal CalculateAnnualSalary(Employee employee)
    {
        return CalculateSalary(employee) * 12;
    }
}

/// <summary>
/// GOOD EXAMPLE - Separate class for database operations
/// 
/// SINGLE RESPONSIBILITY: Handle employee persistence
/// </summary>
public class EmployeeRepository
{
    private readonly List<Employee> _database = new List<Employee>();

    public void Save(Employee employee)
    {
        Console.WriteLine($"[GOOD] EmployeeRepository saving employee");
        _database.Add(employee);
        Console.WriteLine($"Employee {employee.Name} saved to database");
    }

    public Employee? GetById(int id)
    {
        return _database.FirstOrDefault(e => e.Id == id);
    }

    public List<Employee> GetByDepartment(string department)
    {
        return _database.Where(e => e.Department == department).ToList();
    }

    public void Update(Employee employee)
    {
        var existing = GetById(employee.Id);
        if (existing != null)
        {
            _database.Remove(existing);
            _database.Add(employee);
        }
    }
}

/// <summary>
/// GOOD EXAMPLE - Separate class for email notifications
/// 
/// SINGLE RESPONSIBILITY: Send emails
/// </summary>
public class EmailService
{
    public void SendWelcomeEmail(Employee employee)
    {
        Console.WriteLine($"[GOOD] EmailService sending welcome email");
        var message = new EmailMessage
        {
            To = employee.Email,
            Subject = $"Welcome to the company, {employee.Name}!",
            Body = $"Welcome to the {employee.Department} department. We're glad to have you!"
        };
        Send(message);
    }

    public void SendPayslipEmail(Employee employee, decimal salary)
    {
        Console.WriteLine($"[GOOD] EmailService sending payslip");
        var message = new EmailMessage
        {
            To = employee.Email,
            Subject = "Your Monthly Payslip",
            Body = $"Your salary for this month: ${salary:F2}"
        };
        Send(message);
    }

    private void Send(EmailMessage message)
    {
        Console.WriteLine($"Sending email to: {message.To}");
        Console.WriteLine($"Subject: {message.Subject}");
        Console.WriteLine($"Body: {message.Body}");
    }
}

/// <summary>
/// GOOD EXAMPLE - Separate class for report generation
/// 
/// SINGLE RESPONSIBILITY: Generate employee reports
/// </summary>
public class EmployeeReportGenerator
{
    private readonly SalaryCalculator _salaryCalculator;

    public EmployeeReportGenerator(SalaryCalculator salaryCalculator)
    {
        _salaryCalculator = salaryCalculator;
    }

    public string GeneratePerformanceReport(Employee employee)
    {
        Console.WriteLine($"[GOOD] ReportGenerator creating performance report");
        
        var report = new System.Text.StringBuilder();
        report.AppendLine($"Performance Report");
        report.AppendLine($"==================");
        report.AppendLine($"Employee: {employee.GetFullInfo()}");
        report.AppendLine($"Years of Service: {employee.GetYearsOfService()}");
        report.AppendLine($"Current Monthly Salary: ${_salaryCalculator.CalculateSalary(employee):F2}");
        report.AppendLine($"Annual Salary: ${_salaryCalculator.CalculateAnnualSalary(employee):F2}");
        
        return report.ToString();
    }

    public string GenerateDepartmentReport(List<Employee> employees, string department)
    {
        var report = new System.Text.StringBuilder();
        report.AppendLine($"Department Report: {department}");
        report.AppendLine($"================================");
        report.AppendLine($"Total Employees: {employees.Count}");
        
        decimal totalSalary = 0;
        foreach (var emp in employees)
        {
            totalSalary += _salaryCalculator.CalculateSalary(emp);
            report.AppendLine($"- {emp.GetFullInfo()}");
        }
        
        report.AppendLine($"\nTotal Monthly Payroll: ${totalSalary:F2}");
        
        return report.ToString();
    }
}

/// <summary>
/// GOOD EXAMPLE - Separate validator class
/// 
/// SINGLE RESPONSIBILITY: Validate employee data
/// </summary>
public class EmployeeValidator
{
    public ValidationResult Validate(Employee employee)
    {
        Console.WriteLine($"[GOOD] EmployeeValidator validating employee data");
        
        var errors = new List<string>();

        if (string.IsNullOrWhiteSpace(employee.Name))
            errors.Add("Name is required");

        if (string.IsNullOrWhiteSpace(employee.Email) || !employee.Email.Contains("@"))
            errors.Add("Valid email is required");

        if (employee.BaseSalary <= 0)
            errors.Add("Salary must be positive");

        if (string.IsNullOrWhiteSpace(employee.Department))
            errors.Add("Department is required");

        return new ValidationResult
        {
            IsValid = errors.Count == 0,
            Errors = errors
        };
    }
}

/// <summary>
/// GOOD EXAMPLE - Order split into multiple responsible classes
/// </summary>
public class Order
{
    public int OrderId { get; set; }
    public List<OrderItem> Items { get; set; }
    public string CustomerEmail { get; set; }
    public DateTime OrderDate { get; set; }
    public OrderStatus Status { get; set; }

    public Order(int orderId, string customerEmail)
    {
        OrderId = orderId;
        CustomerEmail = customerEmail;
        Items = new List<OrderItem>();
        OrderDate = DateTime.Now;
        Status = OrderStatus.Pending;
    }

    public void AddItem(OrderItem item)
    {
        Items.Add(item);
    }

    public decimal GetSubtotal()
    {
        return Items.Sum(item => item.Price * item.Quantity);
    }
}

/// <summary>
/// GOOD EXAMPLE - Separate price calculator
/// 
/// SINGLE RESPONSIBILITY: Calculate prices and taxes
/// </summary>
public class PriceCalculator
{
    private readonly decimal _taxRate;

    public PriceCalculator(decimal taxRate)
    {
        _taxRate = taxRate;
    }

    public decimal CalculateTax(decimal amount)
    {
        return amount * _taxRate;
    }

    public decimal CalculateTotalWithTax(Order order)
    {
        Console.WriteLine($"[GOOD] PriceCalculator calculating total");
        var subtotal = order.GetSubtotal();
        var tax = CalculateTax(subtotal);
        return subtotal + tax;
    }
}

/// <summary>
/// GOOD EXAMPLE - Separate inventory service
/// 
/// SINGLE RESPONSIBILITY: Manage inventory
/// </summary>
public class InventoryService
{
    private readonly Dictionary<string, int> _inventory = new Dictionary<string, int>();

    public bool CheckAvailability(OrderItem item)
    {
        Console.WriteLine($"[GOOD] InventoryService checking availability");
        
        if (_inventory.ContainsKey(item.ProductName))
        {
            return _inventory[item.ProductName] >= item.Quantity;
        }
        return false;
    }

    public void UpdateInventory(OrderItem item)
    {
        if (_inventory.ContainsKey(item.ProductName))
        {
            _inventory[item.ProductName] -= item.Quantity;
            Console.WriteLine($"Updated inventory for {item.ProductName}");
        }
    }

    public void AddStock(string productName, int quantity)
    {
        if (!_inventory.ContainsKey(productName))
            _inventory[productName] = 0;
        
        _inventory[productName] += quantity;
    }
}

/// <summary>
/// GOOD EXAMPLE - Separate payment processor
/// 
/// SINGLE RESPONSIBILITY: Process payments
/// </summary>
public class PaymentProcessor
{
    public PaymentResult ProcessPayment(string cardNumber, decimal amount)
    {
        Console.WriteLine($"[GOOD] PaymentProcessor processing payment");
        
        // Simulate payment processing
        Console.WriteLine($"Processing ${amount:F2} on card ending {cardNumber.Substring(cardNumber.Length - 4)}");
        
        return new PaymentResult
        {
            Success = true,
            TransactionId = Guid.NewGuid().ToString(),
            Amount = amount,
            Timestamp = DateTime.Now
        };
    }

    public void RefundPayment(string transactionId, decimal amount)
    {
        Console.WriteLine($"Processing refund for transaction {transactionId}");
    }
}

/// <summary>
/// GOOD EXAMPLE - Separate invoice generator
/// 
/// SINGLE RESPONSIBILITY: Generate invoices
/// </summary>
public class InvoiceGenerator
{
    private readonly PriceCalculator _priceCalculator;

    public InvoiceGenerator(PriceCalculator priceCalculator)
    {
        _priceCalculator = priceCalculator;
    }

    public Invoice GenerateInvoice(Order order)
    {
        Console.WriteLine($"[GOOD] InvoiceGenerator creating invoice");
        
        return new Invoice
        {
            InvoiceNumber = $"INV-{order.OrderId}",
            OrderId = order.OrderId,
            CustomerEmail = order.CustomerEmail,
            Items = order.Items.ToList(),
            Subtotal = order.GetSubtotal(),
            Tax = _priceCalculator.CalculateTax(order.GetSubtotal()),
            Total = _priceCalculator.CalculateTotalWithTax(order),
            GeneratedDate = DateTime.Now
        };
    }

    public string FormatInvoice(Invoice invoice)
    {
        var formatted = new System.Text.StringBuilder();
        formatted.AppendLine($"INVOICE {invoice.InvoiceNumber}");
        formatted.AppendLine($"Date: {invoice.GeneratedDate}");
        formatted.AppendLine($"Customer: {invoice.CustomerEmail}\n");
        formatted.AppendLine("Items:");
        
        foreach (var item in invoice.Items)
        {
            formatted.AppendLine($"- {item.ProductName} x{item.Quantity} @ ${item.Price:F2}");
        }
        
        formatted.AppendLine($"\nSubtotal: ${invoice.Subtotal:F2}");
        formatted.AppendLine($"Tax: ${invoice.Tax:F2}");
        formatted.AppendLine($"Total: ${invoice.Total:F2}");
        
        return formatted.ToString();
    }
}

// Helper classes for the good examples
public class EmailMessage
{
    public string To { get; set; } = "";
    public string Subject { get; set; } = "";
    public string Body { get; set; } = "";
}

public class ValidationResult
{
    public bool IsValid { get; set; }
    public List<string> Errors { get; set; } = new List<string>();
}

public class OrderItem
{
    public string ProductName { get; set; } = "";
    public int Quantity { get; set; }
    public decimal Price { get; set; }
}

public enum OrderStatus
{
    Pending,
    Processing,
    Shipped,
    Delivered,
    Cancelled
}

public class PaymentResult
{
    public bool Success { get; set; }
    public string TransactionId { get; set; } = "";
    public decimal Amount { get; set; }
    public DateTime Timestamp { get; set; }
}

public class Invoice
{
    public string InvoiceNumber { get; set; } = "";
    public int OrderId { get; set; }
    public string CustomerEmail { get; set; } = "";
    public List<OrderItem> Items { get; set; } = new List<OrderItem>();
    public decimal Subtotal { get; set; }
    public decimal Tax { get; set; }
    public decimal Total { get; set; }
    public DateTime GeneratedDate { get; set; }
}