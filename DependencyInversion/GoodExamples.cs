namespace DependencyInversion.GoodExamples;

/// <summary>
/// GOOD EXAMPLE - EmailService depends on abstractions
/// 
/// Follows DIP by:
/// - High-level module depends on abstractions (interfaces)
/// - Low-level modules implement the abstractions
/// - Dependencies are injected, not created
/// - Easy to test and change implementations
/// </summary>

// ========== ABSTRACTIONS (INTERFACES) ==========

/// <summary>
/// Abstraction for email delivery
/// </summary>
public interface IEmailSender
{
    void SendEmail(string to, string subject, string body);
}

/// <summary>
/// Abstraction for logging
/// </summary>
public interface ILogger
{
    void Log(string message);
    void LogError(string message, Exception? exception = null);
}

/// <summary>
/// High-level module - depends only on abstractions
/// </summary>
public class EmailService
{
    private readonly IEmailSender emailSender;
    private readonly ILogger logger;

    // Dependencies injected through constructor
    public EmailService(IEmailSender emailSender, ILogger logger)
    {
        this.emailSender = emailSender;
        this.logger = logger;
    }

    public void SendEmail(string to, string subject, string body)
    {
        try
        {
            logger.Log($"Sending email to {to}");
            
            // Uses abstraction - doesn't know or care about implementation
            emailSender.SendEmail(to, subject, body);
            
            logger.Log($"Email sent successfully to {to}");
        }
        catch (Exception ex)
        {
            logger.LogError($"Failed to send email to {to}", ex);
            throw;
        }
    }
}

// ========== CONCRETE IMPLEMENTATIONS ==========

/// <summary>
/// SMTP implementation of IEmailSender
/// </summary>
public class SmtpEmailSender : IEmailSender
{
    private readonly string host;
    private readonly int port;

    public SmtpEmailSender(string host, int port)
    {
        this.host = host;
        this.port = port;
    }

    public void SendEmail(string to, string subject, string body)
    {
        Console.WriteLine($"[SMTP] Connecting to {host}:{port}");
        Console.WriteLine($"[SMTP] Sending to: {to}");
        Console.WriteLine($"[SMTP] Subject: {subject}");
        Console.WriteLine($"[SMTP] Body: {body}");
        Console.WriteLine("[SMTP] Email sent successfully");
    }
}

/// <summary>
/// SendGrid implementation of IEmailSender
/// </summary>
public class SendGridEmailSender : IEmailSender
{
    private readonly string apiKey;

    public SendGridEmailSender(string apiKey)
    {
        this.apiKey = apiKey;
    }

    public void SendEmail(string to, string subject, string body)
    {
        Console.WriteLine($"[SendGrid] Using API key: {apiKey.Substring(0, 5)}...");
        Console.WriteLine($"[SendGrid] Sending to: {to}");
        Console.WriteLine($"[SendGrid] Subject: {subject}");
        Console.WriteLine($"[SendGrid] Email queued for delivery");
    }
}

/// <summary>
/// Console logger implementation
/// </summary>
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

/// <summary>
/// File logger implementation
/// </summary>
public class FileLogger : ILogger
{
    private readonly string logPath;

    public FileLogger(string logPath)
    {
        this.logPath = logPath;
    }

    public void Log(string message)
    {
        var logEntry = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - {message}";
        Console.WriteLine($"[FileLogger] Writing to {logPath}: {logEntry}");
    }

    public void LogError(string message, Exception? exception = null)
    {
        var logEntry = $"ERROR - {DateTime.Now:yyyy-MM-dd HH:mm:ss} - {message}";
        if (exception != null)
        {
            logEntry += $"\nException: {exception}";
        }
        Console.WriteLine($"[FileLogger] Writing to {logPath}: {logEntry}");
    }
}

/// <summary>
/// GOOD EXAMPLE - OrderService with dependency injection
/// </summary>

// ========== ORDER SERVICE ABSTRACTIONS ==========

public interface IOrderRepository
{
    void SaveOrder(Order order);
    Order GetOrder(string orderId);
}

public interface IPaymentGateway
{
    PaymentResult ProcessPayment(decimal amount, string currency = "USD");
}

public interface IInventoryService
{
    bool CheckAvailability(string productId, int quantity);
    void ReserveItems(string productId, int quantity);
}

