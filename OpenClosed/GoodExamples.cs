namespace OpenClosed.GoodExamples;

/// <summary>
/// GOOD EXAMPLE - Shape hierarchy following Open/Closed Principle
/// 
/// OPEN for extension: Can add new shapes by creating new classes
/// CLOSED for modification: Don't need to modify existing code
/// 
/// Uses ABSTRACTION to achieve OCP
/// </summary>
public abstract class Shape
{
    public abstract double CalculateArea();
    public abstract double CalculatePerimeter();
    public abstract string GetShapeType();
}

/// <summary>
/// Rectangle implementation - extends Shape without modifying it
/// </summary>
public class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public override double CalculateArea()
    {
        return Width * Height;
    }

    public override double CalculatePerimeter()
    {
        return 2 * (Width + Height);
    }

    public override string GetShapeType()
    {
        return "Rectangle";
    }
}

/// <summary>
/// Circle implementation - extends Shape without modifying it
/// </summary>
public class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }

    public override double CalculatePerimeter()
    {
        return 2 * Math.PI * Radius;
    }

    public override string GetShapeType()
    {
        return "Circle";
    }
}

/// <summary>
/// Triangle implementation - extends Shape without modifying it
/// </summary>
public class Triangle : Shape
{
    public double SideA { get; set; }
    public double SideB { get; set; }
    public double SideC { get; set; }

    public Triangle(double sideA, double sideB, double sideC)
    {
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }

    public override double CalculateArea()
    {
        // Heron's formula
        var s = (SideA + SideB + SideC) / 2;
        return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
    }

    public override double CalculatePerimeter()
    {
        return SideA + SideB + SideC;
    }

    public override string GetShapeType()
    {
        return "Triangle";
    }
}

/// <summary>
/// NEW SHAPE: Pentagon - Added without modifying any existing code!
/// This demonstrates the "Open for extension" principle
/// </summary>
public class Pentagon : Shape
{
    public double Side { get; set; }

    public Pentagon(double side)
    {
        Side = side;
    }

    public override double CalculateArea()
    {
        // Area = (1/4) * √(5(5+2√5)) * s²
        return 0.25 * Math.Sqrt(5 * (5 + 2 * Math.Sqrt(5))) * Side * Side;
    }

    public override double CalculatePerimeter()
    {
        return 5 * Side;
    }

    public override string GetShapeType()
    {
        return "Pentagon";
    }
}

/// <summary>
/// GOOD EXAMPLE - AreaCalculator that follows OCP
/// 
/// This class is CLOSED for modification - we never need to change it
/// It's OPEN for extension - works with any Shape implementation
/// </summary>
public class AreaCalculator
{
    /// <summary>
    /// Works with any shape without modification
    /// Uses polymorphism instead of type checking
    /// </summary>
    public double CalculateTotalArea(List<Shape> shapes)
    {
        Console.WriteLine("[GOOD] AreaCalculator using polymorphism");
        
        double totalArea = 0;
        foreach (var shape in shapes)
        {
            // No type checking needed!
            totalArea += shape.CalculateArea();
        }
        return totalArea;
    }

    public double CalculateTotalPerimeter(List<Shape> shapes)
    {
        Console.WriteLine("[GOOD] Perimeter calculation using polymorphism");
        
        return shapes.Sum(shape => shape.CalculatePerimeter());
    }

    public void PrintShapeDetails(List<Shape> shapes)
    {
        foreach (var shape in shapes)
        {
            Console.WriteLine($"{shape.GetShapeType()}: Area = {shape.CalculateArea():F2}, Perimeter = {shape.CalculatePerimeter():F2}");
        }
    }
}

/// <summary>
/// GOOD EXAMPLE - Payment processing following OCP
/// 
/// Uses STRATEGY PATTERN to achieve OCP
/// </summary>
public interface IPaymentMethod
{
    void ProcessPayment(decimal amount);
    bool ValidatePaymentDetails();
    string GetPaymentType();
}

/// <summary>
/// Credit Card payment implementation
/// </summary>
public class CreditCardPayment : IPaymentMethod
{
    public string CardNumber { get; set; }
    public string CVV { get; set; }
    public string ExpiryDate { get; set; }

