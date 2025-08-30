using LiskovSubstitution.BadExamples;
using LiskovSubstitution.GoodExamples;
using LiskovSubstitution.PracticalExample;

Console.WriteLine("╔════════════════════════════════════════════════════════════════════════╗");
Console.WriteLine("║           LISKOV SUBSTITUTION PRINCIPLE (LSP)                          ║");
Console.WriteLine("║                    S.O.L.I.D Principles - Part 3                      ║");
Console.WriteLine("╚════════════════════════════════════════════════════════════════════════╝");
Console.WriteLine();

// Display LSP concept
Console.WriteLine("LISKOV SUBSTITUTION PRINCIPLE:");
Console.WriteLine("══════════════════════════════\n");

Console.WriteLine("┌─────────────────────────────────────────────────────────────────────┐");
Console.WriteLine("│                                                                     │");
Console.WriteLine("│  \"Objects of a superclass should be replaceable with objects       │");
Console.WriteLine("│   of its subclasses without breaking the application\"              │");
Console.WriteLine("│                                    - Barbara Liskov                 │");
Console.WriteLine("│                                                                     │");
Console.WriteLine("│  In other words:                                                    │");
Console.WriteLine("│  • Derived classes must be substitutable for their base classes    │");
Console.WriteLine("│  • Child should not break parent's behavior                        │");
Console.WriteLine("│  • Inheritance should represent \"IS-A\" relationship correctly      │");
Console.WriteLine("│                                                                     │");
Console.WriteLine("└─────────────────────────────────────────────────────────────────────┘");
Console.WriteLine();

Console.WriteLine("WHY LSP MATTERS:");
Console.WriteLine("════════════════\n");

Console.WriteLine("┌────────────────────────────────┐     ┌────────────────────────────────┐");
Console.WriteLine("│      WITHOUT LSP (Bad)         │     │       WITH LSP (Good)          │");
Console.WriteLine("├────────────────────────────────┤     ├────────────────────────────────┤");
Console.WriteLine("│ • Unexpected exceptions        │     │ • Predictable behavior         │");
Console.WriteLine("│ • Type checking everywhere     │     │ • No type checking needed      │");
Console.WriteLine("│ • Fragile code                 │     │ • Robust polymorphism          │");
Console.WriteLine("│ • Violated contracts           │     │ • Honored contracts            │");
Console.WriteLine("│ • Surprising behavior          │     │ • Expected behavior            │");
Console.WriteLine("│ • Complex error handling       │     │ • Simple error handling        │");
Console.WriteLine("└────────────────────────────────┘     └────────────────────────────────┘");
Console.WriteLine();

Console.WriteLine("CLASSIC LSP VIOLATION - Rectangle/Square:");
Console.WriteLine("═════════════════════════════════════════\n");

Console.WriteLine("┌─────────────────────────────────────┐");
Console.WriteLine("│           Rectangle                 │");
Console.WriteLine("│  Width: 5, Height: 10              │");
Console.WriteLine("│  Area = Width × Height = 50        │");
Console.WriteLine("└─────────────────────────────────────┘");
Console.WriteLine("                ↑");
Console.WriteLine("         Inheritance");
Console.WriteLine("                │");
Console.WriteLine("┌─────────────────────────────────────┐");
Console.WriteLine("│            Square                   │");
Console.WriteLine("│  Set Width = 5                      │");
Console.WriteLine("│  ❌ Height ALSO becomes 5!         │");
Console.WriteLine("│  Breaks Rectangle's behavior!       │");
Console.WriteLine("└─────────────────────────────────────┘");
Console.WriteLine();

Console.WriteLine("LSP VIOLATION PATTERNS:");
Console.WriteLine("═══════════════════════\n");

Console.WriteLine("1. THROWING EXCEPTIONS IN OVERRIDES:");
Console.WriteLine("   ┌────────────────────────────┐");
Console.WriteLine("   │ Bird.Fly() → works fine   │");
Console.WriteLine("   │ Penguin.Fly() → throws!   │");
Console.WriteLine("   └────────────────────────────┘");
Console.WriteLine();

Console.WriteLine("2. CHANGING EXPECTED BEHAVIOR:");
Console.WriteLine("   ┌────────────────────────────┐");
Console.WriteLine("   │ Account.Withdraw() → money │");
Console.WriteLine("   │ LoanAccount.Withdraw() →   │");
Console.WriteLine("   │   increases debt!          │");
Console.WriteLine("   └────────────────────────────┘");
Console.WriteLine();

Console.WriteLine("3. STRENGTHENING PRECONDITIONS:");
Console.WriteLine("   ┌────────────────────────────┐");
Console.WriteLine("   │ Employee.Work(50) → OK     │");
Console.WriteLine("   │ Contractor.Work(50) →      │");
Console.WriteLine("   │   Error: Max 40 hours!     │");
Console.WriteLine("   └────────────────────────────┘");
Console.WriteLine();

