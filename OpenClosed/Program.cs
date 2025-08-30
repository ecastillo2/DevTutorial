using OpenClosed.BadExamples;
using OpenClosed.GoodExamples;
using OpenClosed.PracticalExample;

Console.WriteLine("╔════════════════════════════════════════════════════════════════════════╗");
Console.WriteLine("║                 OPEN/CLOSED PRINCIPLE (OCP)                            ║");
Console.WriteLine("║                    S.O.L.I.D Principles - Part 2                      ║");
Console.WriteLine("╚════════════════════════════════════════════════════════════════════════╝");
Console.WriteLine();

// Display OCP concept
Console.WriteLine("OPEN/CLOSED PRINCIPLE:");
Console.WriteLine("══════════════════════\n");

Console.WriteLine("┌─────────────────────────────────────────────────────────────────────┐");
Console.WriteLine("│                                                                     │");
Console.WriteLine("│  \"Software entities should be OPEN for extension,                  │");
Console.WriteLine("│   but CLOSED for modification\"                                     │");
Console.WriteLine("│                                    - Bertrand Meyer                 │");
Console.WriteLine("│                                                                     │");
Console.WriteLine("│  In other words:                                                    │");
Console.WriteLine("│  • You should be able to ADD new functionality                     │");
Console.WriteLine("│  • WITHOUT changing existing code                                  │");
Console.WriteLine("│  • Achieve this through abstraction and polymorphism               │");
Console.WriteLine("│                                                                     │");
Console.WriteLine("└─────────────────────────────────────────────────────────────────────┘");
Console.WriteLine();

Console.WriteLine("WHY OCP MATTERS:");
Console.WriteLine("════════════════\n");

Console.WriteLine("┌────────────────────────────────┐     ┌────────────────────────────────┐");
Console.WriteLine("│      WITHOUT OCP (Bad)         │     │       WITH OCP (Good)          │");
Console.WriteLine("├────────────────────────────────┤     ├────────────────────────────────┤");
Console.WriteLine("│ • Modify existing code often   │     │ • Extend via new classes       │");
Console.WriteLine("│ • Risk breaking functionality  │     │ • Existing code untouched      │");
Console.WriteLine("│ • Regression bugs              │     │ • No regression risk           │");
Console.WriteLine("│ • Growing if/switch statements │     │ • Clean polymorphic code       │");
Console.WriteLine("│ • Hard to test changes         │     │ • Easy to test new features    │");
Console.WriteLine("│ • Violates DRY principle       │     │ • Promotes code reuse          │");
Console.WriteLine("└────────────────────────────────┘     └────────────────────────────────┘");
Console.WriteLine();

Console.WriteLine("OCP VIOLATION PATTERN:");
Console.WriteLine("══════════════════════\n");

Console.WriteLine("┌─────────────────────────────────────┐");
Console.WriteLine("│        AreaCalculator (Bad)         │");
Console.WriteLine("├─────────────────────────────────────┤");
Console.WriteLine("│ if (shape is Rectangle)             │");
Console.WriteLine("│     return width * height;          │");
Console.WriteLine("│ else if (shape is Circle)           │");
Console.WriteLine("│     return PI * radius * radius;    │");
Console.WriteLine("│ else if (shape is Triangle)         │");
Console.WriteLine("│     return base * height / 2;       │");
Console.WriteLine("│ // ADD MORE IF-ELSE FOR NEW SHAPES! │");
Console.WriteLine("│                                     │");
Console.WriteLine("│ ❌ Must modify for each new shape   │");
Console.WriteLine("└─────────────────────────────────────┘");
Console.WriteLine();

Console.WriteLine("OCP COMPLIANT DESIGN:");
Console.WriteLine("═════════════════════\n");

Console.WriteLine("                    ┌─────────────────┐");
Console.WriteLine("                    │ Abstract Shape  │");
Console.WriteLine("                    │ + CalculateArea()│");
Console.WriteLine("                    └────────┬────────┘");
Console.WriteLine("                             │");
Console.WriteLine("          ┌──────────────────┼──────────────────┐");
Console.WriteLine("          │                  │                  │");
Console.WriteLine("    ┌─────┴─────┐      ┌────┴─────┐      ┌────┴─────┐");
Console.WriteLine("    │ Rectangle │      │  Circle  │      │ Triangle │");
Console.WriteLine("    └───────────┘      └──────────┘      └──────────┘");
Console.WriteLine();
Console.WriteLine("    ✅ Add new shapes WITHOUT modifying existing code!");
Console.WriteLine();

