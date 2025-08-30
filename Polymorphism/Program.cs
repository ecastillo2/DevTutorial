using Polymorphism;

Console.WriteLine("╔════════════════════════════════════════════════════════════════════════╗");
Console.WriteLine("║                        OOP POLYMORPHISM EXAMPLE                        ║");
Console.WriteLine("╚════════════════════════════════════════════════════════════════════════╝");
Console.WriteLine();

// Display polymorphism concept diagram
Console.WriteLine("POLYMORPHISM CONCEPT DIAGRAM:");
Console.WriteLine("═══════════════════════════════\n");

Console.WriteLine("┌───────────────────────────────────────────────────────────────────┐");
Console.WriteLine("│                         POLYMORPHISM                              │");
Console.WriteLine("│              \"One Interface, Multiple Forms\"                     │");
Console.WriteLine("│                                                                   │");
Console.WriteLine("│  Allows objects of different types to be treated as instances    │");
Console.WriteLine("│  of the same type through inheritance or interfaces              │");
Console.WriteLine("└───────────────────────────────────────────────────────────────────┘");
Console.WriteLine();

Console.WriteLine("TYPES OF POLYMORPHISM:");
Console.WriteLine("══════════════════════\n");

Console.WriteLine("┌─────────────────────────────┐     ┌─────────────────────────────┐");
Console.WriteLine("│   COMPILE-TIME (Static)     │     │   RUNTIME (Dynamic)         │");
Console.WriteLine("├─────────────────────────────┤     ├─────────────────────────────┤");
Console.WriteLine("│ • Method Overloading        │     │ • Method Overriding         │");
Console.WriteLine("│ • Operator Overloading      │     │ • Interface Implementation  │");
Console.WriteLine("│ • Generic Types             │     │ • Abstract Classes          │");
Console.WriteLine("│                             │     │                             │");
Console.WriteLine("│ Resolved at compile time    │     │ Resolved at runtime         │");
Console.WriteLine("└─────────────────────────────┘     └─────────────────────────────┘");
Console.WriteLine();

Console.WriteLine("INHERITANCE-BASED POLYMORPHISM:");
Console.WriteLine("═══════════════════════════════\n");

Console.WriteLine("                    ┌─────────────────┐");
Console.WriteLine("                    │     Animal      │");
Console.WriteLine("                    │   (Base Class)  │");
Console.WriteLine("                    ├─────────────────┤");
Console.WriteLine("                    │ + MakeSound() 🔄│");
Console.WriteLine("                    │ + Move() 🔄     │");
Console.WriteLine("                    │ + Eat() 🔄      │");
Console.WriteLine("                    └────────┬────────┘");
Console.WriteLine("                             │");
Console.WriteLine("          ┌──────────────────┼──────────────────┐");
Console.WriteLine("          │                  │                  │");
Console.WriteLine("     ┌────┴─────┐      ┌────┴─────┐      ┌────┴─────┐");
Console.WriteLine("     │   Dog    │      │   Cat    │      │   Bird   │");
Console.WriteLine("     ├──────────┤      ├──────────┤      ├──────────┤");
Console.WriteLine("     │ Barks    │      │ Meows    │      │ Chirps   │");
Console.WriteLine("     │ Runs     │      │ Prowls   │      │ Flies    │");
Console.WriteLine("     └──────────┘      └──────────┘      └──────────┘");
Console.WriteLine();
Console.WriteLine("🔄 = Virtual method (can be overridden)");
Console.WriteLine();

Console.WriteLine("HOW POLYMORPHISM WORKS:");
Console.WriteLine("═══════════════════════\n");

Console.WriteLine("┌─────────────────────────────────────────────────────────────────┐");
Console.WriteLine("│ Animal myPet = new Dog(\"Rex\", 3, \"Labrador\");  // Polymorphism │");
Console.WriteLine("│ myPet.MakeSound();  // Calls Dog's version, not Animal's       │");
Console.WriteLine("│                                                                 │");
Console.WriteLine("│ Runtime Process:                                                │");
Console.WriteLine("│ 1. Check actual object type (Dog)                             │");
Console.WriteLine("│ 2. Look for overridden method in Dog class                    │");
Console.WriteLine("│ 3. Execute Dog.MakeSound() → \"Woof! Woof!\"                    │");
Console.WriteLine("└─────────────────────────────────────────────────────────────────┘");
Console.WriteLine();

Console.WriteLine("\n══════════════════════════════════════════════════════════════════");
Console.WriteLine("                    POLYMORPHISM IN ACTION");
Console.WriteLine("══════════════════════════════════════════════════════════════════\n");

