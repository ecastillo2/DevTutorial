using DependencyInversion.BadExamples;
using DependencyInversion.GoodExamples;
using DependencyInversion.PracticalExample;

Console.WriteLine("╔════════════════════════════════════════════════════════════════════════╗");
Console.WriteLine("║         DEPENDENCY INVERSION PRINCIPLE (DIP)                           ║");
Console.WriteLine("║                    S.O.L.I.D Principles - Part 5                      ║");
Console.WriteLine("╚════════════════════════════════════════════════════════════════════════╝");
Console.WriteLine();

// Display DIP concept
Console.WriteLine("DEPENDENCY INVERSION PRINCIPLE:");
Console.WriteLine("════════════════════════════════\n");

Console.WriteLine("┌─────────────────────────────────────────────────────────────────────┐");
Console.WriteLine("│                                                                     │");
Console.WriteLine("│  A. High-level modules should not depend on low-level modules.     │");
Console.WriteLine("│     Both should depend on abstractions.                             │");
Console.WriteLine("│                                                                     │");
Console.WriteLine("│  B. Abstractions should not depend on details.                     │");
Console.WriteLine("│     Details should depend on abstractions.                         │");
Console.WriteLine("│                                    - Robert C. Martin               │");
Console.WriteLine("│                                                                     │");
Console.WriteLine("└─────────────────────────────────────────────────────────────────────┘");
Console.WriteLine();

Console.WriteLine("WHY DIP MATTERS:");
Console.WriteLine("════════════════\n");

Console.WriteLine("┌────────────────────────────────┐     ┌────────────────────────────────┐");
Console.WriteLine("│      WITHOUT DIP (Bad)         │     │       WITH DIP (Good)          │");
Console.WriteLine("├────────────────────────────────┤     ├────────────────────────────────┤");
Console.WriteLine("│ • Tightly coupled code         │     │ • Loosely coupled code         │");
Console.WriteLine("│ • Hard to test                 │     │ • Easy to test                 │");
Console.WriteLine("│ • Difficult to change          │     │ • Easy to change               │");
Console.WriteLine("│ • Concrete dependencies        │     │ • Abstract dependencies        │");
Console.WriteLine("│ • Rigid architecture           │     │ • Flexible architecture        │");
Console.WriteLine("│ • Cannot swap implementations  │     │ • Easy to swap implementations │");
Console.WriteLine("└────────────────────────────────┘     └────────────────────────────────┘");
Console.WriteLine();

Console.WriteLine("TRADITIONAL LAYERED ARCHITECTURE (BAD):");
Console.WriteLine("═══════════════════════════════════════\n");

Console.WriteLine("    ┌─────────────────────┐");
Console.WriteLine("    │    UI Layer         │");
Console.WriteLine("    └──────────┬──────────┘");
Console.WriteLine("               ↓ depends on");
Console.WriteLine("    ┌─────────────────────┐");
Console.WriteLine("    │  Business Layer     │");
Console.WriteLine("    └──────────┬──────────┘");
Console.WriteLine("               ↓ depends on");
Console.WriteLine("    ┌─────────────────────┐");
Console.WriteLine("    │    Data Layer       │");
Console.WriteLine("    └─────────────────────┘");
Console.WriteLine();
Console.WriteLine("  ❌ High-level depends on low-level");
Console.WriteLine("  ❌ Changes ripple upward");
Console.WriteLine("  ❌ Can't test business without database");
Console.WriteLine();

Console.WriteLine("DEPENDENCY INVERTED ARCHITECTURE (GOOD):");
Console.WriteLine("════════════════════════════════════════\n");

