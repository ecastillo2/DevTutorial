namespace Inheritance;

/// <summary>
/// Device base class - Shows inheritance with electronics
/// Demonstrates protected vs private members in inheritance
/// </summary>
public class Device
{
    /// <summary>
    /// FIELDS with different access modifiers
    /// </summary>
    private string serialNumber;  // NOT accessible to derived classes
    protected bool isPoweredOn;   // Accessible to derived classes
    protected double batteryLevel;

    /// <summary>
    /// PROPERTIES accessible to all
    /// </summary>
    public string Brand { get; protected set; }
    public string Model { get; protected set; }
    public DateTime ManufactureDate { get; protected set; }
    
    /// <summary>
    /// Property with private setter - can only be set within this class
    /// </summary>
    public string SerialNumber 
    { 
        get { return serialNumber; }
        private set { serialNumber = value; }
    }

    /// <summary>
    /// BASE CONSTRUCTOR
    /// </summary>
    public Device(string brand, string model, string serial)
    {
        Brand = brand;
        Model = model;
        serialNumber = serial;  // Initialize the private field directly
        ManufactureDate = DateTime.Now;
        isPoweredOn = false;
        batteryLevel = 100;
        
        Console.WriteLine($"[BASE] Device created: {brand} {model}");
    }

    /// <summary>
    /// VIRTUAL METHODS for device operations
    /// </summary>
    public virtual void PowerOn()
    {
        if (!isPoweredOn)
        {
            isPoweredOn = true;
            Console.WriteLine($"{Brand} {Model} is powering on...");
        }
    }

    public virtual void PowerOff()
    {
        if (isPoweredOn)
        {
            isPoweredOn = false;
            Console.WriteLine($"{Brand} {Model} is shutting down...");
        }
    }

    public virtual void ChargeBattery()
    {
        batteryLevel = 100;
        Console.WriteLine("Device fully charged");
    }

    /// <summary>
    /// PROTECTED METHOD - only for derived classes
    /// </summary>
    protected void ConsumeBattery(double amount)
    {
        batteryLevel = Math.Max(0, batteryLevel - amount);
        if (batteryLevel == 0)
        {
            Console.WriteLine("Battery depleted!");
            PowerOff();
        }
    }
}

/// <summary>
/// Smartphone - Inherits from Device
/// </summary>
public class Smartphone : Device
{
    /// <summary>
    /// SMARTPHONE-SPECIFIC PROPERTIES
    /// </summary>
    public string OperatingSystem { get; private set; }
    public double ScreenSize { get; private set; }
    public int CameraCount { get; private set; }
    
    private List<string> installedApps;
    private bool isScreenLocked;

    /// <summary>
    /// CONSTRUCTOR
    /// </summary>
    public Smartphone(string brand, string model, string serial, 
                     string os, double screenSize, int cameras)
        : base(brand, model, serial)
    {
        OperatingSystem = os;
        ScreenSize = screenSize;
        CameraCount = cameras;
        installedApps = new List<string> { "Phone", "Messages", "Settings" };
        isScreenLocked = true;
        
        Console.WriteLine($"[DERIVED] Smartphone initialized with {os}");
    }

    /// <summary>
    /// OVERRIDE - PowerOn
    /// </summary>
    public override void PowerOn()
    {
        base.PowerOn();
        Console.WriteLine($"{OperatingSystem} is booting...");
        Console.WriteLine("Lock screen displayed");
    }

    /// <summary>
    /// NEW METHODS - Smartphone specific
    /// </summary>
    public void UnlockScreen()
    {
        if (isPoweredOn && isScreenLocked)
        {
            isScreenLocked = false;
            Console.WriteLine("Screen unlocked");
            ConsumeBattery(0.5);  // Uses protected method from base
        }
    }

    public void InstallApp(string appName)
    {
        if (!isPoweredOn)
        {
            Console.WriteLine("Please turn on the phone first");
            return;
        }

        installedApps.Add(appName);
        Console.WriteLine($"{appName} installed successfully");
        ConsumeBattery(2);  // Installing apps uses battery
    }

