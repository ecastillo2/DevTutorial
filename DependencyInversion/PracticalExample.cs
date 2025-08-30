namespace DependencyInversion.PracticalExample;

/// <summary>
/// PRACTICAL EXAMPLE - E-Commerce System with Dependency Injection
/// Simplified version that demonstrates DIP in a real-world scenario
/// </summary>

// ========== CORE INTERFACES (High-level policies) ==========

public interface ILogger
{
    void Log(string message);
    void LogError(string message, Exception? exception = null);
}

public interface IProductRepository
{
    Product? GetById(string id);
    void Save(Product product);
}

public interface IOrderService
{
    Order CreateOrder(string customerId, List<OrderItem> items);
    void ProcessPayment(Order order, PaymentMethod paymentMethod);
}

public interface INotificationService
{
    void SendOrderConfirmation(string email, Order order);
    void SendShippingNotification(string email, string trackingNumber);
}

public interface IPaymentGateway
{
    PaymentResult ProcessPayment(decimal amount, PaymentMethod method);
}

public interface IInventoryManager
{
    bool CheckStock(string productId, int quantity);
    void ReserveStock(string productId, int quantity);
}

public interface IShippingProvider
{
    ShippingInfo CalculateShipping(Address destination, decimal weight);
    string CreateShippingLabel(Order order);
}

// ========== APPLICATION SERVICE (High-level module) ==========

/// <summary>
/// E-commerce service that depends only on abstractions
/// This is a high-level module that orchestrates the business logic
/// </summary>
public class ECommerceService
{
    private readonly IProductRepository productRepository;
    private readonly IOrderService orderService;
    private readonly INotificationService notificationService;
    private readonly IInventoryManager inventoryManager;
    private readonly IShippingProvider shippingProvider;
    private readonly ILogger logger;

    // All dependencies are injected through constructor
    public ECommerceService(
        IProductRepository productRepository,
        IOrderService orderService,
        INotificationService notificationService,
        IInventoryManager inventoryManager,
        IShippingProvider shippingProvider,
        ILogger logger)
    {
        this.productRepository = productRepository;
        this.orderService = orderService;
        this.notificationService = notificationService;
        this.inventoryManager = inventoryManager;
        this.shippingProvider = shippingProvider;
        this.logger = logger;
    }

    public OrderResult PlaceOrder(string customerId, string customerEmail, List<OrderItem> items, 
        PaymentMethod paymentMethod, Address shippingAddress)
    {
        logger.Log($"Processing order for customer {customerId}");

        // Check inventory using abstraction
        foreach (var item in items)
        {
            if (!inventoryManager.CheckStock(item.ProductId, item.Quantity))
            {
                return new OrderResult 
                { 
                    Success = false, 
                    Message = $"Product {item.ProductId} is out of stock" 
                };
            }
        }

        // Reserve inventory
        foreach (var item in items)
        {
            inventoryManager.ReserveStock(item.ProductId, item.Quantity);
        }

        // Create order using abstraction
        var order = orderService.CreateOrder(customerId, items);
        order.ShippingAddress = shippingAddress;

        // Calculate shipping using abstraction
        var totalWeight = CalculateTotalWeight(items);
        var shippingInfo = shippingProvider.CalculateShipping(shippingAddress, totalWeight);
        order.ShippingCost = shippingInfo.Cost;
        order.Total += shippingInfo.Cost;

        try
        {
            // Process payment using abstraction
            orderService.ProcessPayment(order, paymentMethod);

            // Create shipping label using abstraction
            var trackingNumber = shippingProvider.CreateShippingLabel(order);
            order.TrackingNumber = trackingNumber;

            // Send notifications using abstraction
            notificationService.SendOrderConfirmation(customerEmail, order);
            notificationService.SendShippingNotification(customerEmail, trackingNumber);

            logger.Log($"Order {order.Id} completed successfully");

            return new OrderResult 
            { 
                Success = true, 
                OrderId = order.Id,
                TrackingNumber = trackingNumber
            };
        }
        catch (Exception ex)
        {
            logger.LogError($"Order processing failed", ex);
            return new OrderResult 
            { 
                Success = false, 
                Message = "Order processing failed. Please try again." 
            };
        }
    }

    private decimal CalculateTotalWeight(List<OrderItem> items)
    {
        decimal totalWeight = 0;
        foreach (var item in items)
        {
            var product = productRepository.GetById(item.ProductId);
            if (product != null)
            {
                totalWeight += product.Weight * item.Quantity;
            }
        }
        return totalWeight;
    }
}