    public CreditCardPayment(string cardNumber, string cvv, string expiryDate)
    {
        CardNumber = cardNumber;
        CVV = cvv;
        ExpiryDate = expiryDate;
    }

    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"[GOOD] Processing credit card payment of ${amount}");
        Console.WriteLine($"Card: ***{CardNumber.Substring(CardNumber.Length - 4)}");
        // Credit card specific processing
    }

    public bool ValidatePaymentDetails()
    {
        return !string.IsNullOrEmpty(CardNumber) && 
               CardNumber.Length == 16 && 
               !string.IsNullOrEmpty(CVV);
    }

    public string GetPaymentType()
    {
        return "Credit Card";
    }
}

/// <summary>
/// PayPal payment implementation
/// </summary>
public class PayPalPayment : IPaymentMethod
{
    public string Email { get; set; }
    public string Password { get; set; }

    public PayPalPayment(string email, string password)
    {
        Email = email;
        Password = password;
    }

    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"[GOOD] Processing PayPal payment of ${amount}");
        Console.WriteLine($"Account: {Email}");
        // PayPal specific processing
    }

    public bool ValidatePaymentDetails()
    {
        return !string.IsNullOrEmpty(Email) && Email.Contains("@");
    }

    public string GetPaymentType()
    {
        return "PayPal";
    }
}

/// <summary>
/// Bank Transfer payment implementation
/// </summary>
public class BankTransferPayment : IPaymentMethod
{
    public string AccountNumber { get; set; }
    public string RoutingNumber { get; set; }

    public BankTransferPayment(string accountNumber, string routingNumber)
    {
        AccountNumber = accountNumber;
        RoutingNumber = routingNumber;
    }

    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"[GOOD] Processing bank transfer of ${amount}");
        Console.WriteLine($"Account: {AccountNumber}");
        // Bank transfer specific processing
    }

    public bool ValidatePaymentDetails()
    {
        return !string.IsNullOrEmpty(AccountNumber) && 
               !string.IsNullOrEmpty(RoutingNumber);
    }

    public string GetPaymentType()
    {
        return "Bank Transfer";
    }
}

/// <summary>
/// NEW PAYMENT METHOD: Cryptocurrency - Added without modifying existing code!
/// </summary>
public class CryptocurrencyPayment : IPaymentMethod
{
    public string WalletAddress { get; set; }
    public string CurrencyType { get; set; }

    public CryptocurrencyPayment(string walletAddress, string currencyType)
    {
        WalletAddress = walletAddress;
        CurrencyType = currencyType;
    }

    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"[GOOD] Processing {CurrencyType} payment of ${amount}");
        Console.WriteLine($"Wallet: {WalletAddress.Substring(0, 6)}...{WalletAddress.Substring(WalletAddress.Length - 4)}");
        // Crypto specific processing
    }

    public bool ValidatePaymentDetails()
    {
        return !string.IsNullOrEmpty(WalletAddress) && WalletAddress.Length > 20;
    }

    public string GetPaymentType()
    {
        return $"Cryptocurrency ({CurrencyType})";
    }
}

/// <summary>
/// Payment Processor that follows OCP
/// Never needs modification when adding new payment methods
/// </summary>
public class PaymentProcessor
{
    public void ProcessPayment(IPaymentMethod paymentMethod, decimal amount)
    {
        Console.WriteLine($"[GOOD] Processing payment using {paymentMethod.GetPaymentType()}");
        
        if (paymentMethod.ValidatePaymentDetails())
        {
            paymentMethod.ProcessPayment(amount);
            Console.WriteLine("Payment processed successfully!");
        }
        else
        {
            Console.WriteLine("Payment validation failed!");
        }
    }

    public void ProcessMultiplePayments(List<(IPaymentMethod method, decimal amount)> payments)
    {
        foreach (var (method, amount) in payments)
        {
            ProcessPayment(method, amount);
            Console.WriteLine();
        }
    }
}

/// <summary>
/// GOOD EXAMPLE - Discount calculation following OCP
/// 
/// Uses STRATEGY PATTERN for different discount strategies
/// </summary>
public interface IDiscountStrategy
{
    decimal CalculateDiscount(decimal purchaseAmount);
    string GetDiscountType();
}

/// <summary>
/// Regular customer discount
/// </summary>
public class RegularCustomerDiscount : IDiscountStrategy
{
    public decimal CalculateDiscount(decimal purchaseAmount)
    {
        return 0; // No discount
    }