// DEMONSTRATION 1: Basic Polymorphism with Animals
Console.WriteLine("1. BASIC POLYMORPHISM - Same Reference Type, Different Behaviors:");
Console.WriteLine("──────────────────────────────────────────────────────────────────");

// Create different animals but store them as Animal type
Animal dog = new Dog("Rex", 3, "Labrador");
Animal cat = new Cat("Whiskers", 2, true);
Animal bird = new Bird("Tweety", 1, true, 0.5);

// Call the same method on each - different results!
Console.WriteLine("Calling MakeSound() on different animals:");
dog.MakeSound();    // Barks
cat.MakeSound();    // Meows
bird.MakeSound();   // Chirps

Console.WriteLine("\nCalling Move() on different animals:");
dog.Move();         // Runs on four legs
cat.Move();         // Prowls silently
bird.Move();        // Soars through sky

// DEMONSTRATION 2: Polymorphic Collections
Console.WriteLine("\n\n2. POLYMORPHIC COLLECTIONS - Different Types in Same List:");
Console.WriteLine("─────────────────────────────────────────────────────────────");

List<Animal> zoo = new List<Animal>
{
    new Dog("Buddy", 5, "Golden Retriever"),
    new Cat("Luna", 3, false),
    new Bird("Polly", 2, true, 0.8),
    new Dog("Max", 4, "Beagle"),
    new Bird("Penguin", 7, false, 0.6)  // Can't fly!
};

Console.WriteLine("Iterating through zoo animals:");
foreach (Animal animal in zoo)
{
    Console.WriteLine($"\n{animal.GetInfo()}");
    animal.MakeSound();
    animal.Move();
}

// DEMONSTRATION 3: Method Overloading (Compile-Time Polymorphism)
Console.WriteLine("\n\n3. METHOD OVERLOADING - Compile-Time Polymorphism:");
Console.WriteLine("───────────────────────────────────────────────────");

var rex = new Dog("Rex", 3, "Labrador");
rex.Feed();                          // No parameters
rex.Feed("dog food");                // One parameter
rex.Feed("premium kibble", 2);       // Two parameters

// DEMONSTRATION 4: Late Binding and Type Checking
Console.WriteLine("\n\n4. RUNTIME TYPE CHECKING AND CASTING:");
Console.WriteLine("──────────────────────────────────────────────────");

foreach (Animal animal in zoo)
{
    Console.WriteLine($"\nProcessing {animal.Name}:");
    
    // Check actual type at runtime
    if (animal is Dog dogInstance)
    {
        Console.WriteLine("  This is a dog!");
        dogInstance.Fetch("ball");  // Dog-specific method
    }
    else if (animal is Cat catInstance)
    {
        Console.WriteLine("  This is a cat!");
        catInstance.Purr();  // Cat-specific method
    }
    else if (animal is Bird birdInstance)
    {
        Console.WriteLine("  This is a bird!");
        birdInstance.Fly(100);  // Bird-specific method
    }
}

// DEMONSTRATION 5: Interface Polymorphism
Console.WriteLine("\n\n5. INTERFACE POLYMORPHISM - Multiple Inheritance:");
Console.WriteLine("──────────────────────────────────────────────────");

// Create objects that implement interfaces
IPlayable playfulDog = new PlayfulDog("Fido", 2, "Poodle");
IPlayable robotDog = new RobotDog("AIBO-2000");

// Treat both as IPlayable, even though they're unrelated classes!
List<IPlayable> playableThings = new List<IPlayable> { playfulDog, robotDog };

foreach (IPlayable playable in playableThings)
{
    Console.WriteLine($"\nPlaying with {playable.GetType().Name}:");
    playable.Play();
    Console.WriteLine($"Status: {playable.GetPlayStatus()}");
    playable.StopPlaying();
}

// DEMONSTRATION 6: Multiple Interface Implementation
Console.WriteLine("\n\n6. MULTIPLE INTERFACES - Same Object, Different Views:");
Console.WriteLine("──────────────────────────────────────────────────────────");

var smartDog = new PlayfulDog("Einstein", 4, "Border Collie");

// Treat as Animal
Animal animalView = smartDog;
animalView.MakeSound();

// Treat as IPlayable
IPlayable playableView = smartDog;
playableView.Play();

// Treat as ITrainable
ITrainable trainableView = smartDog;
trainableView.Train("roll over");
trainableView.PerformTrick();

// DEMONSTRATION 7: Employee Polymorphism (Business Example)
Console.WriteLine("\n\n7. EMPLOYEE POLYMORPHISM - Real-World Application:");
Console.WriteLine("───────────────────────────────────────────────────────");