Console.WriteLine("\n══════════════════════════════════════════════════════════════════");
Console.WriteLine("                    OCP IN ACTION - EXAMPLES");
Console.WriteLine("══════════════════════════════════════════════════════════════════\n");

// DEMONSTRATION 1: Bad Example - Area Calculator
Console.WriteLine("1. BAD EXAMPLE - Area Calculator with Type Checking:");
Console.WriteLine("────────────────────────────────────────────────────");

var badCalculator = new AreaCalculator_Bad();

// Calculate areas using bad approach
var rect = new Rectangle_Bad { Width = 10, Height = 5 };
var circle = new Circle_Bad { Radius = 7 };
var triangle = new Triangle_Bad { SideA = 3, SideB = 4, SideC = 5 };

Console.WriteLine($"Rectangle area: {badCalculator.CalculateArea(rect)}");
Console.WriteLine($"Circle area: {badCalculator.CalculateArea(circle):F2}");
Console.WriteLine($"Triangle area: {badCalculator.CalculateArea(triangle):F2}");

Console.WriteLine("\n❌ PROBLEM: To add a Pentagon, we must MODIFY CalculateArea method!");

// DEMONSTRATION 2: Good Example - Using Polymorphism
Console.WriteLine("\n\n2. GOOD EXAMPLE - Area Calculator with Polymorphism:");
Console.WriteLine("─────────────────────────────────────────────────────");

var goodCalculator = new AreaCalculator();

// Create shapes using good approach
var shapes = new List<Shape>
{
    new Rectangle(10, 5),
    new Circle(7),
    new Triangle(3, 4, 5),
    new Pentagon(5) // NEW SHAPE added without modifying calculator!
};

Console.WriteLine($"Total area: {goodCalculator.CalculateTotalArea(shapes):F2}");
goodCalculator.PrintShapeDetails(shapes);

Console.WriteLine("\n✅ SUCCESS: Added Pentagon WITHOUT modifying AreaCalculator!");

// DEMONSTRATION 3: Bad Payment Processing
Console.WriteLine("\n\n3. BAD EXAMPLE - Payment Processing with Type Checking:");
Console.WriteLine("───────────────────────────────────────────────────────");

var badPaymentProcessor = new PaymentProcessor_Bad();

// Process different payment types (bad way)
badPaymentProcessor.ProcessPayment("CreditCard", 100.00, 
    new CreditCardDetails { CardNumber = "1234567812345678", CVV = "123" });

badPaymentProcessor.ProcessPayment("PayPal", 50.00,
    new PayPalDetails { Email = "user@example.com", Password = "secret" });

Console.WriteLine("\n❌ PROBLEM: To add cryptocurrency payment, must modify ProcessPayment!");

// DEMONSTRATION 4: Good Payment Processing
Console.WriteLine("\n\n4. GOOD EXAMPLE - Payment Processing with Strategy Pattern:");
Console.WriteLine("────────────────────────────────────────────────────────────");

var paymentProcessor = new PaymentProcessor();

// Process payments using good approach
var payments = new List<(IPaymentMethod, decimal)>
{
    (new CreditCardPayment("1234567812345678", "123", "12/25"), 100.00m),
    (new PayPalPayment("user@example.com", "password"), 50.00m),
    (new BankTransferPayment("123456789", "987654321"), 200.00m),
    (new CryptocurrencyPayment("1A2B3C4D5E6F7G8H9I0J", "Bitcoin"), 0.001m) // NEW!
};

paymentProcessor.ProcessMultiplePayments(payments);

Console.WriteLine("✅ SUCCESS: Added Cryptocurrency WITHOUT modifying PaymentProcessor!");

// DEMONSTRATION 5: Discount Calculation
Console.WriteLine("\n\n5. DISCOUNT CALCULATION - Extensible Design:");
Console.WriteLine("─────────────────────────────────────────────");

var discountCalculator = new DiscountCalculator();
var purchaseAmount = 1000m;