// ========== INFRASTRUCTURE IMPLEMENTATIONS (Low-level modules) ==========

/// <summary>
/// SQL implementation of product repository
/// This is a low-level module that implements the abstraction
/// </summary>
public class SqlProductRepository : IProductRepository
{
    private readonly string connectionString;
    private readonly ILogger logger;

    public SqlProductRepository(string connectionString, ILogger logger)
    {
        this.connectionString = connectionString;
        this.logger = logger;
    }

    public Product? GetById(string id)
    {
        logger.Log($"[SQL] Fetching product {id}");
        // In real implementation, would query SQL database
        return new Product { Id = id, Name = "Sample Product", Price = 99.99m, Weight = 1.5m };
    }

    public void Save(Product product)
    {
        logger.Log($"[SQL] Saving product {product.Id}");
        // In real implementation, would save to SQL database
    }
}

/// <summary>
/// MongoDB implementation of product repository
/// Shows how easy it is to swap implementations
/// </summary>
public class MongoProductRepository : IProductRepository
{
    private readonly string connectionString;
    private readonly ILogger logger;

    public MongoProductRepository(string connectionString, ILogger logger)
    {
        this.connectionString = connectionString;
        this.logger = logger;
    }

    public Product? GetById(string id)
    {
        logger.Log($"[MongoDB] Finding product {id}");
        // In real implementation, would query MongoDB
        return new Product { Id = id, Name = "Sample Product", Price = 99.99m, Weight = 1.5m };
    }

    public void Save(Product product)
    {
        logger.Log($"[MongoDB] Inserting product {product.Id}");
        // In real implementation, would save to MongoDB
    }
}

/// <summary>
/// Default order service implementation
/// </summary>
public class DefaultOrderService : IOrderService
{
    private readonly IPaymentGateway paymentGateway;
    private readonly ILogger logger;

    public DefaultOrderService(IPaymentGateway paymentGateway, ILogger logger)
    {
        this.paymentGateway = paymentGateway;
        this.logger = logger;
    }

    public Order CreateOrder(string customerId, List<OrderItem> items)
    {
        var order = new Order
        {
            Id = Guid.NewGuid().ToString(),
            CustomerId = customerId,
            Items = items,
            OrderDate = DateTime.Now,
            Status = OrderStatus.Pending
        };

        // Calculate subtotal
        decimal subtotal = 0;
        foreach (var item in items)
        {
            subtotal += item.Price * item.Quantity;
        }
        order.Subtotal = subtotal;
        order.Total = subtotal; // Shipping will be added later

        logger.Log($"Created order {order.Id} for customer {customerId}");
        return order;
    }

    public void ProcessPayment(Order order, PaymentMethod paymentMethod)
    {
        logger.Log($"Processing payment for order {order.Id}");
        
        var result = paymentGateway.ProcessPayment(order.Total, paymentMethod);
        
        if (result.Success)
        {
            order.PaymentTransactionId = result.TransactionId;
            order.Status = OrderStatus.Paid;
        }
        else
        {
            throw new PaymentException($"Payment failed: {result.ErrorMessage}");
        }
    }
}

/// <summary>
/// Email notification service
/// </summary>
public class EmailNotificationService : INotificationService
{
    private readonly string smtpServer;
    private readonly ILogger logger;

    public EmailNotificationService(string smtpServer, ILogger logger)
    {
        this.smtpServer = smtpServer;
        this.logger = logger;
    }

    public void SendOrderConfirmation(string email, Order order)
    {
        logger.Log($"[Email] Sending order confirmation to {email}");
        Console.WriteLine($"To: {email}");
        Console.WriteLine($"Subject: Order Confirmation - {order.Id}");
        Console.WriteLine($"Your order total: ${order.Total:F2}");
    }

    public void SendShippingNotification(string email, string trackingNumber)
    {
        logger.Log($"[Email] Sending shipping notification to {email}");
        Console.WriteLine($"To: {email}");
        Console.WriteLine($"Subject: Your order has shipped!");
        Console.WriteLine($"Tracking number: {trackingNumber}");
    }
}

/// <summary>
/// SMS notification service - alternative implementation
/// </summary>
public class SmsNotificationService : INotificationService
{
    private readonly string twilioApiKey;
    private readonly ILogger logger;