Console.WriteLine("CORRECT DESIGN PATTERNS:");
Console.WriteLine("═════════════════════════\n");

Console.WriteLine("                    ┌─────────────────┐");
Console.WriteLine("                    │     IShape      │");
Console.WriteLine("                    └────────┬────────┘");
Console.WriteLine("                             │");
Console.WriteLine("          ┌──────────────────┼──────────────────┐");
Console.WriteLine("          │                  │                  │");
Console.WriteLine("    ┌─────┴─────┐      ┌────┴─────┐      ┌────┴─────┐");
Console.WriteLine("    │ Rectangle │      │  Square  │      │  Circle  │");
Console.WriteLine("    └───────────┘      └──────────┘      └──────────┘");
Console.WriteLine("    Independent types - no inheritance issues!");
Console.WriteLine();

Console.WriteLine("\n══════════════════════════════════════════════════════════════════");
Console.WriteLine("                    LSP IN ACTION - EXAMPLES");
Console.WriteLine("══════════════════════════════════════════════════════════════════\n");

// DEMONSTRATION 1: Bad Rectangle/Square
Console.WriteLine("1. BAD EXAMPLE - Rectangle/Square Violation:");
Console.WriteLine("────────────────────────────────────────────");

// Test Rectangle behavior
var rect = new Rectangle_Bad { Width = 5, Height = 10 };
Console.WriteLine($"Rectangle: Width={rect.Width}, Height={rect.Height}, Area={rect.CalculateArea()}");

// Test Square behavior - violates LSP!
var square = new Square_Bad { Width = 5 };
Console.WriteLine($"Square after setting Width=5: Width={square.Width}, Height={square.Height}");

// This function expects Rectangle behavior but breaks with Square
TestRectangleBehavior(rect);  // Works fine
TestRectangleBehavior(square); // Breaks!

void TestRectangleBehavior(Rectangle_Bad rectangle)
{
    rectangle.Width = 4;
    rectangle.Height = 5;
    var expectedArea = 20;
    var actualArea = rectangle.CalculateArea();
    
    Console.WriteLine($"Expected area: {expectedArea}, Actual area: {actualArea}");
    if (expectedArea != actualArea)
    {
        Console.WriteLine("❌ LSP VIOLATION: Square changed both dimensions!");
    }
}

// DEMONSTRATION 2: Good Shape Design
Console.WriteLine("\n\n2. GOOD EXAMPLE - Proper Shape Design:");
Console.WriteLine("──────────────────────────────────────");

// Using composition instead of problematic inheritance
var goodRect = new Rectangle(5, 10);
var goodSquare = new Square(5);

Console.WriteLine($"Rectangle: {goodRect.CalculateArea()} area, {goodRect.CalculatePerimeter()} perimeter");
Console.WriteLine($"Square: {goodSquare.CalculateArea()} area, {goodSquare.CalculatePerimeter()} perimeter");

// Both work correctly with IShape interface
CalculateShapeMetrics(goodRect);
CalculateShapeMetrics(goodSquare);

void CalculateShapeMetrics(IShape shape)
{
    Console.WriteLine($"Shape area: {shape.CalculateArea()}, perimeter: {shape.CalculatePerimeter()}");
}

// DEMONSTRATION 3: Bad Bird Hierarchy
Console.WriteLine("\n\n3. BAD EXAMPLE - Bird Hierarchy Violation:");
Console.WriteLine("───────────────────────────────────────────");

var eagle = new Bird_Bad { Name = "Eagle" };
var penguin = new Penguin_Bad { Name = "Penguin" };

// This will work for eagle but throw for penguin
MakeBirdFly(eagle);    // Works
try
{
    MakeBirdFly(penguin); // Throws exception!
}
catch (NotSupportedException ex)
{
    Console.WriteLine($"❌ LSP VIOLATION: {ex.Message}");
}

void MakeBirdFly(Bird_Bad bird)
{
    bird.Fly(); // Assumes all birds can fly - wrong!
}

// DEMONSTRATION 4: Good Bird Design
Console.WriteLine("\n\n4. GOOD EXAMPLE - Proper Bird Design:");
Console.WriteLine("─────────────────────────────────────");

var eagle2 = new Eagle("Eagle");
var penguin2 = new Penguin("Penguin");
var duck = new Duck("Duck");

// Each bird moves in its own way
eagle2.Move();
penguin2.Move();
duck.Move();

// Only flying birds can fly
MakeFlyingBirdSoar(eagle2);
MakeFlyingBirdSoar(duck);
// MakeFlyingBirdSoar(penguin2); // Compile error - penguin doesn't implement IFlyingBird

