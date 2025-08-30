namespace InterfaceSegregation.BadExamples;

/// <summary>
/// BAD EXAMPLE - Fat interface violating Interface Segregation Principle
/// 
/// IWorker interface forces all implementers to implement methods they don't need
/// This violates ISP - clients should not be forced to depend on interfaces they don't use
/// 
/// PROBLEMS:
/// - Classes implement methods they don't need
/// - Leads to NotImplementedException or empty methods
/// - High coupling between unrelated functionalities
/// - Difficult to maintain and extend
/// </summary>
public interface IWorker_Bad
{
    // Work-related methods
    void Work();
    void TakeBreak();
    
    // Salary-related methods
    decimal CalculateSalary();
    void ProcessPayment();
    
    // Management-related methods
    void ManageTeam();
    void ConductPerformanceReview();
    
    // Technical methods
    void WriteCode();
    void FixBugs();
    
    // Administrative methods
    void FileReports();
    void AttendMeetings();
}

/// <summary>
/// VIOLATION: Developer implements unnecessary management methods
/// </summary>
public class Developer_Bad : IWorker_Bad
{
    public void Work()
    {
        Console.WriteLine("Developer is coding");
    }

    public void TakeBreak()
    {
        Console.WriteLine("Developer taking a coffee break");
    }

    public decimal CalculateSalary()
    {
        return 80000m;
    }

    public void ProcessPayment()
    {
        Console.WriteLine("Processing developer payment");
    }

    public void ManageTeam()
    {
        // PROBLEM: Developer doesn't manage teams!
        throw new NotImplementedException("Developers don't manage teams");
    }

    public void ConductPerformanceReview()
    {
        // PROBLEM: Developer doesn't conduct reviews!
        throw new NotImplementedException("Developers don't conduct performance reviews");
    }

    public void WriteCode()
    {
        Console.WriteLine("Writing clean code");
    }

    public void FixBugs()
    {
        Console.WriteLine("Fixing bugs");
    }

    public void FileReports()
    {
        Console.WriteLine("Filing technical reports");
    }

    public void AttendMeetings()
    {
        Console.WriteLine("Attending standup meeting");
    }
}

/// <summary>
/// VIOLATION: Manager implements unnecessary technical methods
/// </summary>
public class Manager_Bad : IWorker_Bad
{
    public void Work()
    {
        Console.WriteLine("Manager is managing");
    }

    public void TakeBreak()
    {
        Console.WriteLine("Manager taking a break");
    }

    public decimal CalculateSalary()
    {
        return 100000m;
    }

    public void ProcessPayment()
    {
        Console.WriteLine("Processing manager payment");
    }

    public void ManageTeam()
    {
        Console.WriteLine("Managing team members");
    }

    public void ConductPerformanceReview()
    {
        Console.WriteLine("Conducting performance reviews");
    }

    public void WriteCode()
    {
        // PROBLEM: Manager doesn't write code!
        throw new NotImplementedException("Managers don't write code");
    }

    public void FixBugs()
    {
        // PROBLEM: Manager doesn't fix bugs!
        throw new NotImplementedException("Managers don't fix bugs");
    }

    public void FileReports()
    {
        Console.WriteLine("Filing management reports");
    }

    public void AttendMeetings()
    {
        Console.WriteLine("Leading meetings");
    }
}

/// <summary>
/// VIOLATION: Robot implements human-specific methods
/// </summary>
public class Robot_Bad : IWorker_Bad
{
    public void Work()
    {
        Console.WriteLine("Robot is working 24/7");
    }

    public void TakeBreak()
    {
        // PROBLEM: Robots don't need breaks!
        throw new NotImplementedException("Robots don't take breaks");
    }

    public decimal CalculateSalary()
    {
        // PROBLEM: Robots don't get salary!
        return 0;
    }

    public void ProcessPayment()
    {
        // PROBLEM: No payment for robots!
        throw new NotImplementedException("Robots don't receive payments");
    }

    public void ManageTeam()
    {
        throw new NotImplementedException("Robots don't manage teams");
    }

    public void ConductPerformanceReview()
    {
        throw new NotImplementedException("Robots don't conduct reviews");
    }

    public void WriteCode()
    {
        Console.WriteLine("Generating code automatically");
    }

    public void FixBugs()
    {
        Console.WriteLine("Auto-fixing bugs");
    }