public interface INotificationService
{
    void SendOrderConfirmation(string recipient, Order order);
}

/// <summary>
/// High-level order service - depends only on abstractions
/// </summary>
public class OrderService
{
    private readonly IOrderRepository repository;
    private readonly IPaymentGateway paymentGateway;
    private readonly IInventoryService inventoryService;
    private readonly INotificationService notificationService;
    private readonly ILogger logger;

    // All dependencies injected
    public OrderService(
        IOrderRepository repository,
        IPaymentGateway paymentGateway,
        IInventoryService inventoryService,
        INotificationService notificationService,
        ILogger logger)
    {
        this.repository = repository;
        this.paymentGateway = paymentGateway;
        this.inventoryService = inventoryService;
        this.notificationService = notificationService;
        this.logger = logger;
    }

    public void ProcessOrder(Order order)
    {
        logger.Log($"Processing order {order.Id}");

        // Check inventory using abstraction
        if (!inventoryService.CheckAvailability(order.ProductId, order.Quantity))
        {
            throw new InvalidOperationException("Product not available");
        }

        // Process payment using abstraction
        var paymentResult = paymentGateway.ProcessPayment(order.Total);
        if (!paymentResult.Success)
        {
            throw new InvalidOperationException($"Payment failed: {paymentResult.Message}");
        }

        // Reserve inventory
        inventoryService.ReserveItems(order.ProductId, order.Quantity);

        // Save order using abstraction
        repository.SaveOrder(order);

        // Send notification using abstraction
        notificationService.SendOrderConfirmation(order.CustomerEmail, order);

        logger.Log($"Order {order.Id} processed successfully");
    }
}

// ========== CONCRETE IMPLEMENTATIONS ==========

/// <summary>
/// SQL implementation of order repository
/// </summary>
public class SqlOrderRepository : IOrderRepository
{
    private readonly string connectionString;

    public SqlOrderRepository(string connectionString)
    {
        this.connectionString = connectionString;
    }

    public void SaveOrder(Order order)
    {
        Console.WriteLine($"[SQL] Saving order {order.Id} to database");
        Console.WriteLine($"[SQL] Connection: {connectionString}");
    }

    public Order GetOrder(string orderId)
    {
        Console.WriteLine($"[SQL] Retrieving order {orderId}");
        return new Order { Id = orderId };
    }
}

/// <summary>
/// MongoDB implementation of order repository
/// </summary>
public class MongoOrderRepository : IOrderRepository
{
    private readonly string connectionString;

    public MongoOrderRepository(string connectionString)
    {
        this.connectionString = connectionString;
    }

    public void SaveOrder(Order order)
    {
        Console.WriteLine($"[MongoDB] Saving order {order.Id} to collection");
        Console.WriteLine($"[MongoDB] Database: {connectionString}");
    }

    public Order GetOrder(string orderId)
    {
        Console.WriteLine($"[MongoDB] Finding order {orderId}");
        return new Order { Id = orderId };
    }
}

/// <summary>
/// Stripe payment gateway implementation
/// </summary>
public class StripePaymentGateway : IPaymentGateway
{
    private readonly string apiKey;

    public StripePaymentGateway(string apiKey)
    {
        this.apiKey = apiKey;
    }

    public PaymentResult ProcessPayment(decimal amount, string currency = "USD")
    {
        Console.WriteLine($"[Stripe] Processing {currency} {amount} payment");
        Console.WriteLine($"[Stripe] Using API key: {apiKey.Substring(0, 5)}...");
        
        return new PaymentResult
        {
            Success = true,
            TransactionId = Guid.NewGuid().ToString(),
            Message = "Payment processed successfully"
        };
    }
}

/// <summary>
/// PayPal payment gateway implementation
/// </summary>
public class PayPalPaymentGateway : IPaymentGateway
{
    private readonly string clientId;
    private readonly string clientSecret;

    public PayPalPaymentGateway(string clientId, string clientSecret)
    {
        this.clientId = clientId;
        this.clientSecret = clientSecret;
    }

