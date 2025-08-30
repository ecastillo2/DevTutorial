using SingleResponsibility.BadExamples;
using SingleResponsibility.GoodExamples;
using SingleResponsibility.PracticalExample;

Console.WriteLine("╔════════════════════════════════════════════════════════════════════════╗");
Console.WriteLine("║              SINGLE RESPONSIBILITY PRINCIPLE (SRP)                     ║");
Console.WriteLine("║                    S.O.L.I.D Principles - Part 1                      ║");
Console.WriteLine("╚════════════════════════════════════════════════════════════════════════╝");
Console.WriteLine();

// Display SRP concept
Console.WriteLine("SINGLE RESPONSIBILITY PRINCIPLE:");
Console.WriteLine("═══════════════════════════════\n");

Console.WriteLine("┌─────────────────────────────────────────────────────────────────────┐");
Console.WriteLine("│                                                                     │");
Console.WriteLine("│  \"A class should have one, and only one, reason to change\"         │");
Console.WriteLine("│                                    - Robert C. Martin               │");
Console.WriteLine("│                                                                     │");
Console.WriteLine("│  In other words:                                                    │");
Console.WriteLine("│  • Each class should have ONE job                                  │");
Console.WriteLine("│  • Each class should have ONE responsibility                       │");
Console.WriteLine("│  • Each class should have ONE reason to change                     │");
Console.WriteLine("│                                                                     │");
Console.WriteLine("└─────────────────────────────────────────────────────────────────────┘");
Console.WriteLine();

Console.WriteLine("WHY SRP MATTERS:");
Console.WriteLine("════════════════\n");

Console.WriteLine("┌────────────────────────────────┐     ┌────────────────────────────────┐");
Console.WriteLine("│      WITHOUT SRP (Bad)         │     │       WITH SRP (Good)          │");
Console.WriteLine("├────────────────────────────────┤     ├────────────────────────────────┤");
Console.WriteLine("│ • Hard to understand           │     │ • Easy to understand           │");
Console.WriteLine("│ • Hard to test                 │     │ • Easy to test                 │");
Console.WriteLine("│ • Hard to maintain             │     │ • Easy to maintain             │");
Console.WriteLine("│ • Changes affect many areas    │     │ • Changes are isolated         │");
Console.WriteLine("│ • High coupling                │     │ • Low coupling                 │");
Console.WriteLine("│ • Code duplication             │     │ • Reusable components          │");
Console.WriteLine("└────────────────────────────────┘     └────────────────────────────────┘");
Console.WriteLine();

Console.WriteLine("VIOLATION EXAMPLE - GOD CLASS:");
Console.WriteLine("══════════════════════════════\n");

Console.WriteLine("┌─────────────────────────────────────┐");
Console.WriteLine("│          Employee (Bad)             │");
Console.WriteLine("├─────────────────────────────────────┤");
Console.WriteLine("│ Responsibilities:                   │");
Console.WriteLine("│ ✗ Manage employee data              │");
Console.WriteLine("│ ✗ Calculate salary                  │");
Console.WriteLine("│ ✗ Save to database                  │");
Console.WriteLine("│ ✗ Send emails                       │");
Console.WriteLine("│ ✗ Generate reports                  │");
Console.WriteLine("│ ✗ Validate data                     │");
Console.WriteLine("│                                     │");
Console.WriteLine("│ TOO MANY RESPONSIBILITIES! 😱       │");
Console.WriteLine("└─────────────────────────────────────┘");
Console.WriteLine();

Console.WriteLine("PROPER DESIGN - SEPARATED CONCERNS:");
Console.WriteLine("═══════════════════════════════════\n");