    public void FileReports()
    {
        Console.WriteLine("Generating automated reports");
    }

    public void AttendMeetings()
    {
        // PROBLEM: Robots don't attend meetings!
        throw new NotImplementedException("Robots don't attend meetings");
    }
}

/// <summary>
/// BAD EXAMPLE - All-in-one printer interface
/// Forces simple printers to implement advanced features
/// </summary>
public interface IPrinter_Bad
{
    void Print(string document);
    void Scan(string document);
    void Fax(string document);
    void PrintDuplex(string document);
    void PrintColor(string document);
    void Staple(string document);
    void Email(string document, string recipient);
}

/// <summary>
/// VIOLATION: Simple printer forced to implement features it doesn't have
/// </summary>
public class SimplePrinter_Bad : IPrinter_Bad
{
    public void Print(string document)
    {
        Console.WriteLine($"Printing: {document}");
    }

    public void Scan(string document)
    {
        // PROBLEM: Simple printer can't scan!
        throw new NotSupportedException("This printer cannot scan");
    }

    public void Fax(string document)
    {
        // PROBLEM: Simple printer can't fax!
        throw new NotSupportedException("This printer cannot fax");
    }

    public void PrintDuplex(string document)
    {
        // PROBLEM: No duplex capability!
        throw new NotSupportedException("This printer cannot print duplex");
    }

    public void PrintColor(string document)
    {
        // PROBLEM: Black and white only!
        Console.WriteLine("WARNING: Printing in black and white only");
    }

    public void Staple(string document)
    {
        // PROBLEM: No stapler!
        throw new NotSupportedException("This printer cannot staple");
    }

    public void Email(string document, string recipient)
    {
        // PROBLEM: No network capability!
        throw new NotSupportedException("This printer cannot send emails");
    }
}

/// <summary>
/// BAD EXAMPLE - Media player interface with too many responsibilities
/// </summary>
public interface IMediaPlayer_Bad
{
    // Audio methods
    void PlayAudio(string file);
    void PauseAudio();
    void StopAudio();
    
    // Video methods
    void PlayVideo(string file);
    void PauseVideo();
    void StopVideo();
    
    // Streaming methods
    void StreamOnline(string url);
    void DownloadContent(string url);
    
    // Recording methods
    void RecordAudio();
    void RecordVideo();
    
    // Editing methods
    void EditAudio(string file);
    void EditVideo(string file);
    
    // Playlist methods
    void CreatePlaylist(string name);
    void AddToPlaylist(string file);
}

/// <summary>
/// VIOLATION: Audio player forced to implement video methods
/// </summary>
public class AudioPlayer_Bad : IMediaPlayer_Bad
{
    public void PlayAudio(string file)
    {
        Console.WriteLine($"Playing audio: {file}");
    }

    public void PauseAudio()
    {
        Console.WriteLine("Audio paused");
    }

    public void StopAudio()
    {
        Console.WriteLine("Audio stopped");
    }

    public void PlayVideo(string file)
    {
        // PROBLEM: Audio player can't play video!
        throw new NotSupportedException("Audio player cannot play video");
    }

    public void PauseVideo()
    {
        throw new NotSupportedException("Audio player cannot pause video");
    }

    public void StopVideo()
    {
        throw new NotSupportedException("Audio player cannot stop video");
    }

    public void StreamOnline(string url)
    {
        Console.WriteLine($"Streaming audio from: {url}");
    }

    public void DownloadContent(string url)
    {
        // PROBLEM: Basic player doesn't download!
        throw new NotSupportedException("This player cannot download content");
    }

    public void RecordAudio()
    {
        // PROBLEM: Playback only!
        throw new NotSupportedException("This player cannot record");
    }

    public void RecordVideo()
    {
        throw new NotSupportedException("This player cannot record video");
    }

    public void EditAudio(string file)
    {
        // PROBLEM: No editing capability!
        throw new NotSupportedException("This player cannot edit audio");
    }

    public void EditVideo(string file)
    {
        throw new NotSupportedException("This player cannot edit video");
    }

    public void CreatePlaylist(string name)
    {
        Console.WriteLine($"Creating playlist: {name}");
    }

    public void AddToPlaylist(string file)
    {
        Console.WriteLine($"Adding to playlist: {file}");
    }
}