    public PaymentResult ProcessPayment(decimal amount, string currency = "USD")
    {
        Console.WriteLine($"[PayPal] Processing {currency} {amount} payment");
        Console.WriteLine($"[PayPal] Client ID: {clientId}");
        
        return new PaymentResult
        {
            Success = true,
            TransactionId = $"PP-{Guid.NewGuid().ToString().Substring(0, 8)}",
            Message = "PayPal payment completed"
        };
    }
}

/// <summary>
/// GOOD EXAMPLE - Report generator with dependency injection
/// </summary>

// ========== REPORT ABSTRACTIONS ==========

public interface IDataSource
{
    ReportData GetData(string query);
}

public interface IReportFormatter
{
    byte[] Format(ReportData data);
    string GetFileExtension();
}

public interface IReportStorage
{
    void Save(string fileName, byte[] data);
    byte[] Load(string fileName);
}

/// <summary>
/// High-level report generator - depends on abstractions
/// </summary>
public class ReportGenerator
{
    private readonly IDataSource dataSource;
    private readonly IReportFormatter formatter;
    private readonly IReportStorage storage;
    private readonly ILogger logger;

    public ReportGenerator(
        IDataSource dataSource,
        IReportFormatter formatter,
        IReportStorage storage,
        ILogger logger)
    {
        this.dataSource = dataSource;
        this.formatter = formatter;
        this.storage = storage;
        this.logger = logger;
    }

    public void GenerateReport(string reportName, string query)
    {
        logger.Log($"Generating report: {reportName}");

        // Get data from any source
        var data = dataSource.GetData(query);

        // Format using any formatter
        var formattedData = formatter.Format(data);

        // Save using any storage
        var fileName = $"{reportName}{formatter.GetFileExtension()}";
        storage.Save(fileName, formattedData);

        logger.Log($"Report saved as: {fileName}");
    }
}

// ========== CONCRETE IMPLEMENTATIONS ==========

/// <summary>
/// Database data source
/// </summary>
public class DatabaseDataSource : IDataSource
{
    private readonly string connectionString;

    public DatabaseDataSource(string connectionString)
    {
        this.connectionString = connectionString;
    }

    public ReportData GetData(string query)
    {
        Console.WriteLine($"[Database] Executing query: {query}");
        return new ReportData
        {
            Title = "Database Report",
            Content = "Data from database query"
        };
    }
}

/// <summary>
/// API data source
/// </summary>
public class ApiDataSource : IDataSource
{
    private readonly string apiUrl;

    public ApiDataSource(string apiUrl)
    {
        this.apiUrl = apiUrl;
    }

    public ReportData GetData(string query)
    {
        Console.WriteLine($"[API] Fetching from: {apiUrl}/{query}");
        return new ReportData
        {
            Title = "API Report",
            Content = "Data from API endpoint"
        };
    }
}

/// <summary>
/// PDF formatter
/// </summary>
public class PdfReportFormatter : IReportFormatter
{
    public byte[] Format(ReportData data)
    {
        Console.WriteLine($"[PDF] Formatting report: {data.Title}");
        return new byte[] { 80, 68, 70 }; // "PDF"
    }

    public string GetFileExtension() => ".pdf";
}

/// <summary>
/// Excel formatter
/// </summary>
public class ExcelReportFormatter : IReportFormatter
{
    public byte[] Format(ReportData data)
    {
        Console.WriteLine($"[Excel] Creating spreadsheet: {data.Title}");
        return new byte[] { 88, 76, 83, 88 }; // "XLSX"
    }

    public string GetFileExtension() => ".xlsx";
}

/// <summary>
/// File system storage
/// </summary>
public class FileSystemStorage : IReportStorage
{
    private readonly string basePath;

    public FileSystemStorage(string basePath)
    {
        this.basePath = basePath;
    }

    public void Save(string fileName, byte[] data)
    {
        var fullPath = System.IO.Path.Combine(basePath, fileName);
        Console.WriteLine($"[FileSystem] Saving to: {fullPath}");
        Console.WriteLine($"[FileSystem] Size: {data.Length} bytes");
    }

    public byte[] Load(string fileName)
    {
        var fullPath = System.IO.Path.Combine(basePath, fileName);
        Console.WriteLine($"[FileSystem] Loading from: {fullPath}");
        return new byte[0];
    }
}

/// <summary>
/// Cloud storage (S3)
/// </summary>
public class S3Storage : IReportStorage
{
    private readonly string bucketName;