// Apply multiple discount strategies
var discounts = new List<IDiscountStrategy>
{
    new GoldCustomerDiscount(),
    new SeasonalDiscount("Black Friday", 0.15m), // Can add new discounts!
    new VIPCustomerDiscount() // NEW discount type without modification!
};

var finalPrice = discountCalculator.CalculateFinalPrice(purchaseAmount, discounts);
Console.WriteLine($"\nOriginal Price: ${purchaseAmount:F2}");
Console.WriteLine($"Final Price: ${finalPrice:F2}");

// DEMONSTRATION 6: Report Generation
Console.WriteLine("\n\n6. REPORT GENERATION - Multiple Formats:");
Console.WriteLine("─────────────────────────────────────────");

var reportService = new ReportService();
var salesData = new List<OpenClosed.GoodExamples.SalesData>
{
    new() { Product = "Laptop", Amount = 999.99m, Date = DateTime.Now.AddDays(-5) },
    new() { Product = "Mouse", Amount = 29.99m, Date = DateTime.Now.AddDays(-3) },
    new() { Product = "Keyboard", Amount = 79.99m, Date = DateTime.Now.AddDays(-1) }
};

// Generate reports in multiple formats
var generators = new List<IReportGenerator>
{
    new PDFReportGenerator(),
    new ExcelReportGenerator(),
    new JSONReportGenerator() // NEW format without modification!
};

reportService.GenerateMultipleReports(generators, salesData);

// DEMONSTRATION 7: Practical E-Commerce Example
Console.WriteLine("\n\n7. PRACTICAL EXAMPLE - E-Commerce System:");
Console.WriteLine("══════════════════════════════════════════");

// Setup pricing engine with multiple rules
var pricingEngine = new PricingEngine();
pricingEngine.AddRule(new StandardPricingRule());
pricingEngine.AddRule(new BulkDiscountPricingRule(10, 0.15m));
pricingEngine.AddRule(new BuyXGetYFreeRule(3, 1));
pricingEngine.AddRule(new WeekendSpecialRule(0.10m)); // NEW rule!

// Create product and calculate prices
var laptop = new Product 
{ 
    Id = "LAPTOP001", 
    Name = "Gaming Laptop", 
    BasePrice = 999.99m, 
    Weight = 2.5m 
};

// Show how different quantities get different prices
Console.WriteLine("\nPricing for Gaming Laptop:");
foreach (var qty in new[] { 1, 5, 10, 12 })
{
    var price = pricingEngine.CalculateBestPrice(laptop, qty);
    Console.WriteLine($"  Quantity {qty}: ${price:F2} (${price/qty:F2} each)");
}

// Order processing with extensible validation
var orderProcessor = new OrderProcessor(pricingEngine);

// Add validation rules
var inventory = new SimpleInventoryService();
inventory.AddStock("LAPTOP001", 20);
orderProcessor.AddValidationRule(new MinimumOrderAmountRule(50m));
orderProcessor.AddValidationRule(new StockAvailabilityRule(inventory));

// Add tax calculators
orderProcessor.AddTaxCalculator(new USSalesTaxCalculator("CA"));
orderProcessor.AddTaxCalculator(new DigitalServicesTaxCalculator()); // NEW tax!

// Create and process order
var order = new Order
{
    OrderId = "ORD001",
    ShippingDistance = 100,
    Items = new List<OrderItem>
    {
        new() { Product = laptop, Quantity = 4 }
    }
};

// Try different shipping methods
var shippingMethods = new List<IShippingMethod>
{
    new StandardShipping(),
    new ExpressShipping(),
    new DroneDelivery() // NEW shipping method!
};

Console.WriteLine("\n\nShipping Options:");
foreach (var shipping in shippingMethods)
{
    var cost = shipping.CalculateShippingCost(
        order.GetTotalWeight(), 
        order.ShippingDistance
    );
    
    if (cost < decimal.MaxValue)
    {
        Console.WriteLine($"  {shipping.GetShippingName()}: ${cost:F2}");
    }
    else
    {
        Console.WriteLine($"  {shipping.GetShippingName()}: Not available");
    }
}

// Process order with selected shipping
var result = orderProcessor.ProcessOrder(order, new ExpressShipping());