/// <summary>
/// BAD EXAMPLE - Vehicle interface with methods not applicable to all vehicles
/// </summary>
public interface IVehicle_Bad
{
    void StartEngine();
    void StopEngine();
    void Accelerate();
    void Brake();
    void Fly();
    void Sail();
    void ChargeBattery();
    void RefuelGas();
    void OpenConvertibleTop();
    void EngageAutopilot();
}

/// <summary>
/// VIOLATION: Car implements methods it doesn't need
/// </summary>
public class Car_Bad : IVehicle_Bad
{
    public void StartEngine()
    {
        Console.WriteLine("Starting car engine");
    }

    public void StopEngine()
    {
        Console.WriteLine("Stopping car engine");
    }

    public void Accelerate()
    {
        Console.WriteLine("Car accelerating");
    }

    public void Brake()
    {
        Console.WriteLine("Car braking");
    }

    public void Fly()
    {
        // PROBLEM: Cars don't fly!
        throw new NotSupportedException("Cars cannot fly");
    }

    public void Sail()
    {
        // PROBLEM: Cars don't sail!
        throw new NotSupportedException("Cars cannot sail");
    }

    public void ChargeBattery()
    {
        // PROBLEM: Not an electric car!
        throw new NotSupportedException("This car doesn't have a battery to charge");
    }

    public void RefuelGas()
    {
        Console.WriteLine("Refueling gas tank");
    }

    public void OpenConvertibleTop()
    {
        // PROBLEM: Not a convertible!
        throw new NotSupportedException("This car doesn't have a convertible top");
    }

    public void EngageAutopilot()
    {
        // PROBLEM: No autopilot!
        throw new NotSupportedException("This car doesn't have autopilot");
    }
}

/// <summary>
/// BAD EXAMPLE - Restaurant system with fat interface
/// </summary>
public interface IRestaurantEmployee_Bad
{
    // Cooking methods
    void CookFood(string dish);
    void PrepareDessert(string dessert);
    void TasteFood();
    
    // Serving methods
    void TakeOrder(int tableNumber);
    void ServeFood(int tableNumber);
    void ClearTable(int tableNumber);
    
    // Cashier methods
    void ProcessPayment(decimal amount);
    void GiveChange(decimal amount);
    void PrintReceipt();
    
    // Management methods
    void HireEmployee(string name);
    void FireEmployee(string name);
    void CreateMenu();
    
    // Cleaning methods
    void CleanKitchen();
    void WashDishes();
    void MopFloor();
}

/// <summary>
/// VIOLATION: Waiter implements cooking and management methods unnecessarily
/// </summary>
public class Waiter_Bad : IRestaurantEmployee_Bad
{
    public void CookFood(string dish)
    {
        // PROBLEM: Waiters don't cook!
        throw new NotImplementedException("Waiters don't cook food");
    }

    public void PrepareDessert(string dessert)
    {
        throw new NotImplementedException("Waiters don't prepare desserts");
    }

    public void TasteFood()
    {
        throw new NotImplementedException("Waiters don't taste food");
    }

    public void TakeOrder(int tableNumber)
    {
        Console.WriteLine($"Taking order from table {tableNumber}");
    }

    public void ServeFood(int tableNumber)
    {
        Console.WriteLine($"Serving food to table {tableNumber}");
    }

    public void ClearTable(int tableNumber)
    {
        Console.WriteLine($"Clearing table {tableNumber}");
    }

    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing payment of ${amount}");
    }

    public void GiveChange(decimal amount)
    {
        Console.WriteLine($"Giving change of ${amount}");
    }

    public void PrintReceipt()
    {
        Console.WriteLine("Printing receipt");
    }

    public void HireEmployee(string name)
    {
        // PROBLEM: Waiters don't hire!
        throw new NotImplementedException("Waiters cannot hire employees");
    }

    public void FireEmployee(string name)
    {
        throw new NotImplementedException("Waiters cannot fire employees");
    }

    public void CreateMenu()
    {
        throw new NotImplementedException("Waiters don't create menus");
    }

    public void CleanKitchen()
    {
        // PROBLEM: Not waiter's job!
        throw new NotImplementedException("Waiters don't clean kitchens");
    }

    public void WashDishes()
    {
        throw new NotImplementedException("Waiters don't wash dishes");
    }

    public void MopFloor()
    {
        Console.WriteLine("Mopping dining area floor");
    }
}