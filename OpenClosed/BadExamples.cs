namespace OpenClosed.BadExamples;

/// <summary>
/// BAD EXAMPLE - AreaCalculator violating Open/Closed Principle
/// 
/// This class needs to be MODIFIED every time we add a new shape.
/// It's OPEN for modification (bad) instead of CLOSED for modification.
/// 
/// PROBLEMS:
/// - Adding new shapes requires changing existing code
/// - Risk of breaking existing functionality
/// - Violates "closed for modification" principle
/// - Growing switch/if-else statements
/// - Difficult to maintain as shapes increase
/// </summary>
public class AreaCalculator_Bad
{
    /// <summary>
    /// VIOLATION: This method must be modified for each new shape
    /// Every new shape requires adding a new case
    /// </summary>
    public double CalculateArea(object shape)
    {
        Console.WriteLine("[BAD] AreaCalculator using type checking and casting");
        
        // BAD: Type checking and casting
        if (shape is Rectangle_Bad rectangle)
        {
            return rectangle.Width * rectangle.Height;
        }
        else if (shape is Circle_Bad circle)
        {
            return Math.PI * circle.Radius * circle.Radius;
        }
        else if (shape is Triangle_Bad triangle)
        {
            // Heron's formula
            var s = (triangle.SideA + triangle.SideB + triangle.SideC) / 2;
            return Math.Sqrt(s * (s - triangle.SideA) * (s - triangle.SideB) * (s - triangle.SideC));
        }
        // PROBLEM: Need to add more else-if for each new shape!
        // What about Pentagon, Hexagon, Ellipse, etc.?
        
        throw new ArgumentException("Unknown shape type");
    }

    /// <summary>
    /// Another violation with switch statement
    /// </summary>
    public double CalculatePerimeter(object shape)
    {
        Console.WriteLine("[BAD] Perimeter calculation with switch");
        
        // BAD: Switch on type
        switch (shape)
        {
            case Rectangle_Bad rect:
                return 2 * (rect.Width + rect.Height);
            case Circle_Bad circle:
                return 2 * Math.PI * circle.Radius;
            case Triangle_Bad triangle:
                return triangle.SideA + triangle.SideB + triangle.SideC;
            // PROBLEM: Must add new cases for new shapes
            default:
                throw new ArgumentException("Unknown shape type");
        }
    }
}

// Shape classes without common interface
public class Rectangle_Bad
{
    public double Width { get; set; }
    public double Height { get; set; }
}

public class Circle_Bad
{
    public double Radius { get; set; }
}

public class Triangle_Bad
{
    public double SideA { get; set; }
    public double SideB { get; set; }
    public double SideC { get; set; }
}

/// <summary>
/// BAD EXAMPLE - PaymentProcessor violating OCP
/// 
/// Must modify this class every time we add a new payment method
/// </summary>
public class PaymentProcessor_Bad
{
    /// <summary>
    /// VIOLATION: Method must be modified for each new payment type
    /// </summary>
    public void ProcessPayment(string paymentType, double amount, object paymentDetails)
    {
        Console.WriteLine($"[BAD] Processing {paymentType} payment");
        
        // BAD: Growing if-else chain
        if (paymentType == "CreditCard")
        {
            var details = (CreditCardDetails)paymentDetails;
            Console.WriteLine($"Processing credit card payment of ${amount}");
            Console.WriteLine($"Card Number: ***{details.CardNumber.Substring(details.CardNumber.Length - 4)}");
            Console.WriteLine($"CVV: {details.CVV}");
            // Credit card specific logic...
        }
        else if (paymentType == "PayPal")
        {
            var details = (PayPalDetails)paymentDetails;
            Console.WriteLine($"Processing PayPal payment of ${amount}");
            Console.WriteLine($"Email: {details.Email}");
            Console.WriteLine($"Password: ****");
            // PayPal specific logic...
        }
        else if (paymentType == "BankTransfer")
        {
            var details = (BankTransferDetails)paymentDetails;
            Console.WriteLine($"Processing bank transfer of ${amount}");
            Console.WriteLine($"Account: {details.AccountNumber}");
            Console.WriteLine($"Routing: {details.RoutingNumber}");
            // Bank transfer specific logic...
        }
        // PROBLEM: Need to add more else-if for each new payment method!
        // What about Apple Pay, Google Pay, Cryptocurrency, etc.?
        else
        {
            throw new ArgumentException($"Unknown payment type: {paymentType}");
        }
    }

    /// <summary>
    /// Another violation - validation logic that grows with each payment type
    /// </summary>
    public bool ValidatePayment(string paymentType, object paymentDetails)
    {
        switch (paymentType)
        {
            case "CreditCard":
                var cc = (CreditCardDetails)paymentDetails;
                return !string.IsNullOrEmpty(cc.CardNumber) && cc.CardNumber.Length == 16;
            
            case "PayPal":
                var pp = (PayPalDetails)paymentDetails;
                return !string.IsNullOrEmpty(pp.Email) && pp.Email.Contains("@");
            
            case "BankTransfer":
                var bt = (BankTransferDetails)paymentDetails;
                return !string.IsNullOrEmpty(bt.AccountNumber) && !string.IsNullOrEmpty(bt.RoutingNumber);
            
            // PROBLEM: Must add cases for new payment types
            default:
                return false;
        }
    }
}