// Only swimming birds can swim
MakeSwimmingBirdDive(penguin2);
MakeSwimmingBirdDive(duck);

void MakeFlyingBirdSoar(IFlyingBird bird)
{
    bird.Fly();
    Console.WriteLine($"Flight speed: {bird.GetFlightSpeed()} km/h");
}

void MakeSwimmingBirdDive(ISwimmingBird bird)
{
    bird.Swim();
    Console.WriteLine($"Swim speed: {bird.GetSwimSpeed()} km/h");
}

// DEMONSTRATION 5: Bad Storage Example
Console.WriteLine("\n\n5. BAD EXAMPLE - Storage Violation:");
Console.WriteLine("────────────────────────────────────");

var storage = new FileStorage_Bad();
var readOnlyStorage = new ReadOnlyFileStorage_Bad();

// Add files to regular storage
storage.Save("doc1.txt", "Content 1");
storage.Save("doc2.txt", "Content 2");

// Try to use read-only storage the same way
try
{
    ProcessStorage(storage);         // Works
    ProcessStorage(readOnlyStorage); // Throws!
}
catch (InvalidOperationException ex)
{
    Console.WriteLine($"❌ LSP VIOLATION: {ex.Message}");
}

void ProcessStorage(FileStorage_Bad fs)
{
    fs.Save("new.txt", "New content"); // Assumes all storage can save
    Console.WriteLine(fs.Read("new.txt"));
}

// DEMONSTRATION 6: Good Storage Design
Console.WriteLine("\n\n6. GOOD EXAMPLE - Proper Storage Design:");
Console.WriteLine("────────────────────────────────────────");

var fileStorage = new FileStorage();
var readOnlyStorage2 = new ReadOnlyStorage(new Dictionary<string, string> 
{ 
    ["readme.txt"] = "Read-only content" 
});
var cacheStorage = new CacheStorage(TimeSpan.FromMinutes(5));

// Write operations only on writable storage
WriteToStorage(fileStorage, "file1.txt", "Content 1");
WriteToStorage(cacheStorage, "cache1", "Cached data");
// WriteToStorage(readOnlyStorage2, "x", "y"); // Compile error!

// Read operations work on all storage types
ReadFromStorage(fileStorage, "file1.txt");
ReadFromStorage(readOnlyStorage2, "readme.txt");
ReadFromStorage(cacheStorage, "cache1");

void WriteToStorage(IWritableStorage storage, string key, string content)
{
    storage.Write(key, content);
}

void ReadFromStorage(IReadableStorage storage, string key)
{
    if (storage.Exists(key))
    {
        Console.WriteLine($"Read: {storage.Read(key)}");
    }
}

// DEMONSTRATION 7: Bad Employee Hierarchy
Console.WriteLine("\n\n7. BAD EXAMPLE - Employee Hierarchy Violation:");
Console.WriteLine("───────────────────────────────────────────────");

var regular = new RegularEmployee_Bad { Name = "John", BaseSalary = 5000 };
var contractor = new Contractor_Bad { Name = "Jane", BaseSalary = 100 }; // per hour
var volunteer = new Volunteer_Bad { Name = "Bob", BaseSalary = 0 };

// Calculate bonuses - breaks for some employee types
try
{
    Console.WriteLine($"{regular.Name} bonus: ${regular.CalculateBonus()}");
    Console.WriteLine($"{contractor.Name} bonus: ${contractor.CalculateBonus()}"); // Returns 0 - misleading
    Console.WriteLine($"{volunteer.Name} bonus: ${volunteer.CalculateBonus()}"); // Throws!
}
catch (NotSupportedException ex)
{
    Console.WriteLine($"❌ LSP VIOLATION: {ex.Message}");
}

// DEMONSTRATION 8: Good Employee Design
Console.WriteLine("\n\n8. GOOD EXAMPLE - Proper Employee Design:");
Console.WriteLine("──────────────────────────────────────────");

var fullTime = new FullTimeEmployee("Alice", "FT001", 5000, 0.15m);
var contractor2 = new Contractor("Bob", "C001", 50);
var volunteer2 = new Volunteer("Carol", "V001");

// Each employee type has appropriate interfaces
ProcessSalariedEmployee(fullTime);
ProcessHourlyEmployee(contractor2);
ProcessVolunteer(volunteer2);

void ProcessSalariedEmployee(ISalariedEmployee employee)
{
    Console.WriteLine($"Monthly salary: ${employee.GetMonthlySalary()}");
    
    if (employee is IBonusEligible bonusEligible)
    {
        Console.WriteLine($"Bonus: ${bonusEligible.CalculateBonus()}");
    }
}

void ProcessHourlyEmployee(IHourlyEmployee employee)
{
    var pay = employee.CalculatePay(45); // 45 hours
    Console.WriteLine($"Pay for 45 hours: ${pay}");
}