Console.WriteLine("┌─────────────────┐  ┌─────────────────┐  ┌─────────────────┐");
Console.WriteLine("│    Employee     │  │ SalaryCalculator│  │EmployeeRepo    │");
Console.WriteLine("├─────────────────┤  ├─────────────────┤  ├─────────────────┤");
Console.WriteLine("│ ✓ Employee data │  │ ✓ Calculate pay │  │ ✓ Save/Load     │");
Console.WriteLine("└─────────────────┘  └─────────────────┘  └─────────────────┘");
Console.WriteLine();
Console.WriteLine("┌─────────────────┐  ┌─────────────────┐  ┌─────────────────┐");
Console.WriteLine("│  EmailService   │  │ ReportGenerator │  │ Validator       │");
Console.WriteLine("├─────────────────┤  ├─────────────────┤  ├─────────────────┤");
Console.WriteLine("│ ✓ Send emails   │  │ ✓ Create reports│  │ ✓ Validate data │");
Console.WriteLine("└─────────────────┘  └─────────────────┘  └─────────────────┘");
Console.WriteLine();

Console.WriteLine("\n══════════════════════════════════════════════════════════════════");
Console.WriteLine("                    SRP IN ACTION - EXAMPLES");
Console.WriteLine("══════════════════════════════════════════════════════════════════\n");

// DEMONSTRATION 1: Bad Example - Employee with multiple responsibilities
Console.WriteLine("1. BAD EXAMPLE - Employee Class with Multiple Responsibilities:");
Console.WriteLine("───────────────────────────────────────────────────────────────");

var badEmployee = new Employee_Bad(1, "John Doe", "john@example.com", "IT", 50000);

// All these operations are in the Employee class - BAD!
badEmployee.ValidateEmployeeData();
badEmployee.CalculateSalary();
badEmployee.SaveToDatabase();
badEmployee.SendWelcomeEmail();
var report = badEmployee.GeneratePerformanceReport();

Console.WriteLine("\n❌ PROBLEMS:");
Console.WriteLine("- Employee class does too much");
Console.WriteLine("- Hard to test (needs database, email server, etc.)");
Console.WriteLine("- Changes to any functionality require modifying Employee class");

// DEMONSTRATION 2: Good Example - Separated responsibilities
Console.WriteLine("\n\n2. GOOD EXAMPLE - Separated Responsibilities:");
Console.WriteLine("──────────────────────────────────────────────");

// Each class has ONE job
var employee = new Employee(1, "Jane Smith", "jane@example.com", "Sales", 60000);
var salaryCalculator = new SalaryCalculator();
var repository = new EmployeeRepository();
var emailService = new SingleResponsibility.GoodExamples.EmailService();
var reportGenerator = new EmployeeReportGenerator(salaryCalculator);
var validator = new EmployeeValidator();

// Each operation is handled by the appropriate class
var validationResult = validator.Validate(employee);
if (validationResult.IsValid)
{
    var salary = salaryCalculator.CalculateSalary(employee);
    repository.Save(employee);
    emailService.SendWelcomeEmail(employee);
    var performanceReport = reportGenerator.GeneratePerformanceReport(employee);
    
    Console.WriteLine("\n✅ BENEFITS:");
    Console.WriteLine("- Each class has a single, clear purpose");
    Console.WriteLine("- Easy to test each component separately");
    Console.WriteLine("- Changes are isolated to specific classes");
}

// DEMONSTRATION 3: Bad Order Example
Console.WriteLine("\n\n3. BAD EXAMPLE - Order Class Doing Everything:");
Console.WriteLine("───────────────────────────────────────────────");

var badOrder = new Order_Bad(1001, "customer@example.com");
badOrder.Items.Add(new SingleResponsibility.BadExamples.OrderItem 
{ 
    ProductName = "Laptop", 
    Quantity = 1, 
    Price = 999.99m 
});

// Order class handles all these responsibilities - BAD!
badOrder.CalculateTotalWithTax();
badOrder.CheckAndUpdateInventory();
badOrder.ProcessPayment("1234-5678-9012-3456", 1079.99m);
badOrder.GenerateInvoice();
badOrder.ArrangeShipping("123 Main St");