Console.WriteLine("    ┌─────────────────────┐");
Console.WriteLine("    │    UI Layer         │");
Console.WriteLine("    └──────────┬──────────┘");
Console.WriteLine("               ↓ depends on");
Console.WriteLine("    ┌─────────────────────────────────────┐");
Console.WriteLine("    │         Business Layer               │");
Console.WriteLine("    │  ┌─────────────────────────────┐    │");
Console.WriteLine("    │  │   Interfaces (Abstractions)  │    │");
Console.WriteLine("    │  └─────────────────────────────┘    │");
Console.WriteLine("    └─────────────────────────────────────┘");
Console.WriteLine("               ↑ implements");
Console.WriteLine("    ┌─────────────────────┐");
Console.WriteLine("    │ Infrastructure Layer│");
Console.WriteLine("    │  (Concrete Impl)    │");
Console.WriteLine("    └─────────────────────┘");
Console.WriteLine();
Console.WriteLine("  ✅ Both depend on abstractions");
Console.WriteLine("  ✅ Easy to change implementations");
Console.WriteLine("  ✅ Testable with mocks");
Console.WriteLine();

Console.WriteLine("DEPENDENCY INJECTION PATTERNS:");
Console.WriteLine("══════════════════════════════\n");

Console.WriteLine("1. CONSTRUCTOR INJECTION:");
Console.WriteLine("   ┌────────────────────────────┐");
Console.WriteLine("   │ public Service(IRepo repo) │");
Console.WriteLine("   │ {                          │");
Console.WriteLine("   │     this.repo = repo;      │");
Console.WriteLine("   │ }                          │");
Console.WriteLine("   └────────────────────────────┘");
Console.WriteLine();

Console.WriteLine("2. PROPERTY INJECTION:");
Console.WriteLine("   ┌────────────────────────────┐");
Console.WriteLine("   │ public IRepo Repo { get;   │");
Console.WriteLine("   │                     set; } │");
Console.WriteLine("   └────────────────────────────┘");
Console.WriteLine();

Console.WriteLine("3. METHOD INJECTION:");
Console.WriteLine("   ┌────────────────────────────┐");
Console.WriteLine("   │ public void Process(       │");
Console.WriteLine("   │     ILogger logger)        │");
Console.WriteLine("   │ { ... }                    │");
Console.WriteLine("   └────────────────────────────┘");
Console.WriteLine();

Console.WriteLine("\n══════════════════════════════════════════════════════════════════");
Console.WriteLine("                    DIP IN ACTION - EXAMPLES");
Console.WriteLine("══════════════════════════════════════════════════════════════════\n");

// DEMONSTRATION 1: Bad Email Service
Console.WriteLine("1. BAD EXAMPLE - Email Service with Concrete Dependencies:");
Console.WriteLine("──────────────────────────────────────────────────────────");

var badEmailService = new EmailService_Bad();
badEmailService.SendEmail("user@example.com", "Test Subject", "Test Body");

Console.WriteLine("\n❌ PROBLEMS:");
Console.WriteLine("   - Cannot change SMTP server without modifying code");
Console.WriteLine("   - Cannot change logging mechanism");
Console.WriteLine("   - Hard to unit test");
Console.WriteLine("   - Tightly coupled to specific implementations");

// DEMONSTRATION 2: Good Email Service
Console.WriteLine("\n\n2. GOOD EXAMPLE - Email Service with Dependency Injection:");
Console.WriteLine("───────────────────────────────────────────────────────────");

// Using SMTP implementation
var smtpSender = new SmtpEmailSender("smtp.gmail.com", 587);
var consoleLogger = new DependencyInversion.GoodExamples.ConsoleLogger();
var goodEmailService = new EmailService(smtpSender, consoleLogger);

goodEmailService.SendEmail("user@example.com", "Test Subject", "Test Body");

// Easy to switch to SendGrid
Console.WriteLine("\nSwitching to SendGrid implementation:");
var sendGridSender = new SendGridEmailSender("sg_api_key_123");
var fileLogger = new DependencyInversion.GoodExamples.FileLogger("email.log");
var sendGridEmailService = new EmailService(sendGridSender, fileLogger);

sendGridEmailService.SendEmail("user@example.com", "Test Subject", "Test Body");

