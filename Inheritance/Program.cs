using Inheritance;

Console.WriteLine("╔════════════════════════════════════════════════════════════════════════╗");
Console.WriteLine("║                        OOP INHERITANCE EXAMPLE                         ║");
Console.WriteLine("╚════════════════════════════════════════════════════════════════════════╝");
Console.WriteLine();

// Display inheritance concept diagram
Console.WriteLine("INHERITANCE CONCEPT DIAGRAM:");
Console.WriteLine("═══════════════════════════\n");

Console.WriteLine("┌─────────────────────────────────────────────────────────────────────┐");
Console.WriteLine("│                           INHERITANCE                               │");
Console.WriteLine("│                                                                     │");
Console.WriteLine("│  A mechanism where a new class (derived/child) is based on         │");
Console.WriteLine("│  an existing class (base/parent), inheriting its properties        │");
Console.WriteLine("│  and methods while adding its own unique features.                 │");
Console.WriteLine("│                                                                     │");
Console.WriteLine("│  Establishes an \"IS-A\" relationship:                               │");
Console.WriteLine("│  • Car IS-A Vehicle                                                │");
Console.WriteLine("│  • Student IS-A Person                                             │");
Console.WriteLine("│  • Smartphone IS-A Device                                          │");
Console.WriteLine("└─────────────────────────────────────────────────────────────────────┘");
Console.WriteLine();

Console.WriteLine("TYPES OF INHERITANCE:");
Console.WriteLine("════════════════════\n");

Console.WriteLine("1. SINGLE INHERITANCE (C# supports):");
Console.WriteLine("   ┌─────────┐");
Console.WriteLine("   │ Parent  │");
Console.WriteLine("   └────┬────┘");
Console.WriteLine("        │");
Console.WriteLine("   ┌────┴────┐");
Console.WriteLine("   │  Child  │");
Console.WriteLine("   └─────────┘");
Console.WriteLine();

Console.WriteLine("2. MULTI-LEVEL INHERITANCE (C# supports):");
Console.WriteLine("   ┌─────────┐");
Console.WriteLine("   │ Person  │");
Console.WriteLine("   └────┬────┘");
Console.WriteLine("        │");
Console.WriteLine("   ┌────┴────┐");
Console.WriteLine("   │ Student │");
Console.WriteLine("   └────┬────┘");
Console.WriteLine("        │");
Console.WriteLine("   ┌────┴────────┐");
Console.WriteLine("   │ GradStudent │");
Console.WriteLine("   └─────────────┘");
Console.WriteLine();

Console.WriteLine("3. HIERARCHICAL INHERITANCE (C# supports):");
Console.WriteLine("           ┌─────────┐");
Console.WriteLine("           │ Vehicle │");
Console.WriteLine("           └────┬────┘");
Console.WriteLine("      ┌─────────┼─────────┐");
Console.WriteLine("      │         │         │");
Console.WriteLine("  ┌───┴──┐ ┌───┴──┐ ┌───┴──┐");
Console.WriteLine("  │ Car  │ │ Bike │ │Truck │");
Console.WriteLine("  └──────┘ └──────┘ └──────┘");
Console.WriteLine();

Console.WriteLine("ACCESS MODIFIERS IN INHERITANCE:");
Console.WriteLine("════════════════════════════════\n");

Console.WriteLine("┌────────────────────────────────────────────────────────────────┐");
Console.WriteLine("│ Modifier  │ Same Class │ Derived Class │ Other Classes       │");
Console.WriteLine("├───────────┼────────────┼───────────────┼────────────────────┤");
Console.WriteLine("│ private   │     ✓      │       ✗       │        ✗           │");
Console.WriteLine("│ protected │     ✓      │       ✓       │        ✗           │");
Console.WriteLine("│ public    │     ✓      │       ✓       │        ✓           │");
Console.WriteLine("└────────────────────────────────────────────────────────────────┘");
Console.WriteLine();

Console.WriteLine("CONSTRUCTOR CHAINING:");
Console.WriteLine("════════════════════\n");

Console.WriteLine("When creating a derived object:");
Console.WriteLine("1. Base class constructor runs FIRST");
Console.WriteLine("2. Then derived class constructor runs");
Console.WriteLine("3. This ensures proper initialization");
Console.WriteLine();

Console.WriteLine("┌─────────────────────────────────────┐");
Console.WriteLine("│ new Car() triggers:                 │");
Console.WriteLine("│   1. Vehicle() constructor          │");
Console.WriteLine("│   2. Car() constructor              │");
Console.WriteLine("└─────────────────────────────────────┘");
Console.WriteLine();

Console.WriteLine("\n══════════════════════════════════════════════════════════════════");
Console.WriteLine("                      INHERITANCE IN ACTION");
Console.WriteLine("══════════════════════════════════════════════════════════════════\n");

// DEMONSTRATION 1: Vehicle Inheritance Hierarchy
Console.WriteLine("1. VEHICLE INHERITANCE - Constructor Chaining:");
Console.WriteLine("──────────────────────────────────────────────");