    public S3Storage(string bucketName)
    {
        this.bucketName = bucketName;
    }

    public void Save(string fileName, byte[] data)
    {
        Console.WriteLine($"[S3] Uploading to bucket: {bucketName}");
        Console.WriteLine($"[S3] Key: {fileName}");
        Console.WriteLine($"[S3] Size: {data.Length} bytes");
    }

    public byte[] Load(string fileName)
    {
        Console.WriteLine($"[S3] Downloading from bucket: {bucketName}");
        Console.WriteLine($"[S3] Key: {fileName}");
        return new byte[0];
    }
}

/// <summary>
/// GOOD EXAMPLE - Weather service with dependency injection
/// </summary>

// ========== WEATHER SERVICE ABSTRACTIONS ==========

public interface IWeatherApi
{
    WeatherData GetWeather(string location);
}

public interface ICache
{
    T? Get<T>(string key) where T : class;
    void Set<T>(string key, T value, TimeSpan expiration);
}

public interface ITemperatureConverter
{
    double Convert(double value, TemperatureUnit from, TemperatureUnit to);
}

/// <summary>
/// High-level weather service
/// </summary>
public class WeatherService
{
    private readonly IWeatherApi weatherApi;
    private readonly ICache cache;
    private readonly ITemperatureConverter temperatureConverter;
    private readonly ILogger logger;

    public WeatherService(
        IWeatherApi weatherApi,
        ICache cache,
        ITemperatureConverter temperatureConverter,
        ILogger logger)
    {
        this.weatherApi = weatherApi;
        this.cache = cache;
        this.temperatureConverter = temperatureConverter;
        this.logger = logger;
    }

    public WeatherInfo GetWeather(string city, TemperatureUnit unit = TemperatureUnit.Celsius)
    {
        var cacheKey = $"weather_{city}_{unit}";
        
        // Try cache first
        var cached = cache.Get<WeatherInfo>(cacheKey);
        if (cached != null)
        {
            logger.Log($"Weather data for {city} retrieved from cache");
            return cached;
        }

        // Get from API
        logger.Log($"Fetching weather data for {city}");
        var weatherData = weatherApi.GetWeather(city);

        // Convert temperature if needed
        var temperature = weatherData.Temperature;
        if (weatherData.Unit != unit)
        {
            temperature = temperatureConverter.Convert(
                weatherData.Temperature, 
                weatherData.Unit, 
                unit
            );
        }

        var weatherInfo = new WeatherInfo
        {
            City = city,
            Temperature = temperature,
            Unit = unit,
            Description = weatherData.Description
        };

        // Cache the result
        cache.Set(cacheKey, weatherInfo, TimeSpan.FromMinutes(30));

        return weatherInfo;
    }
}

// ========== CONCRETE IMPLEMENTATIONS ==========

/// <summary>
/// OpenWeatherMap API implementation
/// </summary>
public class OpenWeatherMapApi : IWeatherApi
{
    private readonly string apiKey;

    public OpenWeatherMapApi(string apiKey)
    {
        this.apiKey = apiKey;
    }

    public WeatherData GetWeather(string location)
    {
        Console.WriteLine($"[OpenWeatherMap] Fetching weather for: {location}");
        Console.WriteLine($"[OpenWeatherMap] API Key: {apiKey.Substring(0, 5)}...");
        
        return new WeatherData
        {
            Temperature = 25.5,
            Unit = TemperatureUnit.Celsius,
            Description = "Partly cloudy"
        };
    }
}

/// <summary>
/// WeatherStack API implementation
/// </summary>
public class WeatherStackApi : IWeatherApi
{
    private readonly string accessKey;

    public WeatherStackApi(string accessKey)
    {
        this.accessKey = accessKey;
    }

    public WeatherData GetWeather(string location)
    {
        Console.WriteLine($"[WeatherStack] Getting current weather for: {location}");
        Console.WriteLine($"[WeatherStack] Access Key: {accessKey.Substring(0, 5)}...");
        
        return new WeatherData
        {
            Temperature = 77.9,
            Unit = TemperatureUnit.Fahrenheit,
            Description = "Sunny"
        };
    }
}