Console.WriteLine("\n✅ BENEFITS:");
Console.WriteLine("   - Easy to change implementations");
Console.WriteLine("   - Can use different email providers");
Console.WriteLine("   - Can use different logging strategies");
Console.WriteLine("   - Easy to test with mocks");

// DEMONSTRATION 3: Bad Order Service
Console.WriteLine("\n\n3. BAD EXAMPLE - Order Service with Concrete Dependencies:");
Console.WriteLine("───────────────────────────────────────────────────────────");

var badOrderService = new OrderService_Bad();
var order = new DependencyInversion.BadExamples.Order
{
    ProductId = "PROD001",
    Quantity = 5,
    Total = 99.99m,
    CustomerEmail = "customer@example.com"
};

try
{
    badOrderService.ProcessOrder(order);
}
catch (Exception ex)
{
    Console.WriteLine($"Order processing failed: {ex.Message}");
}

// DEMONSTRATION 4: Good Order Service
Console.WriteLine("\n\n4. GOOD EXAMPLE - Order Service with Dependency Injection:");
Console.WriteLine("───────────────────────────────────────────────────────────");

// Create implementations
var sqlRepository = new SqlOrderRepository("server=localhost;database=orders");
var stripeGateway = new DependencyInversion.GoodExamples.StripePaymentGateway("sk_test_123");
var inventoryService = new SimpleInventoryService();
var emailNotification = new DependencyInversion.GoodExamples.EmailNotificationService(smtpSender);

// Inject dependencies
var goodOrderService = new OrderService(
    sqlRepository,
    stripeGateway,
    inventoryService,
    emailNotification,
    consoleLogger
);

var goodOrder = new DependencyInversion.GoodExamples.Order
{
    ProductId = "PROD001",
    Quantity = 5,
    Total = 99.99m,
    CustomerEmail = "customer@example.com"
};

goodOrderService.ProcessOrder(goodOrder);

// Easy to switch implementations
Console.WriteLine("\nSwitching to MongoDB and PayPal:");
var mongoRepository = new MongoOrderRepository("mongodb://localhost:27017/orders");
var payPalGateway = new DependencyInversion.GoodExamples.PayPalPaymentGateway("client_123", "secret_456");

var alternativeOrderService = new OrderService(
    mongoRepository,
    payPalGateway,
    inventoryService,
    emailNotification,
    consoleLogger
);

alternativeOrderService.ProcessOrder(goodOrder);

// DEMONSTRATION 5: Report Generator
Console.WriteLine("\n\n5. FLEXIBLE REPORT GENERATION:");
Console.WriteLine("═══════════════════════════════");

// PDF report from database
var dbDataSource = new DependencyInversion.GoodExamples.DatabaseDataSource("server=localhost");
var pdfFormatter = new PdfReportFormatter();
var fileStorage = new DependencyInversion.GoodExamples.FileSystemStorage("/reports");

var pdfReportGenerator = new ReportGenerator(
    dbDataSource,
    pdfFormatter,
    fileStorage,
    consoleLogger
);

pdfReportGenerator.GenerateReport("Sales Report", "SELECT * FROM sales");

// Excel report from API
Console.WriteLine("\nSwitching to API source and Excel format:");
var apiDataSource = new ApiDataSource("https://api.example.com");
var excelFormatter = new ExcelReportFormatter();
var s3Storage = new S3Storage("my-reports-bucket");

var excelReportGenerator = new ReportGenerator(
    apiDataSource,
    excelFormatter,
    s3Storage,
    consoleLogger
);

excelReportGenerator.GenerateReport("Customer Report", "customers/active");

// DEMONSTRATION 6: Weather Service
Console.WriteLine("\n\n6. WEATHER SERVICE WITH MULTIPLE PROVIDERS:");
Console.WriteLine("════════════════════════════════════════════");

// Using OpenWeatherMap
var openWeatherApi = new DependencyInversion.GoodExamples.OpenWeatherMapApi("owm_api_key");
var memoryCache = new DependencyInversion.GoodExamples.MemoryCache();
var tempConverter = new StandardTemperatureConverter();

