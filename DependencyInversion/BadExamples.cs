namespace DependencyInversion.BadExamples;

/// <summary>
/// BAD EXAMPLE - EmailService directly depends on concrete implementations
/// 
/// This violates DIP because:
/// - High-level module (EmailService) depends on low-level modules (SmtpClient, FileLogger)
/// - Depends on concrete classes instead of abstractions
/// - Tightly coupled - hard to change or test
/// - Cannot easily switch implementations
/// </summary>
public class EmailService_Bad
{
    // VIOLATION: Direct dependency on concrete SmtpClient
    private readonly SmtpClient smtpClient;
    
    // VIOLATION: Direct dependency on concrete FileLogger
    private readonly FileLogger fileLogger;

    public EmailService_Bad()
    {
        // VIOLATION: Creating concrete instances directly
        smtpClient = new SmtpClient("smtp.gmail.com", 587);
        fileLogger = new FileLogger("email_log.txt");
    }

    public void SendEmail(string to, string subject, string body)
    {
        try
        {
            // Tightly coupled to specific SMTP implementation
            smtpClient.Connect();
            smtpClient.Send(to, subject, body);
            smtpClient.Disconnect();
            
            // Tightly coupled to file logging
            fileLogger.Log($"Email sent to {to}");
        }
        catch (Exception ex)
        {
            fileLogger.Log($"Failed to send email: {ex.Message}");
            throw;
        }
    }
}

/// <summary>
/// Concrete SMTP client - low-level module
/// </summary>
public class SmtpClient
{
    private readonly string host;
    private readonly int port;
    private bool isConnected;

    public SmtpClient(string host, int port)
    {
        this.host = host;
        this.port = port;
    }

    public void Connect()
    {
        Console.WriteLine($"Connecting to SMTP server {host}:{port}");
        isConnected = true;
    }

    public void Send(string to, string subject, string body)
    {
        if (!isConnected)
            throw new InvalidOperationException("Not connected to SMTP server");
        
        Console.WriteLine($"Sending email via SMTP to {to}");
        Console.WriteLine($"Subject: {subject}");
        Console.WriteLine($"Body: {body}");
    }

    public void Disconnect()
    {
        Console.WriteLine("Disconnecting from SMTP server");
        isConnected = false;
    }
}

/// <summary>
/// Concrete file logger - low-level module
/// </summary>
public class FileLogger
{
    private readonly string filePath;

    public FileLogger(string filePath)
    {
        this.filePath = filePath;
    }

    public void Log(string message)
    {
        var logEntry = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] {message}";
        Console.WriteLine($"Writing to file {filePath}: {logEntry}");
        // In real implementation, would write to file
    }
}

/// <summary>
/// BAD EXAMPLE - OrderService with concrete dependencies
/// </summary>
public class OrderService_Bad
{
    // VIOLATION: Depends on concrete database
    private readonly SqlDatabase database;
    
    // VIOLATION: Depends on concrete payment gateway
    private readonly PayPalGateway paymentGateway;
    
    // VIOLATION: Depends on concrete inventory system
    private readonly WarehouseInventory inventory;
    
    // VIOLATION: Depends on concrete notification service
    private readonly EmailNotification emailNotification;

    public OrderService_Bad()
    {
        // VIOLATION: Creating all concrete dependencies
        database = new SqlDatabase("server=localhost;database=orders");
        paymentGateway = new PayPalGateway("api_key_123");
        inventory = new WarehouseInventory();
        emailNotification = new EmailNotification();
    }

    public void ProcessOrder(Order order)
    {
        // Tightly coupled to SQL database
        database.SaveOrder(order);
        
        // Tightly coupled to specific inventory system
        if (!inventory.CheckStock(order.ProductId, order.Quantity))
        {
            throw new InvalidOperationException("Insufficient stock");
        }
        
        // Tightly coupled to PayPal
        paymentGateway.ProcessPayment(order.Total);
        
        // Tightly coupled to email notifications
        emailNotification.SendOrderConfirmation(order.CustomerEmail, order.Id);
        
        // Update inventory - tightly coupled
        inventory.ReduceStock(order.ProductId, order.Quantity);
    }
}