/// <summary>
/// Memory cache implementation
/// </summary>
public class MemoryCache : ICache
{
    private readonly Dictionary<string, (object value, DateTime expiry)> cache = new();

    public T? Get<T>(string key) where T : class
    {
        if (cache.TryGetValue(key, out var entry))
        {
            if (entry.expiry > DateTime.Now)
            {
                Console.WriteLine($"[MemoryCache] Hit: {key}");
                return entry.value as T;
            }
            cache.Remove(key);
        }
        Console.WriteLine($"[MemoryCache] Miss: {key}");
        return null;
    }

    public void Set<T>(string key, T value, TimeSpan expiration)
    {
        cache[key] = (value!, DateTime.Now.Add(expiration));
        Console.WriteLine($"[MemoryCache] Cached: {key} for {expiration.TotalMinutes} minutes");
    }
}

/// <summary>
/// Redis cache implementation
/// </summary>
public class RedisCache : ICache
{
    private readonly string connectionString;

    public RedisCache(string connectionString)
    {
        this.connectionString = connectionString;
    }

    public T? Get<T>(string key) where T : class
    {
        Console.WriteLine($"[Redis] GET {key}");
        // In real implementation, would connect to Redis
        return null;
    }

    public void Set<T>(string key, T value, TimeSpan expiration)
    {
        Console.WriteLine($"[Redis] SET {key} EX {expiration.TotalSeconds}");
        // In real implementation, would connect to Redis
    }
}

/// <summary>
/// Temperature converter implementation
/// </summary>
public class StandardTemperatureConverter : ITemperatureConverter
{
    public double Convert(double value, TemperatureUnit from, TemperatureUnit to)
    {
        if (from == to) return value;

        // Convert to Celsius first
        var celsius = from switch
        {
            TemperatureUnit.Fahrenheit => (value - 32) * 5 / 9,
            TemperatureUnit.Kelvin => value - 273.15,
            _ => value
        };

        // Convert from Celsius to target unit
        return to switch
        {
            TemperatureUnit.Fahrenheit => celsius * 9 / 5 + 32,
            TemperatureUnit.Kelvin => celsius + 273.15,
            _ => celsius
        };
    }
}

// ========== SUPPORTING CLASSES ==========

public class Order
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string ProductId { get; set; } = "";
    public int Quantity { get; set; }
    public decimal Total { get; set; }
    public string CustomerEmail { get; set; } = "";
}

public class PaymentResult
{
    public bool Success { get; set; }
    public string TransactionId { get; set; } = "";
    public string Message { get; set; } = "";
}

public class ReportData
{
    public string Title { get; set; } = "";
    public string Content { get; set; } = "";
}

public class WeatherData
{
    public double Temperature { get; set; }
    public TemperatureUnit Unit { get; set; }
    public string Description { get; set; } = "";
}

public class WeatherInfo
{
    public string City { get; set; } = "";
    public double Temperature { get; set; }
    public TemperatureUnit Unit { get; set; }
    public string Description { get; set; } = "";
}

public enum TemperatureUnit
{
    Celsius,
    Fahrenheit,
    Kelvin
}

/// <summary>
/// Simple inventory service implementation
/// </summary>
public class SimpleInventoryService : IInventoryService
{
    private readonly Dictionary<string, int> stock = new()
    {
        ["PROD001"] = 100,
        ["PROD002"] = 50
    };

    public bool CheckAvailability(string productId, int quantity)
    {
        return stock.TryGetValue(productId, out var available) && available >= quantity;
    }

    public void ReserveItems(string productId, int quantity)
    {
        if (stock.ContainsKey(productId))
        {
            stock[productId] -= quantity;
            Console.WriteLine($"[Inventory] Reserved {quantity} units of {productId}");
        }
    }
}

/// <summary>
/// Email notification service
/// </summary>
public class EmailNotificationService : INotificationService
{
    private readonly IEmailSender emailSender;

    public EmailNotificationService(IEmailSender emailSender)
    {
        this.emailSender = emailSender;
    }

    public void SendOrderConfirmation(string recipient, Order order)
    {
        var subject = $"Order Confirmation - {order.Id}";
        var body = $"Your order for {order.Quantity} items has been confirmed. Total: ${order.Total}";
        
        emailSender.SendEmail(recipient, subject, body);
    }
}