var weatherService = new WeatherService(
    openWeatherApi,
    memoryCache,
    tempConverter,
    consoleLogger
);

var weather = weatherService.GetWeather("New York", TemperatureUnit.Celsius);
Console.WriteLine($"\nWeather in {weather.City}: {weather.Temperature}°C - {weather.Description}");

// Switch to WeatherStack
Console.WriteLine("\nSwitching to WeatherStack API:");
var weatherStackApi = new WeatherStackApi("ws_access_key");
var redisCache = new RedisCache("localhost:6379");

var alternativeWeatherService = new WeatherService(
    weatherStackApi,
    redisCache,
    tempConverter,
    consoleLogger
);

var weather2 = alternativeWeatherService.GetWeather("London", TemperatureUnit.Fahrenheit);
Console.WriteLine($"Weather in {weather2.City}: {weather2.Temperature}°F - {weather2.Description}");

// DEMONSTRATION 7: Testing Benefits
Console.WriteLine("\n\n7. TESTING BENEFITS OF DIP:");
Console.WriteLine("════════════════════════════");

Console.WriteLine("\n┌────────────────────────────────────────────────────────────┐");
Console.WriteLine("│              UNIT TESTING SCENARIO                         │");
Console.WriteLine("├────────────────────────────────────────────────────────────┤");
Console.WriteLine("│ Testing OrderService                                       │");
Console.WriteLine("│                                                            │");
Console.WriteLine("│ Without DIP:                                               │");
Console.WriteLine("│ • Need real database                                       │");
Console.WriteLine("│ • Need real payment gateway                                │");
Console.WriteLine("│ • Tests are slow and brittle                              │");
Console.WriteLine("│ • Can't test error scenarios easily                       │");
Console.WriteLine("│                                                            │");
Console.WriteLine("│ With DIP:                                                  │");
Console.WriteLine("│ • Use mock implementations                                 │");
Console.WriteLine("│ • Tests run in memory                                      │");
Console.WriteLine("│ • Fast and reliable                                        │");
Console.WriteLine("│ • Easy to test edge cases                                  │");
Console.WriteLine("└────────────────────────────────────────────────────────────┘");

// DEMONSTRATION 8: Practical E-Commerce Example
Console.WriteLine("\n\n8. PRACTICAL EXAMPLE - Complete E-Commerce System:");
Console.WriteLine("═══════════════════════════════════════════════════");

// Create e-commerce service with SQL and Stripe
var ecommerceService1 = ServiceFactory.CreateECommerceService(useMongoDB: false, usePayPal: false);

Console.WriteLine("\nConfiguration 1: SQL Database + Stripe Payment");
Console.WriteLine("──────────────────────────────────────────────");

var orderItems = new List<OrderItem>
{
    new() { ProductId = "PROD001", Quantity = 2, Price = 49.99m },
    new() { ProductId = "PROD002", Quantity = 1, Price = 99.99m }
};

var shippingAddress = new Address
{
    Street = "123 Main St",
    City = "New York",
    State = "NY",
    ZipCode = "10001",
    Country = "USA"
};

var paymentMethod = new PaymentMethod
{
    CardNumber = "4111111111111111",
    ExpiryDate = "12/25",
    CVV = "123"
};

var result1 = ecommerceService1.PlaceOrder(
    "CUST001", 
    "customer@example.com", 
    orderItems, 
    paymentMethod, 
    shippingAddress
);

if (result1.Success)
{
    Console.WriteLine($"\n✅ Order placed successfully!");
    Console.WriteLine($"   Order ID: {result1.OrderId}");
    Console.WriteLine($"   Tracking: {result1.TrackingNumber}");
}

// Create e-commerce service with MongoDB and PayPal
Console.WriteLine("\n\nConfiguration 2: MongoDB + PayPal Payment");
Console.WriteLine("─────────────────────────────────────────");
Console.WriteLine("(Switching implementations without changing high-level code)");