// DEMONSTRATION 4: Good Order Example
Console.WriteLine("\n\n4. GOOD EXAMPLE - Order with Separated Services:");
Console.WriteLine("─────────────────────────────────────────────────");

// Create order and services
var order = new Order(1002, "customer@example.com");
order.AddItem(new SingleResponsibility.GoodExamples.OrderItem 
{ 
    ProductName = "Tablet", 
    Quantity = 2, 
    Price = 299.99m 
});

var priceCalculator = new PriceCalculator(0.08m); // 8% tax
var inventoryService = new InventoryService();
var paymentProcessor = new PaymentProcessor();
var invoiceGenerator = new InvoiceGenerator(priceCalculator);

// Add inventory for demo
inventoryService.AddStock("Tablet", 10);

// Each service handles its own responsibility
var total = priceCalculator.CalculateTotalWithTax(order);
var available = inventoryService.CheckAvailability(order.Items[0]);
if (available)
{
    var paymentResult = paymentProcessor.ProcessPayment("9876-5432-1098-7654", total);
    if (paymentResult.Success)
    {
        inventoryService.UpdateInventory(order.Items[0]);
        var invoice = invoiceGenerator.GenerateInvoice(order);
        Console.WriteLine(invoiceGenerator.FormatInvoice(invoice));
    }
}

// DEMONSTRATION 5: Practical Blog System Example
Console.WriteLine("\n\n5. PRACTICAL EXAMPLE - Blog System with SRP:");
Console.WriteLine("──────────────────────────────────────────────");

// Create all services (each with single responsibility)
var postRepo = new BlogPostRepository();
var userRepo = new UserRepository();
var passwordHasher = new PasswordHasher();
var authService = new AuthenticationService(userRepo, passwordHasher);
var postValidator = new BlogPostValidator();
var notificationService = new NotificationService(new SingleResponsibility.PracticalExample.EmailService());
var publishingService = new BlogPublishingService(postRepo, postValidator, notificationService);
var statsService = new BlogStatisticsService(postRepo);
var rssGenerator = new RssFeedGenerator(postRepo);

// Register users
authService.Register("alice", "alice@blog.com", "password123");
authService.Register("bob", "bob@blog.com", "password456");

// Subscribe to notifications
notificationService.Subscribe("reader1@example.com");
notificationService.Subscribe("reader2@example.com");

// Create and publish posts
var post1 = new BlogPost
{
    Title = "Understanding SOLID Principles",
    Content = "The SOLID principles are five design principles that help create maintainable software...",
    Author = "alice",
    Tags = new List<string> { "SOLID", "Design Patterns", "Best Practices" }
};

var post2 = new BlogPost
{
    Title = "Single Responsibility Principle Deep Dive",
    Content = "SRP states that a class should have only one reason to change. This means...",
    Author = "bob",
    Tags = new List<string> { "SOLID", "SRP", "Clean Code" }
};

// Publish posts
publishingService.PublishPost(post1);
publishingService.PublishPost(post2);

// Generate statistics
var stats = statsService.GenerateStatistics();
Console.WriteLine($"\nBlog Statistics:");
Console.WriteLine($"Total Posts: {stats.TotalPosts}");
Console.WriteLine($"Total Authors: {stats.TotalAuthors}");
Console.WriteLine($"Average Post Length: {stats.AveragePostLength} characters");

// DEMONSTRATION 6: Testing Benefits
Console.WriteLine("\n\n6. TESTING BENEFITS OF SRP:");
Console.WriteLine("═══════════════════════════");

