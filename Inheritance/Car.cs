namespace Inheritance;

/// <summary>
/// Car class - INHERITS from Vehicle
/// Demonstrates:
/// 1. How to inherit from a base class using : syntax
/// 2. Adding new properties specific to cars
/// 3. Overriding base methods for car-specific behavior
/// 4. Calling base class constructor and methods
/// 
/// Car IS-A Vehicle (inheritance relationship)
/// </summary>
public class Car : Vehicle  // ': Vehicle' means Car inherits from Vehicle
{
    /// <summary>
    /// CAR-SPECIFIC PROPERTIES
    /// These are in addition to inherited properties
    /// Shows how derived classes extend base functionality
    /// </summary>
    public int NumberOfDoors { get; private set; }
    public bool HasSunroof { get; private set; }
    public string TransmissionType { get; private set; }
    private bool trunkOpen;

    /// <summary>
    /// DERIVED CLASS CONSTRUCTOR
    /// Must call base constructor using : base(...) syntax
    /// This ensures base class is properly initialized
    /// </summary>
    public Car(string manufacturer, string model, int year, string color, 
               double maxSpeed, int doors, bool sunroof, string transmission) 
        : base(manufacturer, model, year, color, maxSpeed)  // Call base constructor
    {
        // Initialize car-specific properties
        NumberOfDoors = doors;
        HasSunroof = sunroof;
        TransmissionType = transmission;
        trunkOpen = false;
        
        Console.WriteLine($"[DERIVED] Car constructor called for {manufacturer} {model}");
    }

    /// <summary>
    /// OVERRIDE - StartEngine
    /// Provides car-specific engine start behavior
    /// Uses 'base' keyword to call parent implementation
    /// </summary>
    public override void StartEngine()
    {
        Console.WriteLine("Inserting key and turning ignition...");
        base.StartEngine();  // Call base class implementation
        Console.WriteLine("Dashboard lights up, radio turns on");
    }

    /// <summary>
    /// OVERRIDE - Accelerate
    /// Car-specific acceleration with gear shifting
    /// </summary>
    public override void Accelerate(double speedIncrease)
    {
        if (!isEngineRunning)  // Access protected field from base class
        {
            Console.WriteLine("Please start the car first!");
            return;
        }

        // Car-specific logic
        if (TransmissionType == "Manual")
        {
            Console.WriteLine("Clutch in, shift gear, clutch out...");
        }
        
        base.Accelerate(speedIncrease);  // Use base implementation
        
        if (CurrentSpeed > 60)
        {
            Console.WriteLine("Wind noise increases at highway speeds");
        }
    }

    /// <summary>
    /// NEW METHOD - OpenTrunk
    /// Car-specific functionality not in base class
    /// Shows how derived classes add new capabilities
    /// </summary>
    public void OpenTrunk()
    {
        if (!trunkOpen)
        {
            trunkOpen = true;
            Console.WriteLine($"{Model}'s trunk opens");
        }
        else
        {
            Console.WriteLine("Trunk is already open");
        }
    }

    /// <summary>
    /// NEW METHOD - CloseTrunk
    /// Another car-specific method
    /// </summary>
    public void CloseTrunk()
    {
        if (trunkOpen)
        {
            trunkOpen = false;
            Console.WriteLine($"{Model}'s trunk closes");
        }
    }

    /// <summary>
    /// NEW METHOD - ActivateCruiseControl
    /// Advanced car feature
    /// </summary>
    public void ActivateCruiseControl()
    {
        if (CurrentSpeed >= 25)
        {
            Console.WriteLine($"Cruise control set at {CurrentSpeed} mph");
        }
        else
        {
            Console.WriteLine("Speed too low for cruise control");
        }
    }

    /// <summary>
    /// OVERRIDE - PerformMaintenance
    /// Extends base maintenance with car-specific checks
    /// </summary>
    public override void PerformMaintenance()
    {
        base.PerformMaintenance();  // Do standard maintenance first
        
        // Add car-specific maintenance
        Console.WriteLine("- Checking transmission fluid");
        Console.WriteLine("- Rotating tires");
        if (HasSunroof)
        {
            Console.WriteLine("- Lubricating sunroof tracks");
        }
    }

    /// <summary>
    /// NEW METHOD - DisplayCarInfo
    /// Uses both inherited and car-specific properties
    /// </summary>
    public void DisplayCarInfo()
    {
        Console.WriteLine("\n=== Car Information ===");
        Console.WriteLine(GetInfo());  // Inherited method
        Console.WriteLine($"Doors: {NumberOfDoors}");
        Console.WriteLine($"Transmission: {TransmissionType}");
        Console.WriteLine($"Sunroof: {(HasSunroof ? "Yes" : "No")}");
        DisplayDashboard();  // Protected method from base class
    }
}