var ecommerceService2 = ServiceFactory.CreateECommerceService(useMongoDB: true, usePayPal: true);

var result2 = ecommerceService2.PlaceOrder(
    "CUST002", 
    "another@example.com", 
    orderItems, 
    paymentMethod, 
    shippingAddress
);

if (result2.Success)
{
    Console.WriteLine($"\n✅ Order placed successfully with different implementations!");
    Console.WriteLine($"   Order ID: {result2.OrderId}");
    Console.WriteLine($"   Tracking: {result2.TrackingNumber}");
}

// DEMONSTRATION 9: Architecture Benefits
Console.WriteLine("\n\n9. ARCHITECTURAL BENEFITS:");
Console.WriteLine("═══════════════════════════");

Console.WriteLine("\n┌─────────────────────────────────────────────────────────────────────┐");
Console.WriteLine("│                    CLEAN ARCHITECTURE                               │");
Console.WriteLine("├─────────────────────────────────────────────────────────────────────┤");
Console.WriteLine("│                                                                     │");
Console.WriteLine("│  ┌─────────────────────────────────────────────────────────┐      │");
Console.WriteLine("│  │                    Domain Layer                          │      │");
Console.WriteLine("│  │  • Entities                                              │      │");
Console.WriteLine("│  │  • Business Rules                                        │      │");
Console.WriteLine("│  │  • Domain Services                                       │      │");
Console.WriteLine("│  │  • Repository Interfaces ←─────── Depends on abstractions│     │");
Console.WriteLine("│  └─────────────────────────────────────────────────────────┘      │");
Console.WriteLine("│                              ↑                                      │");
Console.WriteLine("│  ┌─────────────────────────────────────────────────────────┐      │");
Console.WriteLine("│  │                Application Layer                         │      │");
Console.WriteLine("│  │  • Use Cases                                             │      │");
Console.WriteLine("│  │  • Application Services                                  │      │");
Console.WriteLine("│  │  • DTOs                                                  │      │");
Console.WriteLine("│  └─────────────────────────────────────────────────────────┘      │");
Console.WriteLine("│                              ↑                                      │");
Console.WriteLine("│  ┌─────────────────────────────────────────────────────────┐      │");
Console.WriteLine("│  │              Infrastructure Layer                        │      │");
Console.WriteLine("│  │  • Database Implementation ─────→ Implements interfaces  │      │");
Console.WriteLine("│  │  • External Services                                     │      │");
Console.WriteLine("│  │  • Framework Dependencies                                │      │");
Console.WriteLine("│  └─────────────────────────────────────────────────────────┘      │");
Console.WriteLine("│                                                                     │");
Console.WriteLine("└─────────────────────────────────────────────────────────────────────┘");

Console.WriteLine("\n\nKEY TAKEAWAYS:");
Console.WriteLine("═══════════════");

Console.WriteLine("┌─────────────────────────────────────────────────────────────────────┐");
Console.WriteLine("│ 1. DEPEND ON ABSTRACTIONS: Use interfaces, not concrete classes    │");
Console.WriteLine("│ 2. INJECT DEPENDENCIES: Don't create them inside classes           │");
Console.WriteLine("│ 3. INVERT CONTROL: Let caller decide implementations               │");
Console.WriteLine("│ 4. SEPARATE CONCERNS: Business logic from infrastructure           │");
Console.WriteLine("│ 5. ENABLE TESTING: Easy to mock dependencies                       │");
Console.WriteLine("│ 6. INCREASE FLEXIBILITY: Swap implementations easily               │");
Console.WriteLine("└─────────────────────────────────────────────────────────────────────┘");

Console.WriteLine("\n╔══════════════════════════════════════════════════════════════════╗");
Console.WriteLine("║   DIP: Depend on abstractions, not concretions! 🔄               ║");
Console.WriteLine("╚══════════════════════════════════════════════════════════════════╝");