// Create different employee types
Employee emp1 = new SalariedEmployee("E001", "John Smith", "IT", 75000);
Employee emp2 = new HourlyEmployee("E002", "Jane Doe", "Support", 25);
Employee emp3 = new CommissionEmployee("E003", "Bob Johnson", "Sales", 30000, 0.05m);
Manager manager = new Manager("E004", "Alice Brown", "IT", 95000);

// Set up some data
(emp2 as HourlyEmployee)?.LogHours(175);
(emp3 as CommissionEmployee)?.RecordSale(50000);
(emp3 as CommissionEmployee)?.RecordSale(75000);

// Add team members to manager
manager.AddTeamMember(emp1);
manager.AddTeamMember(emp2);

// Polymorphic payroll processing
List<Employee> employees = new List<Employee> { emp1, emp2, emp3, manager };

Console.WriteLine("\nPayroll Report (Polymorphic Calculation):");
Console.WriteLine("──────────────────────────────────────────");

decimal totalPayroll = 0;
foreach (Employee emp in employees)
{
    Console.WriteLine($"\n{emp.Name}:");
    Console.WriteLine($"  Type: {emp.GetEmployeeType()}");
    Console.WriteLine($"  Monthly Salary: ${emp.CalculateSalary():F2}");
    Console.WriteLine($"  Bonus: ${emp.CalculateBonus():F2}");
    totalPayroll += emp.CalculateSalary() + emp.CalculateBonus();
}

Console.WriteLine($"\nTotal Monthly Payroll: ${totalPayroll:F2}");
Console.WriteLine($"Manager's Team Cost: ${manager.CalculateTeamCost():F2}");

// DEMONSTRATION 8: Benefits of Polymorphism
Console.WriteLine("\n\n8. POLYMORPHISM BENEFITS VISUALIZATION:");
Console.WriteLine("════════════════════════════════════════");

Console.WriteLine("\n┌────────────────────────────────────────────────────────────┐");
Console.WriteLine("│                WITHOUT POLYMORPHISM                        │");
Console.WriteLine("├────────────────────────────────────────────────────────────┤");
Console.WriteLine("│ if (animal.Type == \"Dog\")                                 │");
Console.WriteLine("│     DogSound();                                            │");
Console.WriteLine("│ else if (animal.Type == \"Cat\")                            │");
Console.WriteLine("│     CatSound();                                            │");
Console.WriteLine("│ else if (animal.Type == \"Bird\")                           │");
Console.WriteLine("│     BirdSound();                                           │");
Console.WriteLine("│ // Need to modify code for each new animal! 😢            │");
Console.WriteLine("└────────────────────────────────────────────────────────────┘");
Console.WriteLine();
Console.WriteLine("                         🔽 VS 🔽");
Console.WriteLine();
Console.WriteLine("┌────────────────────────────────────────────────────────────┐");
Console.WriteLine("│                 WITH POLYMORPHISM                          │");
Console.WriteLine("├────────────────────────────────────────────────────────────┤");
Console.WriteLine("│ animal.MakeSound();  // That's it! ✨                     │");
Console.WriteLine("│                                                            │");
Console.WriteLine("│ // Works for any animal type                              │");
Console.WriteLine("│ // No code changes needed for new animals                 │");
Console.WriteLine("│ // Each animal knows its own sound                        │");
Console.WriteLine("└────────────────────────────────────────────────────────────┘");

Console.WriteLine("\n\nKEY POLYMORPHISM PRINCIPLES:");
Console.WriteLine("══════════════════════════════");

Console.WriteLine("┌─────────────────────────────────────────────────────────────────────┐");
Console.WriteLine("│ 1. SUBSTITUTABILITY: Derived objects can replace base objects      │");
Console.WriteLine("│ 2. INTERFACE UNIFORMITY: Same method calls, different behaviors    │");
Console.WriteLine("│ 3. EXTENSIBILITY: Add new types without changing existing code     │");
Console.WriteLine("│ 4. RUNTIME FLEXIBILITY: Behavior determined at execution time      │");
Console.WriteLine("│ 5. CODE REUSABILITY: Write once, use with many types              │");
Console.WriteLine("└─────────────────────────────────────────────────────────────────────┘");

Console.WriteLine("\n╔══════════════════════════════════════════════════════════════════╗");
Console.WriteLine("║        POLYMORPHISM: Write Once, Run with Many Forms! 🎭        ║");
Console.WriteLine("╚══════════════════════════════════════════════════════════════════╝");