    public string GetDiscountType()
    {
        return "Regular Customer";
    }
}

/// <summary>
/// Silver customer discount
/// </summary>
public class SilverCustomerDiscount : IDiscountStrategy
{
    private readonly decimal _discountPercentage = 0.10m;

    public decimal CalculateDiscount(decimal purchaseAmount)
    {
        return purchaseAmount * _discountPercentage;
    }

    public string GetDiscountType()
    {
        return "Silver Customer (10% off)";
    }
}

/// <summary>
/// Gold customer discount
/// </summary>
public class GoldCustomerDiscount : IDiscountStrategy
{
    private readonly decimal _discountPercentage = 0.20m;

    public decimal CalculateDiscount(decimal purchaseAmount)
    {
        return purchaseAmount * _discountPercentage;
    }

    public string GetDiscountType()
    {
        return "Gold Customer (20% off)";
    }
}

/// <summary>
/// NEW DISCOUNT: VIP customer - Added without modifying existing code!
/// </summary>
public class VIPCustomerDiscount : IDiscountStrategy
{
    private readonly decimal _discountPercentage = 0.35m;

    public decimal CalculateDiscount(decimal purchaseAmount)
    {
        return purchaseAmount * _discountPercentage;
    }

    public string GetDiscountType()
    {
        return "VIP Customer (35% off)";
    }
}

/// <summary>
/// Special offer discount - can be combined with customer discounts
/// </summary>
public class SeasonalDiscount : IDiscountStrategy
{
    private readonly string _season;
    private readonly decimal _discountPercentage;

    public SeasonalDiscount(string season, decimal discountPercentage)
    {
        _season = season;
        _discountPercentage = discountPercentage;
    }

    public decimal CalculateDiscount(decimal purchaseAmount)
    {
        return purchaseAmount * _discountPercentage;
    }

    public string GetDiscountType()
    {
        return $"{_season} Sale ({_discountPercentage:P0})";
    }
}

/// <summary>
/// Discount Calculator that follows OCP
/// </summary>
public class DiscountCalculator
{
    public decimal CalculateTotalDiscount(decimal purchaseAmount, List<IDiscountStrategy> discounts)
    {
        Console.WriteLine("[GOOD] Calculating discounts using strategies");
        
        decimal totalDiscount = 0;
        foreach (var discount in discounts)
        {
            var amount = discount.CalculateDiscount(purchaseAmount);
            Console.WriteLine($"{discount.GetDiscountType()}: ${amount:F2}");
            totalDiscount += amount;
        }
        
        // Ensure discount doesn't exceed purchase amount
        return Math.Min(totalDiscount, purchaseAmount);
    }

    public decimal CalculateFinalPrice(decimal purchaseAmount, List<IDiscountStrategy> discounts)
    {
        var totalDiscount = CalculateTotalDiscount(purchaseAmount, discounts);
        return purchaseAmount - totalDiscount;
    }
}

/// <summary>
/// GOOD EXAMPLE - Report generation following OCP
/// 
/// Uses TEMPLATE METHOD PATTERN
/// </summary>
public interface IReportGenerator
{
    string GenerateReport(List<SalesData> data);
    string GetReportFormat();
}

/// <summary>
/// PDF Report Generator
/// </summary>
public class PDFReportGenerator : IReportGenerator
{
    public string GenerateReport(List<SalesData> data)
    {
        var report = "PDF REPORT\n";
        report += "═══════════════════════════════\n";
        report += $"Generated: {DateTime.Now}\n\n";
        
        foreach (var item in data)
        {
            report += $"• Product: {item.Product}\n";
            report += $"  Amount: ${item.Amount:F2}\n";
            report += $"  Date: {item.Date:d}\n\n";
        }
        
        report += $"Total: ${data.Sum(d => d.Amount):F2}\n";
        return report;
    }

    public string GetReportFormat()
    {
        return "PDF";
    }
}

/// <summary>
/// Excel Report Generator
/// </summary>
public class ExcelReportGenerator : IReportGenerator
{
    public string GenerateReport(List<SalesData> data)
    {
        var report = "Product\tAmount\tDate\n";
        report += "─────────────────────────────\n";
        
        foreach (var item in data)
        {
            report += $"{item.Product}\t${item.Amount:F2}\t{item.Date:d}\n";
        }
        
        report += $"\nTotal\t${data.Sum(d => d.Amount):F2}\n";
        return report;
    }

