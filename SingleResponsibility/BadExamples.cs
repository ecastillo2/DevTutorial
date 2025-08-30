namespace SingleResponsibility.BadExamples;

/// <summary>
/// BAD EXAMPLE - Employee class violating Single Responsibility Principle
/// 
/// This class has TOO MANY RESPONSIBILITIES:
/// 1. Managing employee data
/// 2. Calculating salary
/// 3. Saving to database
/// 4. Sending emails
/// 5. Generating reports
/// 
/// PROBLEMS:
/// - Changes to database structure affect this class
/// - Changes to email system affect this class
/// - Changes to report format affect this class
/// - Hard to test - need database, email server, etc.
/// - Hard to maintain - too many reasons to change
/// </summary>
public class Employee_Bad
{
    // Employee data management responsibility
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Department { get; set; }
    public decimal BaseSalary { get; set; }
    public DateTime HireDate { get; set; }

    public Employee_Bad(int id, string name, string email, string department, decimal baseSalary)
    {
        Id = id;
        Name = name;
        Email = email;
        Department = department;
        BaseSalary = baseSalary;
        HireDate = DateTime.Now;
    }

    /// <summary>
    /// RESPONSIBILITY #1: Salary Calculation
    /// Should be in a separate SalaryCalculator class
    /// </summary>
    public decimal CalculateSalary()
    {
        Console.WriteLine($"[BAD] Calculating salary in Employee class");
        decimal bonus = 0;
        
        // Complex salary calculation logic
        if (DateTime.Now.Year - HireDate.Year > 5)
        {
            bonus = BaseSalary * 0.1m; // 10% bonus for 5+ years
        }
        
        if (Department == "Sales")
        {
            bonus += BaseSalary * 0.15m; // Extra 15% for sales
        }
        
        return BaseSalary + bonus;
    }

    /// <summary>
    /// RESPONSIBILITY #2: Database Operations
    /// Should be in a separate Repository class
    /// </summary>
    public void SaveToDatabase()
    {
        Console.WriteLine($"[BAD] Saving employee to database in Employee class");
        // Simulating database save
        Console.WriteLine($"INSERT INTO Employees (Id, Name, Email, Department, Salary) " +
                         $"VALUES ({Id}, '{Name}', '{Email}', '{Department}', {BaseSalary})");
    }

    /// <summary>
    /// RESPONSIBILITY #3: Email Notifications
    /// Should be in a separate EmailService class
    /// </summary>
    public void SendWelcomeEmail()
    {
        Console.WriteLine($"[BAD] Sending email in Employee class");
        // Simulating email send
        Console.WriteLine($"TO: {Email}");
        Console.WriteLine($"SUBJECT: Welcome to the company, {Name}!");
        Console.WriteLine($"BODY: Welcome to the {Department} department...");
    }

    /// <summary>
    /// RESPONSIBILITY #4: Report Generation
    /// Should be in a separate ReportGenerator class
    /// </summary>
    public string GeneratePerformanceReport()
    {
        Console.WriteLine($"[BAD] Generating report in Employee class");
        return $"Performance Report for {Name}\n" +
               $"Department: {Department}\n" +
               $"Years of Service: {DateTime.Now.Year - HireDate.Year}\n" +
               $"Current Salary: ${CalculateSalary():F2}";
    }

    /// <summary>
    /// RESPONSIBILITY #5: Data Validation
    /// Could be in a separate Validator class
    /// </summary>
    public bool ValidateEmployeeData()
    {
        Console.WriteLine($"[BAD] Validating data in Employee class");
        if (string.IsNullOrEmpty(Name)) return false;
        if (string.IsNullOrEmpty(Email) || !Email.Contains("@")) return false;
        if (BaseSalary <= 0) return false;
        return true;
    }
}

/// <summary>
/// BAD EXAMPLE - Order class with multiple responsibilities
/// 
/// VIOLATIONS:
/// 1. Order data management
/// 2. Price calculation with tax
/// 3. Inventory management
/// 4. Payment processing
/// 5. Invoice generation
/// 6. Shipping coordination
/// </summary>
public class Order_Bad
{
    // Order data
    public int OrderId { get; set; }
    public List<OrderItem> Items { get; set; }
    public string CustomerEmail { get; set; }
    public DateTime OrderDate { get; set; }
    public string Status { get; set; }

    public Order_Bad(int orderId, string customerEmail)
    {
        OrderId = orderId;
        CustomerEmail = customerEmail;
        Items = new List<OrderItem>();
        OrderDate = DateTime.Now;
        Status = "Pending";
    }

    /// <summary>
    /// RESPONSIBILITY #1: Price Calculation
    /// Should be in PriceCalculator
    /// </summary>
    public decimal CalculateTotalWithTax()
    {
        Console.WriteLine($"[BAD] Calculating price in Order class");
        decimal subtotal = Items.Sum(item => item.Price * item.Quantity);
        decimal tax = subtotal * 0.08m; // 8% tax
        return subtotal + tax;
    }

    /// <summary>
    /// RESPONSIBILITY #2: Inventory Management
    /// Should be in InventoryService
    /// </summary>
    public bool CheckAndUpdateInventory()
    {
        Console.WriteLine($"[BAD] Managing inventory in Order class");
        foreach (var item in Items)
        {
            Console.WriteLine($"Checking inventory for {item.ProductName}...");
            Console.WriteLine($"Reducing inventory by {item.Quantity}");
            // Database update would go here
        }
        return true;
    }