/// <summary>
/// Concrete SQL database - low-level module
/// </summary>
public class SqlDatabase
{
    private readonly string connectionString;

    public SqlDatabase(string connectionString)
    {
        this.connectionString = connectionString;
    }

    public void SaveOrder(Order order)
    {
        Console.WriteLine($"Saving order {order.Id} to SQL database");
        Console.WriteLine($"Connection: {connectionString}");
        // SQL-specific implementation
    }

    public Order GetOrder(string orderId)
    {
        Console.WriteLine($"Retrieving order {orderId} from SQL database");
        // SQL-specific query
        return new Order { Id = orderId };
    }
}

/// <summary>
/// Concrete PayPal gateway - low-level module
/// </summary>
public class PayPalGateway
{
    private readonly string apiKey;

    public PayPalGateway(string apiKey)
    {
        this.apiKey = apiKey;
    }

    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing ${amount} payment through PayPal");
        Console.WriteLine($"Using API key: {apiKey.Substring(0, 5)}...");
        // PayPal-specific API calls
    }
}

/// <summary>
/// Concrete warehouse inventory - low-level module
/// </summary>
public class WarehouseInventory
{
    private readonly Dictionary<string, int> stock = new Dictionary<string, int>
    {
        ["PROD001"] = 100,
        ["PROD002"] = 50,
        ["PROD003"] = 200
    };

    public bool CheckStock(string productId, int quantity)
    {
        if (stock.TryGetValue(productId, out int available))
        {
            return available >= quantity;
        }
        return false;
    }

    public void ReduceStock(string productId, int quantity)
    {
        if (stock.ContainsKey(productId))
        {
            stock[productId] -= quantity;
            Console.WriteLine($"Reduced stock for {productId} by {quantity}");
        }
    }
}

/// <summary>
/// Concrete email notification - low-level module
/// </summary>
public class EmailNotification
{
    public void SendOrderConfirmation(string email, string orderId)
    {
        Console.WriteLine($"Sending order confirmation email to {email}");
        Console.WriteLine($"Order ID: {orderId}");
        // Email-specific implementation
    }
}

/// <summary>
/// BAD EXAMPLE - ReportGenerator with concrete dependencies
/// </summary>
public class ReportGenerator_Bad
{
    // VIOLATION: Depends on concrete data source
    private readonly DatabaseDataSource dataSource;
    
    // VIOLATION: Depends on concrete formatter
    private readonly PdfFormatter formatter;
    
    // VIOLATION: Depends on concrete storage
    private readonly FileSystemStorage storage;

    public ReportGenerator_Bad()
    {
        // VIOLATION: Creating concrete instances
        dataSource = new DatabaseDataSource();
        formatter = new PdfFormatter();
        storage = new FileSystemStorage();
    }

    public void GenerateReport(string reportName)
    {
        // Tightly coupled to database
        var data = dataSource.GetReportData(reportName);
        
        // Tightly coupled to PDF format
        var formattedReport = formatter.Format(data);
        
        // Tightly coupled to file system
        storage.Save(reportName + ".pdf", formattedReport);
    }
}

/// <summary>
/// Concrete database data source
/// </summary>
public class DatabaseDataSource
{
    public ReportData GetReportData(string reportName)
    {
        Console.WriteLine($"Fetching report data from database: {reportName}");
        return new ReportData 
        { 
            Title = reportName,
            Content = "Database report content"
        };
    }
}

/// <summary>
/// Concrete PDF formatter
/// </summary>
public class PdfFormatter
{
    public byte[] Format(ReportData data)
    {
        Console.WriteLine($"Formatting report as PDF: {data.Title}");
        // PDF-specific formatting
        return new byte[] { 1, 2, 3 }; // Simulated PDF data
    }
}