void ProcessVolunteer(Volunteer volunteer)
{
    volunteer.PerformDuties();
    Console.WriteLine("Thank you for volunteering!");
}

// DEMONSTRATION 9: Practical CMS Example
Console.WriteLine("\n\n9. PRACTICAL EXAMPLE - Content Management System:");
Console.WriteLine("══════════════════════════════════════════════════");

// Create content repository
var repository = new ContentRepository();

// Add different types of content
var blogPost = new BlogPost("blog1", "LSP in Practice", "Understanding LSP...");
var newsArticle = new NewsArticle("news1", "Breaking: LSP Explained", "Tech Reporter", "Today we learned...");
var staticPage = new StaticPage("page1", "About Us", "about", "We are a company...");
var announcement = new Announcement("ann1", "Site Maintenance", "Site will be down for maintenance", DateTime.Now.AddDays(7));

repository.Add(blogPost);
repository.Add(newsArticle);
repository.Add(staticPage);
repository.Add(announcement);

// Services that work with specific interfaces
var publishingService = new PublishingService();
var commentService = new CommentService();
var versionService = new VersionControlService();
var editorService = new EditorService();

// Publishing works for all publishable content
Console.WriteLine("\nPublishing content:");
publishingService.PublishContent(blogPost);
publishingService.PublishContent(newsArticle);
publishingService.PublishContent(announcement);
// publishingService.PublishContent(staticPage); // Compile error - not publishable

// Comments only for commentable content
Console.WriteLine("\nAdding comments:");
commentService.AddComment(blogPost, "Reader1", "Great article!");
commentService.AddComment(newsArticle, "Reader2", "Interesting news");
// commentService.AddComment(staticPage, "x", "y"); // Compile error

// Versioning for versionable content
Console.WriteLine("\nVersion control:");
versionService.CreateCheckpoint(blogPost, "Initial version");
editorService.UpdateContent(blogPost, "LSP Best Practices", "Updated content about LSP...");
versionService.CreateCheckpoint(blogPost, "Added best practices section");

versionService.CreateCheckpoint(staticPage, "Initial page");
editorService.UpdateContent(staticPage, "About Our Company", "Updated about text...");
versionService.CreateCheckpoint(staticPage, "Updated company description");

versionService.ShowVersionHistory(blogPost);

// DEMONSTRATION 10: LSP Benefits
Console.WriteLine("\n\n10. BENEFITS OF FOLLOWING LSP:");
Console.WriteLine("═══════════════════════════════");

Console.WriteLine("\n┌────────────────────────────────────────────────────────────┐");
Console.WriteLine("│              SUBSTITUTION SCENARIO                         │");
Console.WriteLine("├────────────────────────────────────────────────────────────┤");
Console.WriteLine("│ Function: ProcessContent(IPublishableContent content)      │");
Console.WriteLine("│                                                            │");
Console.WriteLine("│ Without LSP:                                               │");
Console.WriteLine("│ • Must check content type                                  │");
Console.WriteLine("│ • Handle special cases                                     │");
Console.WriteLine("│ • Risk of exceptions                                       │");
Console.WriteLine("│ • Complex error handling                                   │");
Console.WriteLine("│                                                            │");
Console.WriteLine("│ With LSP:                                                  │");
Console.WriteLine("│ • Works with any IPublishableContent                      │");
Console.WriteLine("│ • No type checking needed                                  │");
Console.WriteLine("│ • Predictable behavior                                     │");
Console.WriteLine("│ • Simple, clean code                                       │");
Console.WriteLine("└────────────────────────────────────────────────────────────┘");

Console.WriteLine("\n\nKEY TAKEAWAYS:");
Console.WriteLine("═══════════════");

Console.WriteLine("┌─────────────────────────────────────────────────────────────────────┐");
Console.WriteLine("│ 1. SUBSTITUTABILITY: Derived classes must be substitutable         │");
Console.WriteLine("│ 2. NO SURPRISES: Don't change expected behavior                    │");
Console.WriteLine("│ 3. HONOR CONTRACTS: Maintain base class invariants                 │");
Console.WriteLine("│ 4. PREFER COMPOSITION: When inheritance doesn't fit                │");
Console.WriteLine("│ 5. USE INTERFACES: Define capabilities, not just types             │");
Console.WriteLine("│ 6. SEGREGATE INTERFACES: Different capabilities = different interfaces│");
Console.WriteLine("└─────────────────────────────────────────────────────────────────────┘");

Console.WriteLine("\n╔══════════════════════════════════════════════════════════════════╗");
Console.WriteLine("║   LSP: If it looks like a duck and quacks like a duck,          ║");
Console.WriteLine("║         it better behave like a duck! 🦆                         ║");
Console.WriteLine("╚══════════════════════════════════════════════════════════════════╝");