    public SmsNotificationService(string twilioApiKey, ILogger logger)
    {
        this.twilioApiKey = twilioApiKey;
        this.logger = logger;
    }

    public void SendOrderConfirmation(string phoneNumber, Order order)
    {
        logger.Log($"[SMS] Sending order confirmation to {phoneNumber}");
        Console.WriteLine($"SMS to {phoneNumber}: Order {order.Id} confirmed. Total: ${order.Total:F2}");
    }

    public void SendShippingNotification(string phoneNumber, string trackingNumber)
    {
        logger.Log($"[SMS] Sending shipping notification to {phoneNumber}");
        Console.WriteLine($"SMS to {phoneNumber}: Order shipped! Track: {trackingNumber}");
    }
}

/// <summary>
/// Stripe payment gateway implementation
/// </summary>
public class StripePaymentGateway : IPaymentGateway
{
    private readonly string apiKey;
    private readonly ILogger logger;

    public StripePaymentGateway(string apiKey, ILogger logger)
    {
        this.apiKey = apiKey;
        this.logger = logger;
    }

    public PaymentResult ProcessPayment(decimal amount, PaymentMethod method)
    {
        logger.Log($"[Stripe] Processing ${amount} payment");
        
        // Simulate Stripe API call
        if (method.CardNumber.StartsWith("4"))
        {
            return new PaymentResult
            {
                Success = true,
                TransactionId = $"stripe_{Guid.NewGuid().ToString().Substring(0, 10)}"
            };
        }
        
        return new PaymentResult
        {
            Success = false,
            ErrorMessage = "Invalid card number"
        };
    }
}

/// <summary>
/// PayPal payment gateway - alternative implementation
/// </summary>
public class PayPalPaymentGateway : IPaymentGateway
{
    private readonly string clientId;
    private readonly string clientSecret;
    private readonly ILogger logger;

    public PayPalPaymentGateway(string clientId, string clientSecret, ILogger logger)
    {
        this.clientId = clientId;
        this.clientSecret = clientSecret;
        this.logger = logger;
    }

    public PaymentResult ProcessPayment(decimal amount, PaymentMethod method)
    {
        logger.Log($"[PayPal] Processing ${amount} payment");
        
        // Simulate PayPal API call
        return new PaymentResult
        {
            Success = true,
            TransactionId = $"paypal_{Guid.NewGuid().ToString().Substring(0, 10)}"
        };
    }
}

/// <summary>
/// In-memory inventory manager
/// </summary>
public class InMemoryInventoryManager : IInventoryManager
{
    private readonly Dictionary<string, int> inventory = new()
    {
        ["PROD001"] = 100,
        ["PROD002"] = 50,
        ["PROD003"] = 25
    };
    private readonly ILogger logger;

    public InMemoryInventoryManager(ILogger logger)
    {
        this.logger = logger;
    }

    public bool CheckStock(string productId, int quantity)
    {
        if (inventory.TryGetValue(productId, out var stock))
        {
            return stock >= quantity;
        }
        return false;
    }

    public void ReserveStock(string productId, int quantity)
    {
        if (inventory.ContainsKey(productId))
        {
            inventory[productId] -= quantity;
            logger.Log($"Reserved {quantity} units of {productId}");
        }
    }
}

/// <summary>
/// FedEx shipping provider
/// </summary>
public class FedExShippingProvider : IShippingProvider
{
    private readonly ILogger logger;

    public FedExShippingProvider(ILogger logger)
    {
        this.logger = logger;
    }

    public ShippingInfo CalculateShipping(Address destination, decimal weight)
    {
        logger.Log($"[FedEx] Calculating shipping to {destination.City}");
        
        // Simple calculation based on weight
        var baseCost = 5.99m;
        var perPoundCost = 1.50m;
        var cost = baseCost + (weight * perPoundCost);
        
        return new ShippingInfo
        {
            Cost = cost,
            EstimatedDays = 3,
            Carrier = "FedEx"
        };
    }

    public string CreateShippingLabel(Order order)
    {
        logger.Log($"[FedEx] Creating shipping label for order {order.Id}");
        return $"FEDEX-{order.Id.Substring(0, 8).ToUpper()}";
    }
}

/// <summary>
/// UPS shipping provider - alternative implementation
/// </summary>
public class UpsShippingProvider : IShippingProvider
{
    private readonly ILogger logger;

    public UpsShippingProvider(ILogger logger)
    {
        this.logger = logger;
    }