Console.WriteLine("\n┌────────────────────────────────────────────────────────────┐");
Console.WriteLine("│                    TESTING WITHOUT SRP                     │");
Console.WriteLine("├────────────────────────────────────────────────────────────┤");
Console.WriteLine("│ To test Employee_Bad.CalculateSalary():                   │");
Console.WriteLine("│ ❌ Need database connection                                │");
Console.WriteLine("│ ❌ Need email server                                       │");
Console.WriteLine("│ ❌ Need report generator                                   │");
Console.WriteLine("│ ❌ Complex setup and teardown                              │");
Console.WriteLine("│ ❌ Slow tests                                              │");
Console.WriteLine("└────────────────────────────────────────────────────────────┘");
Console.WriteLine();
Console.WriteLine("┌────────────────────────────────────────────────────────────┐");
Console.WriteLine("│                     TESTING WITH SRP                       │");
Console.WriteLine("├────────────────────────────────────────────────────────────┤");
Console.WriteLine("│ To test SalaryCalculator.CalculateSalary():              │");
Console.WriteLine("│ ✅ Just pass an Employee object                           │");
Console.WriteLine("│ ✅ No external dependencies                                │");
Console.WriteLine("│ ✅ Simple setup                                            │");
Console.WriteLine("│ ✅ Fast tests                                              │");
Console.WriteLine("│ ✅ Easy to test edge cases                                 │");
Console.WriteLine("└────────────────────────────────────────────────────────────┘");

// DEMONSTRATION 7: Maintenance Benefits
Console.WriteLine("\n\n7. MAINTENANCE SCENARIO:");
Console.WriteLine("════════════════════════");

Console.WriteLine("\nScenario: Email provider changes from SMTP to SendGrid API");
Console.WriteLine("\nWithout SRP:");
Console.WriteLine("- Must modify Employee_Bad class");
Console.WriteLine("- Must modify Order_Bad class");
Console.WriteLine("- Must modify UserService_Bad class");
Console.WriteLine("- Risk breaking employee, order, and user functionality");

Console.WriteLine("\nWith SRP:");
Console.WriteLine("- Only modify EmailService class");
Console.WriteLine("- All other classes remain unchanged");
Console.WriteLine("- No risk to other functionality");

Console.WriteLine("\n\nKEY TAKEAWAYS:");
Console.WriteLine("═══════════════");

Console.WriteLine("┌─────────────────────────────────────────────────────────────────────┐");
Console.WriteLine("│ 1. IDENTIFY RESPONSIBILITIES: List what a class does               │");
Console.WriteLine("│ 2. SEPARATE CONCERNS: Each class should do ONE thing               │");
Console.WriteLine("│ 3. HIGH COHESION: Related functionality stays together             │");
Console.WriteLine("│ 4. LOW COUPLING: Classes depend on abstractions, not details       │");
Console.WriteLine("│ 5. TESTABILITY: Easier to test single-purpose classes              │");
Console.WriteLine("│ 6. MAINTAINABILITY: Changes are isolated and predictable           │");
Console.WriteLine("└─────────────────────────────────────────────────────────────────────┘");

Console.WriteLine("\n\nSRP DECISION FLOWCHART:");
Console.WriteLine("═══════════════════════");

Console.WriteLine("┌────────────────────────┐");
Console.WriteLine("│ Does the class have    │");
Console.WriteLine("│ multiple reasons to    │");
Console.WriteLine("│ change?                │");
Console.WriteLine("└───────────┬────────────┘");
Console.WriteLine("            │");
Console.WriteLine("    ┌───────┴───────┐");
Console.WriteLine("    │      YES      │");
Console.WriteLine("    └───────┬───────┘");
Console.WriteLine("            │");
Console.WriteLine("    ┌───────┴───────────┐");
Console.WriteLine("    │ REFACTOR:         │");
Console.WriteLine("    │ Split into        │");
Console.WriteLine("    │ separate classes  │");
Console.WriteLine("    └───────────────────┘");

Console.WriteLine("\n╔══════════════════════════════════════════════════════════════════╗");
Console.WriteLine("║   SRP: Do One Thing and Do It Well! 🎯                          ║");
Console.WriteLine("╚══════════════════════════════════════════════════════════════════╝");