/// <summary>
/// Concrete file system storage
/// </summary>
public class FileSystemStorage
{
    public void Save(string fileName, byte[] data)
    {
        Console.WriteLine($"Saving file to disk: {fileName}");
        Console.WriteLine($"File size: {data.Length} bytes");
        // File system specific implementation
    }
}

/// <summary>
/// BAD EXAMPLE - WeatherService with concrete dependencies
/// </summary>
public class WeatherService_Bad
{
    // VIOLATION: Depends on specific weather API
    private readonly OpenWeatherMapApi weatherApi;
    
    // VIOLATION: Depends on concrete cache
    private readonly MemoryCache cache;
    
    // VIOLATION: Depends on concrete unit converter
    private readonly TemperatureConverter converter;

    public WeatherService_Bad()
    {
        // VIOLATION: Creating concrete instances
        weatherApi = new OpenWeatherMapApi("api_key_456");
        cache = new MemoryCache();
        converter = new TemperatureConverter();
    }

    public WeatherInfo GetWeather(string city)
    {
        // Tightly coupled to memory cache
        var cached = cache.Get<WeatherInfo>(city);
        if (cached != null)
            return cached;
        
        // Tightly coupled to specific API
        var weatherData = weatherApi.GetCurrentWeather(city);
        
        // Tightly coupled to temperature converter
        var tempInCelsius = converter.FahrenheitToCelsius(weatherData.Temperature);
        
        var weatherInfo = new WeatherInfo
        {
            City = city,
            Temperature = tempInCelsius,
            Description = weatherData.Description
        };
        
        cache.Set(city, weatherInfo, TimeSpan.FromMinutes(30));
        
        return weatherInfo;
    }
}

/// <summary>
/// Concrete weather API
/// </summary>
public class OpenWeatherMapApi
{
    private readonly string apiKey;

    public OpenWeatherMapApi(string apiKey)
    {
        this.apiKey = apiKey;
    }

    public WeatherData GetCurrentWeather(string city)
    {
        Console.WriteLine($"Fetching weather from OpenWeatherMap API for {city}");
        // API-specific implementation
        return new WeatherData
        {
            Temperature = 75.2, // Fahrenheit
            Description = "Partly cloudy"
        };
    }
}

/// <summary>
/// Concrete memory cache
/// </summary>
public class MemoryCache
{
    private readonly Dictionary<string, (object data, DateTime expiry)> cache = new();

    public T? Get<T>(string key) where T : class
    {
        if (cache.TryGetValue(key, out var entry))
        {
            if (entry.expiry > DateTime.Now)
            {
                Console.WriteLine($"Cache hit for key: {key}");
                return entry.data as T;
            }
            cache.Remove(key);
        }
        Console.WriteLine($"Cache miss for key: {key}");
        return null;
    }

    public void Set<T>(string key, T data, TimeSpan duration)
    {
        cache[key] = (data!, DateTime.Now.Add(duration));
        Console.WriteLine($"Cached data for key: {key}");
    }
}

/// <summary>
/// Concrete temperature converter
/// </summary>
public class TemperatureConverter
{
    public double FahrenheitToCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }

    public double CelsiusToFahrenheit(double celsius)
    {
        return celsius * 9 / 5 + 32;
    }
}

// Supporting classes
public class Order
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string ProductId { get; set; } = "";
    public int Quantity { get; set; }
    public decimal Total { get; set; }
    public string CustomerEmail { get; set; } = "";
}

public class ReportData
{
    public string Title { get; set; } = "";
    public string Content { get; set; } = "";
}

public class WeatherData
{
    public double Temperature { get; set; }
    public string Description { get; set; } = "";
}

public class WeatherInfo
{
    public string City { get; set; } = "";
    public double Temperature { get; set; }
    public string Description { get; set; } = "";
}