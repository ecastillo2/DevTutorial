namespace Inheritance;

/// <summary>
/// Truck class - Shows inheritance with commercial vehicle features
/// Demonstrates how inheritance models specialized types
/// </summary>
public class Truck : Vehicle
{
    /// <summary>
    /// TRUCK-SPECIFIC PROPERTIES
    /// </summary>
    public double PayloadCapacity { get; private set; }  // in pounds
    public double CurrentLoad { get; private set; }
    public int NumberOfAxles { get; private set; }
    public bool HasTrailer { get; private set; }
    private bool cargoSecured;

    /// <summary>
    /// CONSTRUCTOR
    /// </summary>
    public Truck(string manufacturer, string model, int year, string color, 
                 double maxSpeed, double payloadCapacity, int axles) 
        : base(manufacturer, model, year, color, maxSpeed)
    {
        PayloadCapacity = payloadCapacity;
        NumberOfAxles = axles;
        CurrentLoad = 0;
        HasTrailer = false;
        cargoSecured = false;
        
        Console.WriteLine($"[DERIVED] Truck constructor called for {manufacturer} {model}");
    }

    /// <summary>
    /// OVERRIDE - StartEngine
    /// Trucks need air pressure for brakes
    /// </summary>
    public override void StartEngine()
    {
        Console.WriteLine("Checking air pressure for brakes...");
        Console.WriteLine("Waiting for air pressure to build...");
        base.StartEngine();
        Console.WriteLine("Air pressure OK - ready to drive");
    }

    /// <summary>
    /// OVERRIDE - Accelerate
    /// Trucks accelerate slower with heavy loads
    /// </summary>
    public override void Accelerate(double speedIncrease)
    {
        if (CurrentLoad > PayloadCapacity)
        {
            Console.WriteLine("WARNING: Overloaded! Cannot accelerate safely");
            return;
        }

        // Reduce acceleration based on load
        double loadFactor = 1 - (CurrentLoad / PayloadCapacity) * 0.5;
        double actualIncrease = speedIncrease * loadFactor;
        
        Console.WriteLine($"Accelerating with {CurrentLoad} lbs of cargo...");
        base.Accelerate(actualIncrease);
    }

    /// <summary>
    /// OVERRIDE - Brake
    /// Trucks need longer stopping distance
    /// </summary>
    public override void Brake(double speedDecrease)
    {
        Console.WriteLine("Applying air brakes...");
        if (CurrentLoad > PayloadCapacity * 0.8)
        {
            Console.WriteLine("Heavy load - extra braking distance needed!");
        }
        base.Brake(speedDecrease);
    }

    /// <summary>
    /// NEW METHOD - LoadCargo
    /// Truck-specific functionality
    /// </summary>
    public void LoadCargo(double weight, string description)
    {
        if (CurrentSpeed > 0)
        {
            Console.WriteLine("Stop the truck before loading!");
            return;
        }

        if (CurrentLoad + weight > PayloadCapacity)
        {
            Console.WriteLine($"Cannot load {weight} lbs - would exceed capacity!");
            Console.WriteLine($"Current: {CurrentLoad} lbs, Capacity: {PayloadCapacity} lbs");
            return;
        }

        CurrentLoad += weight;
        Console.WriteLine($"Loaded {weight} lbs of {description}");
        Console.WriteLine($"Total load: {CurrentLoad}/{PayloadCapacity} lbs");
    }

    /// <summary>
    /// NEW METHOD - UnloadCargo
    /// </summary>
    public void UnloadCargo()
    {
        if (CurrentSpeed > 0)
        {
            Console.WriteLine("Stop the truck before unloading!");
            return;
        }

        if (CurrentLoad > 0)
        {
            Console.WriteLine($"Unloading {CurrentLoad} lbs of cargo...");
            CurrentLoad = 0;
            cargoSecured = false;
            Console.WriteLine("Truck is now empty");
        }
        else
        {
            Console.WriteLine("No cargo to unload");
        }
    }

    /// <summary>
    /// NEW METHOD - SecureCargo
    /// Safety feature for trucks
    /// </summary>
    public void SecureCargo()
    {
        if (CurrentLoad > 0)
        {
            cargoSecured = true;
            Console.WriteLine("Cargo secured with straps and chains");
        }
        else
        {
            Console.WriteLine("No cargo to secure");
        }
    }

    /// <summary>
    /// NEW METHOD - AttachTrailer
    /// </summary>
    public void AttachTrailer()
    {
        if (CurrentSpeed > 0)
        {
            Console.WriteLine("Stop the truck before attaching trailer!");
            return;
        }

        if (!HasTrailer)
        {
            HasTrailer = true;
            PayloadCapacity *= 1.5;  // Increase capacity with trailer
            Console.WriteLine("Trailer attached - payload capacity increased");
        }
        else
        {
            Console.WriteLine("Trailer already attached");
        }
    }

    /// <summary>
    /// OVERRIDE - PerformMaintenance
    /// Commercial vehicle maintenance requirements
    /// </summary>
    public override void PerformMaintenance()
    {
        base.PerformMaintenance();
        
        Console.WriteLine("- Inspecting air brake system");
        Console.WriteLine("- Checking cargo securing equipment");
        Console.WriteLine("- Verifying weight distribution");
        Console.WriteLine("- DOT compliance check");
        
        if (HasTrailer)
        {
            Console.WriteLine("- Inspecting trailer connections");
            Console.WriteLine("- Checking trailer lights");
        }
    }

    /// <summary>
    /// NEW METHOD - DisplayTruckInfo
    /// </summary>
    public void DisplayTruckInfo()
    {
        Console.WriteLine("\n=== Truck Information ===");
        Console.WriteLine(GetInfo());  // Inherited method
        Console.WriteLine($"Payload Capacity: {PayloadCapacity} lbs");
        Console.WriteLine($"Current Load: {CurrentLoad} lbs ({(CurrentLoad/PayloadCapacity)*100:F1}% full)");
        Console.WriteLine($"Number of Axles: {NumberOfAxles}");
        Console.WriteLine($"Trailer Attached: {(HasTrailer ? "Yes" : "No")}");
        Console.WriteLine($"Cargo Secured: {(cargoSecured ? "Yes" : "No")}");
        DisplayDashboard();  // Protected inherited method
    }
}