// DEMONSTRATION 8: Design Patterns Supporting OCP
Console.WriteLine("\n\n8. DESIGN PATTERNS THAT SUPPORT OCP:");
Console.WriteLine("════════════════════════════════════");

Console.WriteLine("\n┌─────────────────────────────────────────────────────────────────────┐");
Console.WriteLine("│ STRATEGY PATTERN:                                                   │");
Console.WriteLine("│ • Define family of algorithms                                       │");
Console.WriteLine("│ • Make them interchangeable                                         │");
Console.WriteLine("│ • Example: Payment methods, Discount strategies                     │");
Console.WriteLine("├─────────────────────────────────────────────────────────────────────┤");
Console.WriteLine("│ TEMPLATE METHOD PATTERN:                                            │");
Console.WriteLine("│ • Define skeleton of algorithm                                      │");
Console.WriteLine("│ • Subclasses override specific steps                               │");
Console.WriteLine("│ • Example: Report generators                                        │");
Console.WriteLine("├─────────────────────────────────────────────────────────────────────┤");
Console.WriteLine("│ DECORATOR PATTERN:                                                  │");
Console.WriteLine("│ • Add new functionality to objects                                  │");
Console.WriteLine("│ • Without altering structure                                        │");
Console.WriteLine("│ • Example: Adding features to notifications                         │");
Console.WriteLine("├─────────────────────────────────────────────────────────────────────┤");
Console.WriteLine("│ FACTORY METHOD PATTERN:                                             │");
Console.WriteLine("│ • Define interface for creating objects                             │");
Console.WriteLine("│ • Let subclasses decide which class to instantiate                 │");
Console.WriteLine("│ • Example: Creating different shape types                           │");
Console.WriteLine("└─────────────────────────────────────────────────────────────────────┘");

// DEMONSTRATION 9: Benefits Summary
Console.WriteLine("\n\n9. BENEFITS OF FOLLOWING OCP:");
Console.WriteLine("══════════════════════════════");

Console.WriteLine("\n┌────────────────────────────────────────────────────────────┐");
Console.WriteLine("│              MAINTENANCE SCENARIO                          │");
Console.WriteLine("├────────────────────────────────────────────────────────────┤");
Console.WriteLine("│ Requirement: Add support for Apple Pay                    │");
Console.WriteLine("│                                                            │");
Console.WriteLine("│ Without OCP:                                               │");
Console.WriteLine("│ • Modify PaymentProcessor class                           │");
Console.WriteLine("│ • Update all switch/if statements                         │");
Console.WriteLine("│ • Risk breaking existing payment methods                  │");
Console.WriteLine("│ • Need to retest everything                               │");
Console.WriteLine("│                                                            │");
Console.WriteLine("│ With OCP:                                                  │");
Console.WriteLine("│ • Create new ApplePayPayment class                        │");
Console.WriteLine("│ • Implement IPaymentMethod interface                      │");
Console.WriteLine("│ • No changes to existing code                             │");
Console.WriteLine("│ • Only test new payment method                            │");
Console.WriteLine("└────────────────────────────────────────────────────────────┘");

Console.WriteLine("\n\nKEY TAKEAWAYS:");
Console.WriteLine("═══════════════");

Console.WriteLine("┌─────────────────────────────────────────────────────────────────────┐");
Console.WriteLine("│ 1. USE ABSTRACTIONS: Interfaces and abstract classes               │");
Console.WriteLine("│ 2. DEPEND ON ABSTRACTIONS: Not concrete implementations            │");
Console.WriteLine("│ 3. POLYMORPHISM: Let objects decide their behavior                 │");
Console.WriteLine("│ 4. COMPOSITION: Favor composition over inheritance                  │");
Console.WriteLine("│ 5. DESIGN PATTERNS: Use patterns that promote OCP                  │");
Console.WriteLine("│ 6. PLUGIN ARCHITECTURE: Design systems to accept plugins           │");
Console.WriteLine("└─────────────────────────────────────────────────────────────────────┘");

Console.WriteLine("\n╔══════════════════════════════════════════════════════════════════╗");
Console.WriteLine("║   OCP: Extend, Don't Modify! 🔧➡️🔨                              ║");
Console.WriteLine("╚══════════════════════════════════════════════════════════════════╝");