    public ShippingInfo CalculateShipping(Address destination, decimal weight)
    {
        logger.Log($"[UPS] Calculating shipping to {destination.City}");
        
        // Different calculation than FedEx
        var baseCost = 4.99m;
        var perPoundCost = 1.75m;
        var cost = baseCost + (weight * perPoundCost);
        
        return new ShippingInfo
        {
            Cost = cost,
            EstimatedDays = 4,
            Carrier = "UPS"
        };
    }

    public string CreateShippingLabel(Order order)
    {
        logger.Log($"[UPS] Creating shipping label for order {order.Id}");
        return $"1Z{order.Id.Substring(0, 8).ToUpper()}";
    }
}

// ========== DEPENDENCY INJECTION SETUP ==========

/// <summary>
/// Factory class to demonstrate dependency injection configuration
/// </summary>
public static class ServiceFactory
{
    public static ECommerceService CreateECommerceService(bool useMongoDB = false, bool usePayPal = false)
    {
        // Create logger
        var logger = new ConsoleLogger();
        
        // Choose implementations
        IProductRepository productRepo = useMongoDB
            ? new MongoProductRepository("mongodb://localhost", logger)
            : new SqlProductRepository("Server=localhost;Database=ecommerce", logger);
            
        IPaymentGateway paymentGateway = usePayPal
            ? new PayPalPaymentGateway("client123", "secret456", logger)
            : new StripePaymentGateway("sk_test_123", logger);
            
        // Create services
        var orderService = new DefaultOrderService(paymentGateway, logger);
        var notificationService = new EmailNotificationService("smtp.gmail.com", logger);
        var inventoryManager = new InMemoryInventoryManager(logger);
        var shippingProvider = new FedExShippingProvider(logger);
        
        // Inject all dependencies
        return new ECommerceService(
            productRepo,
            orderService,
            notificationService,
            inventoryManager,
            shippingProvider,
            logger
        );
    }
}

// ========== SUPPORTING CLASSES ==========

public class Product
{
    public string Id { get; set; } = "";
    public string Name { get; set; } = "";
    public decimal Price { get; set; }
    public decimal Weight { get; set; }
}

public class Order
{
    public string Id { get; set; } = "";
    public string CustomerId { get; set; } = "";
    public List<OrderItem> Items { get; set; } = new();
    public Address ShippingAddress { get; set; } = new();
    public decimal Subtotal { get; set; }
    public decimal ShippingCost { get; set; }
    public decimal Total { get; set; }
    public OrderStatus Status { get; set; }
    public DateTime OrderDate { get; set; }
    public string PaymentTransactionId { get; set; } = "";
    public string TrackingNumber { get; set; } = "";
}

public class OrderItem
{
    public string ProductId { get; set; } = "";
    public int Quantity { get; set; }
    public decimal Price { get; set; }
}

public class Address
{
    public string Street { get; set; } = "";
    public string City { get; set; } = "";
    public string State { get; set; } = "";
    public string ZipCode { get; set; } = "";
    public string Country { get; set; } = "";
}

public enum OrderStatus
{
    Pending,
    Paid,
    Shipped,
    Delivered,
    Cancelled
}

public class PaymentMethod
{
    public string CardNumber { get; set; } = "";
    public string ExpiryDate { get; set; } = "";
    public string CVV { get; set; } = "";
}

public class PaymentResult
{
    public bool Success { get; set; }
    public string TransactionId { get; set; } = "";
    public string ErrorMessage { get; set; } = "";
}

public class ShippingInfo
{
    public decimal Cost { get; set; }
    public int EstimatedDays { get; set; }
    public string Carrier { get; set; } = "";
}

public class OrderResult
{
    public bool Success { get; set; }
    public string OrderId { get; set; } = "";
    public string TrackingNumber { get; set; } = "";
    public string Message { get; set; } = "";
}

public class PaymentException : Exception
{
    public PaymentException(string message) : base(message) { }
}

public class ConsoleLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine($"[LOG] {DateTime.Now:yyyy-MM-dd HH:mm:ss} - {message}");
    }

    public void LogError(string message, Exception? exception = null)
    {
        Console.WriteLine($"[ERROR] {DateTime.Now:yyyy-MM-dd HH:mm:ss} - {message}");
        if (exception != null)
        {
            Console.WriteLine($"[ERROR] Exception: {exception.Message}");
        }
    }
}