    public void TakePhoto()
    {
        if (!isPoweredOn || isScreenLocked)
        {
            Console.WriteLine("Unlock the phone to take photos");
            return;
        }

        Console.WriteLine($"Photo taken with {CameraCount} camera system");
        ConsumeBattery(1);
    }
}

/// <summary>
/// Laptop - Another Device derivative
/// </summary>
public class Laptop : Device
{
    /// <summary>
    /// LAPTOP-SPECIFIC PROPERTIES
    /// </summary>
    public double ScreenSize { get; private set; }
    public int RAMSize { get; private set; }
    public int StorageCapacity { get; private set; }
    public bool HasTouchscreen { get; private set; }
    
    private bool isLidOpen;
    private int cpuTemperature;

    /// <summary>
    /// CONSTRUCTOR
    /// </summary>
    public Laptop(string brand, string model, string serial,
                  double screenSize, int ram, int storage, bool touchscreen)
        : base(brand, model, serial)
    {
        ScreenSize = screenSize;
        RAMSize = ram;
        StorageCapacity = storage;
        HasTouchscreen = touchscreen;
        isLidOpen = false;
        cpuTemperature = 25;  // Room temperature
        
        Console.WriteLine($"[DERIVED] Laptop configured with {ram}GB RAM");
    }

    /// <summary>
    /// NEW METHOD - OpenLid
    /// </summary>
    public void OpenLid()
    {
        if (!isLidOpen)
        {
            isLidOpen = true;
            Console.WriteLine("Laptop lid opened");
            if (!isPoweredOn)
            {
                PowerOn();  // Auto power-on when lid opens
            }
        }
    }

    /// <summary>
    /// OVERRIDE - PowerOn
    /// </summary>
    public override void PowerOn()
    {
        if (!isLidOpen)
        {
            Console.WriteLine("Please open the laptop lid first");
            return;
        }
        
        base.PowerOn();
        Console.WriteLine("BIOS check... RAM check... Loading OS...");
    }

    /// <summary>
    /// NEW METHOD - RunProgram
    /// </summary>
    public void RunProgram(string programName)
    {
        if (!isPoweredOn)
        {
            Console.WriteLine("Laptop must be on to run programs");
            return;
        }

        Console.WriteLine($"Running {programName}...");
        cpuTemperature += 10;
        ConsumeBattery(5);
        
        if (cpuTemperature > 80)
        {
            Console.WriteLine("WARNING: CPU getting hot, fan speed increased");
        }
    }
}

/// <summary>
/// Tablet - INHERITS from Smartphone!
/// Shows that inheritance hierarchies can be extended
/// Tablet IS-A Smartphone (in this model)
/// </summary>
public class Tablet : Smartphone
{
    /// <summary>
    /// TABLET-SPECIFIC PROPERTIES
    /// </summary>
    public bool HasStylus { get; private set; }
    public bool HasKeyboardCase { get; private set; }

    /// <summary>
    /// CONSTRUCTOR - Calls Smartphone constructor
    /// </summary>
    public Tablet(string brand, string model, string serial,
                  string os, double screenSize, bool stylus)
        : base(brand, model, serial, os, screenSize, 1)  // Usually 1 camera
    {
        HasStylus = stylus;
        HasKeyboardCase = false;
        
        Console.WriteLine($"[DERIVED-2] Tablet configured");
    }

    /// <summary>
    /// NEW METHOD - DrawWithStylus
    /// </summary>
    public void DrawWithStylus()
    {
        if (!HasStylus)
        {
            Console.WriteLine("This tablet doesn't support stylus input");
            return;
        }

        if (!isPoweredOn)  // Accessing protected member from grandparent
        {
            Console.WriteLine("Turn on the tablet first");
            return;
        }

        Console.WriteLine("Drawing with stylus on tablet screen");
        ConsumeBattery(3);  // Protected method from Device
    }

    /// <summary>
    /// OVERRIDE - PowerOn (from Device through Smartphone)
    /// </summary>
    public override void PowerOn()
    {
        base.PowerOn();  // Calls Smartphone's PowerOn
        if (HasKeyboardCase)
        {
            Console.WriteLine("Keyboard case detected and connected");
        }
    }
}