// Payment detail classes
public class CreditCardDetails
{
    public string CardNumber { get; set; } = "";
    public string CVV { get; set; } = "";
    public string ExpiryDate { get; set; } = "";
}

public class PayPalDetails
{
    public string Email { get; set; } = "";
    public string Password { get; set; } = "";
}

public class BankTransferDetails
{
    public string AccountNumber { get; set; } = "";
    public string RoutingNumber { get; set; } = "";
}

/// <summary>
/// BAD EXAMPLE - DiscountCalculator violating OCP
/// 
/// Hardcoded discount rules that require modification for new discount types
/// </summary>
public class DiscountCalculator_Bad
{
    /// <summary>
    /// VIOLATION: Must modify method to add new discount types
    /// </summary>
    public decimal CalculateDiscount(string customerType, decimal purchaseAmount)
    {
        Console.WriteLine($"[BAD] Calculating discount for {customerType}");
        
        decimal discount = 0;
        
        // BAD: Hardcoded business rules
        if (customerType == "Regular")
        {
            // No discount for regular customers
            discount = 0;
        }
        else if (customerType == "Silver")
        {
            // 10% discount for silver customers
            discount = purchaseAmount * 0.10m;
        }
        else if (customerType == "Gold")
        {
            // 20% discount for gold customers
            discount = purchaseAmount * 0.20m;
        }
        else if (customerType == "Platinum")
        {
            // 30% discount for platinum customers
            discount = purchaseAmount * 0.30m;
        }
        // PROBLEM: Need to modify this method for each new customer type
        // What about VIP, Employee, Seasonal discounts?
        
        return discount;
    }

    /// <summary>
    /// Another violation - special offer calculations
    /// </summary>
    public decimal ApplySpecialOffers(string offerType, decimal originalPrice)
    {
        switch (offerType)
        {
            case "BlackFriday":
                return originalPrice * 0.5m; // 50% off
            
            case "ChristmasSale":
                return originalPrice * 0.75m; // 25% off
            
            case "NewYear":
                return originalPrice * 0.85m; // 15% off
            
            // PROBLEM: Must add new cases for each new offer
            default:
                return originalPrice;
        }
    }
}

/// <summary>
/// BAD EXAMPLE - ReportGenerator violating OCP
/// 
/// Must modify to support new report formats
/// </summary>
public class ReportGenerator_Bad
{
    /// <summary>
    /// VIOLATION: Adding new report format requires modifying this method
    /// </summary>
    public string GenerateReport(List<SalesData> data, string format)
    {
        Console.WriteLine($"[BAD] Generating {format} report");
        
        if (format == "PDF")
        {
            return GeneratePDFReport(data);
        }
        else if (format == "Excel")
        {
            return GenerateExcelReport(data);
        }
        else if (format == "CSV")
        {
            return GenerateCSVReport(data);
        }
        // PROBLEM: Need to add more else-if for each new format
        // What about XML, JSON, HTML reports?
        else
        {
            throw new ArgumentException($"Unknown report format: {format}");
        }
    }

    private string GeneratePDFReport(List<SalesData> data)
    {
        var report = "PDF REPORT\n";
        report += "==========\n";
        foreach (var item in data)
        {
            report += $"Product: {item.Product}, Amount: ${item.Amount}\n";
        }
        return report;
    }

    private string GenerateExcelReport(List<SalesData> data)
    {
        var report = "Product\tAmount\n";
        foreach (var item in data)
        {
            report += $"{item.Product}\t{item.Amount}\n";
        }
        return report;
    }

    private string GenerateCSVReport(List<SalesData> data)
    {
        var report = "Product,Amount\n";
        foreach (var item in data)
        {
            report += $"{item.Product},{item.Amount}\n";
        }
        return report;
    }
}

public class SalesData
{
    public string Product { get; set; } = "";
    public decimal Amount { get; set; }
    public DateTime Date { get; set; }
}

/// <summary>
/// BAD EXAMPLE - NotificationService violating OCP
/// 
/// Hard to extend with new notification channels
/// </summary>
public class NotificationService_Bad
{
    /// <summary>
    /// VIOLATION: Must modify to add new notification types
    /// </summary>
    public void SendNotification(string type, string message, string recipient)
    {
        Console.WriteLine($"[BAD] Sending {type} notification");
        
        // BAD: Type-based branching
        if (type == "Email")
        {
            SendEmail(recipient, message);
        }
        else if (type == "SMS")
        {
            SendSMS(recipient, message);
        }
        else if (type == "Push")
        {
            SendPushNotification(recipient, message);
        }
        // PROBLEM: Need to modify for WhatsApp, Slack, Teams, etc.
        else
        {
            throw new ArgumentException($"Unknown notification type: {type}");
        }
    }

    private void SendEmail(string email, string message)
    {
        Console.WriteLine($"Sending email to {email}: {message}");
    }

    private void SendSMS(string phone, string message)
    {
        Console.WriteLine($"Sending SMS to {phone}: {message}");
    }

    private void SendPushNotification(string deviceId, string message)
    {
        Console.WriteLine($"Sending push to device {deviceId}: {message}");
    }
}