// Create different vehicles - watch constructor output
Car myCar = new Car("Toyota", "Camry", 2024, "Silver", 120, 4, true, "Automatic");
Console.WriteLine();

Motorcycle myBike = new Motorcycle("Harley-Davidson", "Sportster", 2023, "Black", 110, "Cruiser", false);
Console.WriteLine();

Truck myTruck = new Truck("Ford", "F-150", 2024, "Blue", 100, 5000, 2);
Console.WriteLine();

// DEMONSTRATION 2: Inherited Properties and Methods
Console.WriteLine("\n2. USING INHERITED PROPERTIES AND METHODS:");
Console.WriteLine("───────────────────────────────────────────");

// All vehicles can use base class methods
Console.WriteLine("\nStarting all vehicles (inherited method):");
myCar.StartEngine();
myBike.PutUpKickstand();  // Bike-specific requirement
myBike.StartEngine();
myTruck.StartEngine();

// All vehicles have inherited properties
Console.WriteLine($"\nCar info: {myCar.GetInfo()}");
Console.WriteLine($"Bike info: {myBike.GetInfo()}");
Console.WriteLine($"Truck info: {myTruck.GetInfo()}");

// DEMONSTRATION 3: Overridden Methods
Console.WriteLine("\n\n3. METHOD OVERRIDING - Same Method, Different Behavior:");
Console.WriteLine("────────────────────────────────────────────────────────");

Console.WriteLine("\nAccelerating each vehicle:");
myCar.Accelerate(30);
myBike.Accelerate(30);
myTruck.LoadCargo(3000, "construction materials");
myTruck.Accelerate(30);  // Slower due to load

// DEMONSTRATION 4: Derived Class Specific Methods
Console.WriteLine("\n\n4. DERIVED CLASS SPECIFIC FEATURES:");
Console.WriteLine("────────────────────────────────────────────");

// Car-specific methods
Console.WriteLine("\nCar-specific features:");
myCar.OpenTrunk();
myCar.ActivateCruiseControl();

// Motorcycle-specific methods
Console.WriteLine("\nMotorcycle-specific features:");
myBike.LeanIntoTurn(25);
if (myBike is Motorcycle { Type: "Sport" })
{
    myBike.DoWheelie();
}

// Truck-specific methods
Console.WriteLine("\nTruck-specific features:");
myTruck.SecureCargo();
myTruck.AttachTrailer();

// DEMONSTRATION 5: Protected Members Access
Console.WriteLine("\n\n5. PROTECTED MEMBERS - Derived Class Access:");
Console.WriteLine("─────────────────────────────────────────────");

myCar.DisplayCarInfo();      // Uses protected DisplayDashboard()
myBike.DisplayBikeInfo();    // Also uses protected members
myTruck.DisplayTruckInfo();  // Shows inherited protected access

// DEMONSTRATION 6: Person Inheritance Hierarchy
Console.WriteLine("\n\n6. PERSON INHERITANCE - Different Domain:");
Console.WriteLine("───────────────────────────────────────────");

// Create base and derived persons
Person genericPerson = new Person("John", "Doe", new DateTime(1990, 1, 1));
Student student = new Student("Jane", "Smith", new DateTime(2002, 5, 15), "STU001", "Computer Science");
Teacher teacher = new Teacher("Dr. Robert", "Johnson", new DateTime(1975, 8, 20), "TCH001", "Mathematics", 15);

Console.WriteLine("\nIntroductions (virtual method):");
genericPerson.Introduce();
Console.WriteLine();
student.Introduce();
Console.WriteLine();
teacher.Introduce();

// Student-specific operations
Console.WriteLine("\n\nStudent operations:");
student.EnrollInCourse("Data Structures");
student.EnrollInCourse("Algorithms");
student.CompleteCourse("Data Structures", 3.7, 3);

// Teacher-specific operations
Console.WriteLine("\nTeacher operations:");
teacher.AssignCourse("Calculus I");
teacher.AssignCourse("Linear Algebra");
teacher.AddQualification("Ph.D. in Mathematics");
teacher.GradeStudent(student, "Calculus I", 3.8);

// DEMONSTRATION 7: Multi-Level Inheritance
Console.WriteLine("\n\n7. MULTI-LEVEL INHERITANCE - GraduateStudent:");
Console.WriteLine("───────────────────────────────────────────────");

GraduateStudent gradStudent = new GraduateStudent(
    "Alice", "Williams", new DateTime(1998, 3, 10),
    "GRD001", "Physics", "Quantum Computing"
);

gradStudent.IsTeachingAssistant = true;
gradStudent.AdvisorName = "Dr. Johnson";

Console.WriteLine("\nGraduate student introduction:");
gradStudent.Introduce();  // Calls multiple levels of overrides
gradStudent.ConductResearch();

// DEMONSTRATION 8: Device Inheritance with Access Modifiers
Console.WriteLine("\n\n8. DEVICE INHERITANCE - Access Modifier Demo:");
Console.WriteLine("──────────────────────────────────────────────");

