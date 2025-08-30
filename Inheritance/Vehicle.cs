namespace Inheritance;

/// <summary>
/// INHERITANCE IN OOP:
/// 
/// Inheritance is a fundamental OOP principle that allows a class to inherit
/// properties and methods from another class. It establishes an "IS-A" relationship.
/// 
/// KEY CONCEPTS:
/// 1. BASE CLASS (Parent/Super): The class being inherited from
/// 2. DERIVED CLASS (Child/Sub): The class that inherits
/// 3. CODE REUSE: Avoid duplicating common functionality
/// 4. HIERARCHICAL RELATIONSHIPS: Model real-world relationships
/// 
/// TYPES OF INHERITANCE IN C#:
/// - Single Inheritance: A class inherits from one base class (C# only supports this)
/// - Multi-level Inheritance: A->B->C (chain of inheritance)
/// - Hierarchical Inheritance: Multiple classes inherit from same base
/// - C# does NOT support multiple inheritance (use interfaces instead)
/// 
/// BENEFITS:
/// - Reusability: Write once, use in many places
/// - Extensibility: Add new features to existing code
/// - Maintainability: Changes in base class reflect in all derived classes
/// - Real-world modeling: Natural way to represent relationships
/// </summary>
public class Vehicle
{
    /// <summary>
    /// PROTECTED FIELDS
    /// 'protected' is key for inheritance:
    /// - Private to outside world
    /// - Accessible to derived classes
    /// This allows child classes to access parent's data
    /// </summary>
    protected string manufacturer;
    protected int year;
    protected double currentSpeed;
    protected bool isEngineRunning;

    /// <summary>
    /// PUBLIC PROPERTIES
    /// These are inherited by all derived classes
    /// Derived classes can use these without redefinition
    /// </summary>
    public string Manufacturer 
    { 
        get { return manufacturer; }
        protected set { manufacturer = value; }
    }

    public string Model { get; protected set; }
    
    public int Year 
    { 
        get { return year; }
        protected set 
        {
            if (value < 1885 || value > DateTime.Now.Year + 1)
                throw new ArgumentException("Invalid year");
            year = value;
        }
    }

    public string Color { get; set; }
    
    public double MaxSpeed { get; protected set; }
    
    public double CurrentSpeed 
    { 
        get { return currentSpeed; }
        protected set { currentSpeed = Math.Max(0, Math.Min(value, MaxSpeed)); }
    }

    /// <summary>
    /// BASE CLASS CONSTRUCTOR
    /// Derived classes will call this to initialize common properties
    /// Shows how inheritance reduces code duplication
    /// </summary>
    public Vehicle(string manufacturer, string model, int year, string color, double maxSpeed)
    {
        this.manufacturer = manufacturer;
        Model = model;
        Year = year;
        Color = color;
        MaxSpeed = maxSpeed;
        currentSpeed = 0;
        isEngineRunning = false;
        
        Console.WriteLine($"[BASE] Vehicle constructor called for {manufacturer} {model}");
    }

    /// <summary>
    /// VIRTUAL METHOD - StartEngine
    /// Can be overridden by derived classes for specific behavior
    /// Provides default implementation that works for most vehicles
    /// </summary>
    public virtual void StartEngine()
    {
        if (!isEngineRunning)
        {
            isEngineRunning = true;
            Console.WriteLine($"The {Model}'s engine starts with a rumble");
        }
        else
        {
            Console.WriteLine($"The {Model}'s engine is already running");
        }
    }

    /// <summary>
    /// VIRTUAL METHOD - StopEngine
    /// Base implementation that can be customized
    /// </summary>
    public virtual void StopEngine()
    {
        if (isEngineRunning)
        {
            isEngineRunning = false;
            currentSpeed = 0;
            Console.WriteLine($"The {Model}'s engine stops");
        }
    }

    /// <summary>
    /// VIRTUAL METHOD - Accelerate
    /// Shows how base class can provide common logic
    /// Derived classes can override for specific behavior
    /// </summary>
    public virtual void Accelerate(double speedIncrease)
    {
        if (!isEngineRunning)
        {
            Console.WriteLine("Please start the engine first!");
            return;
        }

        double newSpeed = currentSpeed + speedIncrease;
        CurrentSpeed = newSpeed; // Uses property setter for validation
        
        Console.WriteLine($"{Model} accelerates to {CurrentSpeed} mph");
    }

    /// <summary>
    /// VIRTUAL METHOD - Brake
    /// Common functionality with customization option
    /// </summary>
    public virtual void Brake(double speedDecrease)
    {
        CurrentSpeed = currentSpeed - speedDecrease;
        Console.WriteLine($"{Model} slows down to {CurrentSpeed} mph");
    }

    /// <summary>
    /// NON-VIRTUAL METHOD - GetInfo
    /// This CANNOT be overridden - all vehicles use this exact implementation
    /// Shows that not everything needs to be virtual
    /// </summary>
    public string GetInfo()
    {
        return $"{Year} {Manufacturer} {Model} - {Color}";
    }

    /// <summary>
    /// VIRTUAL METHOD - PerformMaintenance
    /// Base maintenance that applies to all vehicles
    /// </summary>
    public virtual void PerformMaintenance()
    {
        Console.WriteLine($"Performing standard maintenance on {GetInfo()}");
        Console.WriteLine("- Checking fluids");
        Console.WriteLine("- Inspecting tires");
        Console.WriteLine("- Testing lights");
    }

    /// <summary>
    /// PROTECTED METHOD
    /// Only accessible to this class and derived classes
    /// Shows how inheritance provides controlled access
    /// </summary>
    protected void DisplayDashboard()
    {
        Console.WriteLine($"=== {Model} Dashboard ===");
        Console.WriteLine($"Speed: {CurrentSpeed}/{MaxSpeed} mph");
        Console.WriteLine($"Engine: {(isEngineRunning ? "ON" : "OFF")}");
    }

    /// <summary>
    /// Static method - NOT inherited but accessible through class name
    /// Shows what is NOT part of inheritance
    /// </summary>
    public static void CompareVehicles(Vehicle v1, Vehicle v2)
    {
        Console.WriteLine($"\nComparing {v1.GetInfo()} vs {v2.GetInfo()}");
        Console.WriteLine($"Speed difference: {Math.Abs(v1.MaxSpeed - v2.MaxSpeed)} mph");
    }
}