    /// <summary>
    /// RESPONSIBILITY #3: Payment Processing
    /// Should be in PaymentService
    /// </summary>
    public bool ProcessPayment(string creditCardNumber, decimal amount)
    {
        Console.WriteLine($"[BAD] Processing payment in Order class");
        Console.WriteLine($"Charging ${amount:F2} to card ending in {creditCardNumber.Substring(creditCardNumber.Length - 4)}");
        // Payment gateway integration would go here
        return true;
    }

    /// <summary>
    /// RESPONSIBILITY #4: Invoice Generation
    /// Should be in InvoiceGenerator
    /// </summary>
    public string GenerateInvoice()
    {
        Console.WriteLine($"[BAD] Generating invoice in Order class");
        var invoice = $"INVOICE #{OrderId}\n";
        invoice += $"Date: {OrderDate}\n";
        invoice += $"Customer: {CustomerEmail}\n\n";
        invoice += "Items:\n";
        foreach (var item in Items)
        {
            invoice += $"- {item.ProductName} x{item.Quantity} @ ${item.Price:F2}\n";
        }
        invoice += $"\nTotal: ${CalculateTotalWithTax():F2}";
        return invoice;
    }

    /// <summary>
    /// RESPONSIBILITY #5: Shipping Coordination
    /// Should be in ShippingService
    /// </summary>
    public void ArrangeShipping(string address)
    {
        Console.WriteLine($"[BAD] Arranging shipping in Order class");
        Console.WriteLine($"Creating shipping label for order #{OrderId}");
        Console.WriteLine($"Shipping to: {address}");
        Console.WriteLine($"Estimated delivery: {DateTime.Now.AddDays(3):d}");
    }
}

/// <summary>
/// BAD EXAMPLE - UserService doing everything
/// 
/// This "God Class" handles:
/// 1. User CRUD operations
/// 2. Authentication
/// 3. Authorization
/// 4. Password management
/// 5. Session management
/// 6. Audit logging
/// 7. Email notifications
/// </summary>
public class UserService_Bad
{
    private List<User> users = new List<User>();
    private Dictionary<string, DateTime> sessions = new Dictionary<string, DateTime>();

    /// <summary>
    /// RESPONSIBILITY #1: User Management
    /// </summary>
    public void CreateUser(string username, string password, string email)
    {
        Console.WriteLine($"[BAD] Creating user in UserService");
        var user = new User 
        { 
            Id = users.Count + 1, 
            Username = username, 
            Email = email,
            PasswordHash = HashPassword(password)
        };
        users.Add(user);
        
        // Also doing logging (another responsibility)
        LogAuditEvent($"User created: {username}");
        
        // Also sending email (another responsibility)
        SendWelcomeEmail(email, username);
    }

    /// <summary>
    /// RESPONSIBILITY #2: Authentication
    /// </summary>
    public bool Login(string username, string password)
    {
        Console.WriteLine($"[BAD] Authenticating in UserService");
        var user = users.FirstOrDefault(u => u.Username == username);
        if (user != null && VerifyPassword(password, user.PasswordHash))
        {
            // Also managing sessions (another responsibility)
            var sessionId = Guid.NewGuid().ToString();
            sessions[sessionId] = DateTime.Now;
            
            LogAuditEvent($"User logged in: {username}");
            return true;
        }
        return false;
    }

    /// <summary>
    /// RESPONSIBILITY #3: Password Management
    /// </summary>
    private string HashPassword(string password)
    {
        Console.WriteLine($"[BAD] Hashing password in UserService");
        // Simplified hashing
        return Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(password + "salt"));
    }

    private bool VerifyPassword(string password, string hash)
    {
        return HashPassword(password) == hash;
    }

    /// <summary>
    /// RESPONSIBILITY #4: Session Management
    /// </summary>
    public bool IsSessionValid(string sessionId)
    {
        Console.WriteLine($"[BAD] Checking session in UserService");
        if (sessions.ContainsKey(sessionId))
        {
            var sessionTime = sessions[sessionId];
            return DateTime.Now.Subtract(sessionTime).TotalMinutes < 30;
        }
        return false;
    }

    /// <summary>
    /// RESPONSIBILITY #5: Audit Logging
    /// </summary>
    private void LogAuditEvent(string message)
    {
        Console.WriteLine($"[BAD] Logging audit in UserService");
        Console.WriteLine($"[AUDIT] {DateTime.Now}: {message}");
    }

    /// <summary>
    /// RESPONSIBILITY #6: Email Notifications
    /// </summary>
    private void SendWelcomeEmail(string email, string username)
    {
        Console.WriteLine($"[BAD] Sending email in UserService");
        Console.WriteLine($"Sending welcome email to {email} for user {username}");
    }

    /// <summary>
    /// RESPONSIBILITY #7: Authorization
    /// </summary>
    public bool HasPermission(string username, string permission)
    {
        Console.WriteLine($"[BAD] Checking permissions in UserService");
        // Complex permission checking logic
        return true;
    }
}

// Helper classes for the bad examples
public class OrderItem
{
    public string ProductName { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
}

public class User
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }
    public string PasswordHash { get; set; }
}