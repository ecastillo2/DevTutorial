namespace Inheritance;

/// <summary>
/// Motorcycle class - Another derived class from Vehicle
/// Shows how different derived classes can have:
/// - Different properties
/// - Different method implementations
/// - Different behaviors while sharing common base
/// </summary>
public class Motorcycle : Vehicle
{
    /// <summary>
    /// MOTORCYCLE-SPECIFIC PROPERTIES
    /// </summary>
    public string Type { get; private set; }  // Sport, Cruiser, Touring, etc.
    public bool HasSidecar { get; private set; }
    private bool kickstandDown;
    private int currentLean;  // Degrees of lean angle

    /// <summary>
    /// CONSTRUCTOR with motorcycle-specific parameters
    /// Calls base constructor to initialize common properties
    /// </summary>
    public Motorcycle(string manufacturer, string model, int year, string color, 
                     double maxSpeed, string type, bool hasSidecar) 
        : base(manufacturer, model, year, color, maxSpeed)
    {
        Type = type;
        HasSidecar = hasSidecar;
        kickstandDown = true;  // Starts with kickstand down
        currentLean = 0;
        
        Console.WriteLine($"[DERIVED] Motorcycle constructor called for {manufacturer} {model}");
    }

    /// <summary>
    /// OVERRIDE - StartEngine
    /// Motorcycles start differently than cars
    /// </summary>
    public override void StartEngine()
    {
        if (kickstandDown)
        {
            Console.WriteLine("Please put up the kickstand first!");
            return;
        }
        
        Console.WriteLine("Turning key, pulling clutch, pressing start button...");
        base.StartEngine();
        Console.WriteLine("The motorcycle rumbles to life!");
    }

    /// <summary>
    /// OVERRIDE - StopEngine
    /// Must be in neutral with kickstand down
    /// </summary>
    public override void StopEngine()
    {
        if (!kickstandDown)
        {
            Console.WriteLine("Put down the kickstand first for safety");
            PutDownKickstand();
        }
        
        base.StopEngine();
    }

    /// <summary>
    /// OVERRIDE - Accelerate
    /// Motorcycles accelerate with twist throttle
    /// </summary>
    public override void Accelerate(double speedIncrease)
    {
        if (kickstandDown)
        {
            Console.WriteLine("Cannot accelerate with kickstand down!");
            return;
        }

        Console.WriteLine("Twisting throttle...");
        base.Accelerate(speedIncrease);
        
        if (Type == "Sport" && CurrentSpeed > 100)
        {
            Console.WriteLine("Leaning forward into racing position");
        }
    }

    /// <summary>
    /// OVERRIDE - Brake
    /// Motorcycles use front and rear brakes
    /// </summary>
    public override void Brake(double speedDecrease)
    {
        Console.WriteLine("Applying front and rear brakes smoothly...");
        base.Brake(speedDecrease);
        
        if (CurrentSpeed == 0)
        {
            Console.WriteLine("Motorcycle stopped, putting feet down");
        }
    }

    /// <summary>
    /// NEW METHOD - LeanIntoTurn
    /// Motorcycle-specific riding technique
    /// </summary>
    public void LeanIntoTurn(int degrees)
    {
        if (CurrentSpeed < 10)
        {
            Console.WriteLine("Too slow to lean safely");
            return;
        }

        currentLean = Math.Min(45, Math.Abs(degrees));  // Max 45 degrees
        string direction = degrees > 0 ? "right" : "left";
        Console.WriteLine($"Leaning {currentLean} degrees to the {direction}");
        
        if (currentLean > 30)
        {
            Console.WriteLine("Knee getting close to the ground!");
        }
    }

    /// <summary>
    /// NEW METHOD - DoWheelie
    /// Sport bike specific stunt
    /// </summary>
    public void DoWheelie()
    {
        if (Type != "Sport")
        {
            Console.WriteLine($"A {Type} motorcycle isn't built for wheelies!");
            return;
        }

        if (CurrentSpeed < 20 || CurrentSpeed > 60)
        {
            Console.WriteLine("Wrong speed for a wheelie");
            return;
        }

        Console.WriteLine("Pulling up on handlebars... Front wheel lifts off the ground!");
        Console.WriteLine("*Please don't try this at home*");
    }

    /// <summary>
    /// NEW METHOD - PutDownKickstand
    /// </summary>
    public void PutDownKickstand()
    {
        if (!kickstandDown && CurrentSpeed == 0)
        {
            kickstandDown = true;
            Console.WriteLine("Kickstand is down");
        }
    }

    /// <summary>
    /// NEW METHOD - PutUpKickstand
    /// </summary>
    public void PutUpKickstand()
    {
        if (kickstandDown)
        {
            kickstandDown = false;
            Console.WriteLine("Kickstand is up, ready to ride");
        }
    }

    /// <summary>
    /// OVERRIDE - PerformMaintenance
    /// Motorcycle-specific maintenance
    /// </summary>
    public override void PerformMaintenance()
    {
        base.PerformMaintenance();
        
        Console.WriteLine("- Checking chain tension");
        Console.WriteLine("- Inspecting brake pads");
        Console.WriteLine("- Adjusting clutch cable");
        if (Type == "Sport")
        {
            Console.WriteLine("- Checking tire pressure for track specs");
        }
    }

    /// <summary>
    /// NEW METHOD - DisplayBikeInfo
    /// </summary>
    public void DisplayBikeInfo()
    {
        Console.WriteLine("\n=== Motorcycle Information ===");
        Console.WriteLine(GetInfo());  // Inherited method
        Console.WriteLine($"Type: {Type}");
        Console.WriteLine($"Sidecar: {(HasSidecar ? "Yes" : "No")}");
        Console.WriteLine($"Kickstand: {(kickstandDown ? "Down" : "Up")}");
        DisplayDashboard();  // Protected inherited method
    }
}