    public string GetReportFormat()
    {
        return "Excel";
    }
}

/// <summary>
/// JSON Report Generator - NEW FORMAT added without modification!
/// </summary>
public class JSONReportGenerator : IReportGenerator
{
    public string GenerateReport(List<SalesData> data)
    {
        var report = "{\n";
        report += $"  \"generatedDate\": \"{DateTime.Now:yyyy-MM-dd}\",\n";
        report += "  \"salesData\": [\n";
        
        for (int i = 0; i < data.Count; i++)
        {
            var item = data[i];
            report += "    {\n";
            report += $"      \"product\": \"{item.Product}\",\n";
            report += $"      \"amount\": {item.Amount},\n";
            report += $"      \"date\": \"{item.Date:yyyy-MM-dd}\"\n";
            report += "    }";
            report += i < data.Count - 1 ? ",\n" : "\n";
        }
        
        report += "  ],\n";
        report += $"  \"total\": {data.Sum(d => d.Amount)}\n";
        report += "}";
        
        return report;
    }

    public string GetReportFormat()
    {
        return "JSON";
    }
}

/// <summary>
/// Report Service that follows OCP
/// </summary>
public class ReportService
{
    public string GenerateReport(IReportGenerator generator, List<SalesData> data)
    {
        Console.WriteLine($"[GOOD] Generating {generator.GetReportFormat()} report");
        return generator.GenerateReport(data);
    }

    public void GenerateMultipleReports(List<IReportGenerator> generators, List<SalesData> data)
    {
        foreach (var generator in generators)
        {
            var report = GenerateReport(generator, data);
            Console.WriteLine($"\n{generator.GetReportFormat()} Report Generated:");
            Console.WriteLine(report);
            Console.WriteLine();
        }
    }
}

/// <summary>
/// GOOD EXAMPLE - Notification system following OCP
/// </summary>
public interface INotificationChannel
{
    void SendNotification(string recipient, string message);
    string GetChannelName();
}

/// <summary>
/// Email notification channel
/// </summary>
public class EmailNotification : INotificationChannel
{
    public void SendNotification(string recipient, string message)
    {
        Console.WriteLine($"[Email] Sending to {recipient}: {message}");
    }

    public string GetChannelName()
    {
        return "Email";
    }
}

/// <summary>
/// SMS notification channel
/// </summary>
public class SMSNotification : INotificationChannel
{
    public void SendNotification(string recipient, string message)
    {
        Console.WriteLine($"[SMS] Sending to {recipient}: {message.Substring(0, Math.Min(message.Length, 160))}");
    }

    public string GetChannelName()
    {
        return "SMS";
    }
}

/// <summary>
/// NEW CHANNEL: Slack notification - Added without modifying existing code!
/// </summary>
public class SlackNotification : INotificationChannel
{
    private readonly string _webhookUrl;

    public SlackNotification(string webhookUrl)
    {
        _webhookUrl = webhookUrl;
    }

    public void SendNotification(string recipient, string message)
    {
        Console.WriteLine($"[Slack] Posting to channel {recipient} via webhook: {message}");
    }

    public string GetChannelName()
    {
        return "Slack";
    }
}

/// <summary>
/// Notification Service that follows OCP
/// </summary>
public class NotificationService
{
    private readonly List<INotificationChannel> _channels = new List<INotificationChannel>();

    public void RegisterChannel(INotificationChannel channel)
    {
        _channels.Add(channel);
        Console.WriteLine($"Registered {channel.GetChannelName()} notification channel");
    }

    public void SendNotification(string recipient, string message)
    {
        Console.WriteLine("[GOOD] Sending notifications through all channels");
        
        foreach (var channel in _channels)
        {
            channel.SendNotification(recipient, message);
        }
    }

    public void SendToSpecificChannel(INotificationChannel channel, string recipient, string message)
    {
        channel.SendNotification(recipient, message);
    }
}

// Helper class
public class SalesData
{
    public string Product { get; set; } = "";
    public decimal Amount { get; set; }
    public DateTime Date { get; set; }
}