Smartphone phone = new Smartphone("Apple", "iPhone 15", "APL123", "iOS", 6.1, 3);
Laptop laptop = new Laptop("Dell", "XPS 15", "DLL456", 15.6, 16, 512, true);
Tablet tablet = new Tablet("Samsung", "Galaxy Tab", "SAM789", "Android", 10.5, true);

Console.WriteLine("\nDevice operations:");
phone.PowerOn();
phone.UnlockScreen();
phone.InstallApp("Instagram");

laptop.OpenLid();  // Auto powers on
laptop.RunProgram("Visual Studio");

tablet.PowerOn();
tablet.DrawWithStylus();

// DEMONSTRATION 9: Type Checking and Casting
Console.WriteLine("\n\n9. TYPE CHECKING AND SAFE CASTING:");
Console.WriteLine("────────────────────────────────────────────");

// Create a list of vehicles (base type)
List<Vehicle> vehicles = new List<Vehicle> { myCar, myBike, myTruck };

foreach (Vehicle vehicle in vehicles)
{
    Console.WriteLine($"\nProcessing {vehicle.GetInfo()}:");
    
    // Type checking with pattern matching
    switch (vehicle)
    {
        case Car car:
            Console.WriteLine("  This is a car - opening trunk");
            car.OpenTrunk();
            break;
        case Motorcycle moto:
            Console.WriteLine("  This is a motorcycle - checking kickstand");
            break;
        case Truck truck:
            Console.WriteLine($"  This is a truck - capacity: {truck.PayloadCapacity} lbs");
            break;
    }
}

// DEMONSTRATION 10: Inheritance Benefits
Console.WriteLine("\n\n10. BENEFITS OF INHERITANCE:");
Console.WriteLine("═════════════════════════════");

Console.WriteLine("\n┌────────────────────────────────────────────────────────────┐");
Console.WriteLine("│              WITHOUT INHERITANCE                           │");
Console.WriteLine("├────────────────────────────────────────────────────────────┤");
Console.WriteLine("│ class Car {                                                │");
Console.WriteLine("│     string Brand, Model, Color;  // Duplicate             │");
Console.WriteLine("│     void StartEngine() {...}     // Duplicate             │");
Console.WriteLine("│ }                                                          │");
Console.WriteLine("│ class Motorcycle {                                         │");
Console.WriteLine("│     string Brand, Model, Color;  // Duplicate             │");
Console.WriteLine("│     void StartEngine() {...}     // Duplicate             │");
Console.WriteLine("│ }                                                          │");
Console.WriteLine("│                                                            │");
Console.WriteLine("│ Problems: Code duplication, maintenance nightmare          │");
Console.WriteLine("└────────────────────────────────────────────────────────────┘");
Console.WriteLine();
Console.WriteLine("                         🔽 VS 🔽");
Console.WriteLine();
Console.WriteLine("┌────────────────────────────────────────────────────────────┐");
Console.WriteLine("│               WITH INHERITANCE                             │");
Console.WriteLine("├────────────────────────────────────────────────────────────┤");
Console.WriteLine("│ class Vehicle {                                            │");
Console.WriteLine("│     string Brand, Model, Color;  // Written once          │");
Console.WriteLine("│     void StartEngine() {...}     // Written once          │");
Console.WriteLine("│ }                                                          │");
Console.WriteLine("│ class Car : Vehicle {                                     │");
Console.WriteLine("│     // Inherits all Vehicle members                       │");
Console.WriteLine("│     // Add only car-specific features                     │");
Console.WriteLine("│ }                                                          │");
Console.WriteLine("│                                                            │");
Console.WriteLine("│ Benefits: No duplication, easy maintenance, extensible    │");
Console.WriteLine("└────────────────────────────────────────────────────────────┘");

Console.WriteLine("\n\nKEY INHERITANCE PRINCIPLES:");
Console.WriteLine("═══════════════════════════");

Console.WriteLine("┌─────────────────────────────────────────────────────────────────────┐");
Console.WriteLine("│ 1. IS-A RELATIONSHIP: Child IS-A type of Parent                    │");
Console.WriteLine("│ 2. CODE REUSE: Write once in parent, use in all children           │");
Console.WriteLine("│ 3. EXTENSIBILITY: Add new features without modifying base          │");
Console.WriteLine("│ 4. POLYMORPHISM FOUNDATION: Treat derived as base type             │");
Console.WriteLine("│ 5. REAL-WORLD MODELING: Natural way to represent hierarchies       │");
Console.WriteLine("└─────────────────────────────────────────────────────────────────────┘");

// Cleanup
Console.WriteLine("\n\nCleaning up...");
myCar.StopEngine();
myBike.StopEngine();
myTruck.UnloadCargo();
myTruck.StopEngine();

Console.WriteLine("\n╔══════════════════════════════════════════════════════════════════╗");
Console.WriteLine("║     INHERITANCE: Building on the shoulders of giants! 🏗️         ║");
Console.WriteLine("╚══════════════════════════════════════════════════════════════════╝");