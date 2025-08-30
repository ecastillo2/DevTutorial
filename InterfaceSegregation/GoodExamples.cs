namespace InterfaceSegregation.GoodExamples;

/// <summary>
/// GOOD EXAMPLE - Segregated interfaces following ISP
/// 
/// Split the fat IWorker interface into focused, cohesive interfaces
/// Clients only implement what they actually need
/// </summary>

// Core work interface - everyone works
public interface IWorkable
{
    void Work();
}

// Human-specific needs
public interface IBreakable
{
    void TakeBreak();
}

// Payment-related operations
public interface IPayable
{
    decimal CalculateSalary();
    void ProcessPayment();
}

// Management capabilities
public interface IManageable
{
    void ManageTeam();
    void ConductPerformanceReview();
}

// Technical capabilities
public interface ITechnical
{
    void WriteCode();
    void FixBugs();
}

// Administrative capabilities
public interface IAdministrative
{
    void FileReports();
    void AttendMeetings();
}

/// <summary>
/// Developer implements only relevant interfaces
/// </summary>
public class Developer : IWorkable, IBreakable, IPayable, ITechnical, IAdministrative
{
    public void Work()
    {
        Console.WriteLine("Developer is writing code");
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

    public void WriteCode()
    {
        Console.WriteLine("Writing clean, maintainable code");
    }

    public void FixBugs()
    {
        Console.WriteLine("Debugging and fixing issues");
    }

    public void FileReports()
    {
        Console.WriteLine("Filing technical reports");
    }

    public void AttendMeetings()
    {
        Console.WriteLine("Attending standup and technical meetings");
    }
}

/// <summary>
/// Manager implements management interfaces
/// </summary>
public class Manager : IWorkable, IBreakable, IPayable, IManageable, IAdministrative
{
    public void Work()
    {
        Console.WriteLine("Manager is coordinating team efforts");
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
        Console.WriteLine("Managing team members and projects");
    }

    public void ConductPerformanceReview()
    {
        Console.WriteLine("Conducting quarterly performance reviews");
    }

    public void FileReports()
    {
        Console.WriteLine("Filing management and status reports");
    }

    public void AttendMeetings()
    {
        Console.WriteLine("Leading and attending strategic meetings");
    }
}

/// <summary>
/// Robot only implements what it can actually do
/// </summary>
public class Robot : IWorkable, ITechnical
{
    public void Work()
    {
        Console.WriteLine("Robot working continuously without breaks");
    }

    public void WriteCode()
    {
        Console.WriteLine("Generating code using AI algorithms");
    }

    public void FixBugs()
    {
        Console.WriteLine("Automatically detecting and fixing bugs");
    }
}

/// <summary>
/// Intern - limited capabilities
/// </summary>
public class Intern : IWorkable, IBreakable, IAdministrative
{
    public void Work()
    {
        Console.WriteLine("Intern is learning and assisting");
    }

    public void TakeBreak()
    {
        Console.WriteLine("Intern taking a break");
    }

    public void FileReports()
    {
        Console.WriteLine("Filing basic reports");
    }

    public void AttendMeetings()
    {
        Console.WriteLine("Attending meetings and taking notes");
    }
}

/// <summary>
/// GOOD EXAMPLE - Segregated printer interfaces
/// 
/// Each interface represents a specific capability
/// </summary>
public interface IPrinter
{
    void Print(string document);
}

public interface IScanner
{
    void Scan(string document);
}

public interface IFax
{
    void Fax(string document, string phoneNumber);
}

public interface IDuplexPrinter
{
    void PrintDuplex(string document);
}

public interface IColorPrinter
{
    void PrintColor(string document);
}

public interface IStapler
{
    void Staple(string document);
}

public interface INetworkPrinter
{
    void Email(string document, string recipient);
    void PrintFromNetwork(string document);
}

/// <summary>
/// Simple printer implements only basic printing
/// </summary>
public class SimplePrinter : IPrinter
{
    public void Print(string document)
    {
        Console.WriteLine($"Printing document: {document}");
    }
}

/// <summary>
/// Multifunction printer implements multiple capabilities
/// </summary>
public class MultifunctionPrinter : IPrinter, IScanner, IFax, IColorPrinter, INetworkPrinter
{
    public void Print(string document)
    {
        Console.WriteLine($"Printing document: {document}");
    }

    public void Scan(string document)
    {
        Console.WriteLine($"Scanning document: {document}");
    }

    public void Fax(string document, string phoneNumber)
    {
        Console.WriteLine($"Faxing {document} to {phoneNumber}");
    }

    public void PrintColor(string document)
    {
        Console.WriteLine($"Printing in full color: {document}");
    }

    public void Email(string document, string recipient)
    {
        Console.WriteLine($"Emailing {document} to {recipient}");
    }

    public void PrintFromNetwork(string document)
    {
        Console.WriteLine($"Printing from network: {document}");
    }
}

/// <summary>
/// Professional printer with advanced features
/// </summary>
public class ProfessionalPrinter : IPrinter, IColorPrinter, IDuplexPrinter, IStapler
{
    public void Print(string document)
    {
        Console.WriteLine($"High-quality printing: {document}");
    }

    public void PrintColor(string document)
    {
        Console.WriteLine($"Professional color printing: {document}");
    }

    public void PrintDuplex(string document)
    {
        Console.WriteLine($"Duplex printing: {document}");
    }

    public void Staple(string document)
    {
        Console.WriteLine($"Stapling document: {document}");
    }
}

/// <summary>
/// GOOD EXAMPLE - Segregated media player interfaces
/// </summary>
public interface IAudioPlayer
{
    void PlayAudio(string file);
    void PauseAudio();
    void StopAudio();
}

public interface IVideoPlayer
{
    void PlayVideo(string file);
    void PauseVideo();
    void StopVideo();
}

public interface IMediaStreamer
{
    void StreamOnline(string url);
}

public interface IMediaDownloader
{
    void DownloadContent(string url);
}

public interface IAudioRecorder
{
    void RecordAudio();
    void StopRecording();
}

public interface IVideoRecorder
{
    void RecordVideo();
    void StopRecording();
}

public interface IPlaylistManager
{
    void CreatePlaylist(string name);
    void AddToPlaylist(string file);
    void RemoveFromPlaylist(string file);
}

/// <summary>
/// Basic audio player - simple and focused
/// </summary>
public class BasicAudioPlayer : IAudioPlayer
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
}

/// <summary>
/// Streaming audio player with online capabilities
/// </summary>
public class StreamingAudioPlayer : IAudioPlayer, IMediaStreamer, IPlaylistManager
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

    public void StreamOnline(string url)
    {
        Console.WriteLine($"Streaming from: {url}");
    }

    public void CreatePlaylist(string name)
    {
        Console.WriteLine($"Created playlist: {name}");
    }

    public void AddToPlaylist(string file)
    {
        Console.WriteLine($"Added to playlist: {file}");
    }

    public void RemoveFromPlaylist(string file)
    {
        Console.WriteLine($"Removed from playlist: {file}");
    }
}

/// <summary>
/// Professional media suite with all capabilities
/// </summary>
public class ProfessionalMediaSuite : IAudioPlayer, IVideoPlayer, IMediaStreamer, 
    IMediaDownloader, IAudioRecorder, IVideoRecorder, IPlaylistManager
{
    public void PlayAudio(string file)
    {
        Console.WriteLine($"Playing audio with professional quality: {file}");
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
        Console.WriteLine($"Playing video in 4K: {file}");
    }

    public void PauseVideo()
    {
        Console.WriteLine("Video paused");
    }

    public void StopVideo()
    {
        Console.WriteLine("Video stopped");
    }

    public void StreamOnline(string url)
    {
        Console.WriteLine($"Streaming high-quality content from: {url}");
    }

    public void DownloadContent(string url)
    {
        Console.WriteLine($"Downloading content from: {url}");
    }

    public void RecordAudio()
    {
        Console.WriteLine("Recording audio in studio quality");
    }

    public void RecordVideo()
    {
        Console.WriteLine("Recording video in 4K");
    }

    void IAudioRecorder.StopRecording()
    {
        Console.WriteLine("Audio recording stopped");
    }

    void IVideoRecorder.StopRecording()
    {
        Console.WriteLine("Video recording stopped");
    }

    public void CreatePlaylist(string name)
    {
        Console.WriteLine($"Created professional playlist: {name}");
    }

    public void AddToPlaylist(string file)
    {
        Console.WriteLine($"Added to playlist: {file}");
    }

    public void RemoveFromPlaylist(string file)
    {
        Console.WriteLine($"Removed from playlist: {file}");
    }
}

/// <summary>
/// GOOD EXAMPLE - Segregated vehicle interfaces
/// </summary>
public interface IVehicle
{
    void Accelerate();
    void Brake();
}

public interface IEngine
{
    void StartEngine();
    void StopEngine();
}

public interface IFlyable
{
    void TakeOff();
    void Fly();
    void Land();
}

public interface ISailable
{
    void Sail();
    void Anchor();
}

public interface IElectric
{
    void ChargeBattery();
    int GetBatteryLevel();
}

public interface IFuelPowered
{
    void RefuelGas();
    double GetFuelLevel();
}

public interface IConvertible
{
    void OpenTop();
    void CloseTop();
}

public interface IAutonomous
{
    void EngageAutopilot();
    void DisengageAutopilot();
}

/// <summary>
/// Regular gas car
/// </summary>
public class GasCar : IVehicle, IEngine, IFuelPowered
{
    public void Accelerate()
    {
        Console.WriteLine("Car accelerating");
    }

    public void Brake()
    {
        Console.WriteLine("Car braking");
    }

    public void StartEngine()
    {
        Console.WriteLine("Starting gas engine");
    }

    public void StopEngine()
    {
        Console.WriteLine("Stopping gas engine");
    }

    public void RefuelGas()
    {
        Console.WriteLine("Refueling gas tank");
    }

    public double GetFuelLevel()
    {
        return 75.5; // percentage
    }
}

/// <summary>
/// Electric car with autopilot
/// </summary>
public class ElectricCar : IVehicle, IElectric, IAutonomous
{
    public void Accelerate()
    {
        Console.WriteLine("Electric car accelerating silently");
    }

    public void Brake()
    {
        Console.WriteLine("Electric car braking with regeneration");
    }

    public void ChargeBattery()
    {
        Console.WriteLine("Charging battery at supercharger");
    }

    public int GetBatteryLevel()
    {
        return 85; // percentage
    }

    public void EngageAutopilot()
    {
        Console.WriteLine("Autopilot engaged");
    }

    public void DisengageAutopilot()
    {
        Console.WriteLine("Manual control resumed");
    }
}

/// <summary>
/// Airplane - can fly
/// </summary>
public class Airplane : IVehicle, IEngine, IFlyable, IFuelPowered
{
    public void Accelerate()
    {
        Console.WriteLine("Airplane accelerating on runway");
    }

    public void Brake()
    {
        Console.WriteLine("Airplane braking");
    }

    public void StartEngine()
    {
        Console.WriteLine("Starting jet engines");
    }

    public void StopEngine()
    {
        Console.WriteLine("Shutting down engines");
    }

    public void TakeOff()
    {
        Console.WriteLine("Taking off");
    }

    public void Fly()
    {
        Console.WriteLine("Flying at 30,000 feet");
    }

    public void Land()
    {
        Console.WriteLine("Landing safely");
    }

    public void RefuelGas()
    {
        Console.WriteLine("Refueling with jet fuel");
    }

    public double GetFuelLevel()
    {
        return 60.0;
    }
}

/// <summary>
/// Bicycle - no engine, human powered
/// </summary>
public class Bicycle : IVehicle
{
    public void Accelerate()
    {
        Console.WriteLine("Pedaling faster");
    }

    public void Brake()
    {
        Console.WriteLine("Applying hand brakes");
    }
}

/// <summary>
/// GOOD EXAMPLE - Segregated restaurant interfaces
/// </summary>
public interface ICook
{
    void CookFood(string dish);
    void PrepareDessert(string dessert);
    void TasteFood();
}

public interface IServer
{
    void TakeOrder(int tableNumber);
    void ServeFood(int tableNumber);
    void ClearTable(int tableNumber);
}

public interface ICashier
{
    void ProcessPayment(decimal amount);
    void GiveChange(decimal amount);
    void PrintReceipt();
}

public interface IManager
{
    void HireEmployee(string name);
    void FireEmployee(string name);
    void CreateMenu();
    void ReviewPerformance();
}

public interface ICleaner
{
    void CleanArea(string area);
    void EmptyTrash();
}

public interface IDishwasher
{
    void WashDishes();
    void OrganizeKitchen();
}

/// <summary>
/// Chef - focuses on cooking
/// </summary>
public class Chef : ICook
{
    public void CookFood(string dish)
    {
        Console.WriteLine($"Chef preparing: {dish}");
    }

    public void PrepareDessert(string dessert)
    {
        Console.WriteLine($"Chef creating dessert: {dessert}");
    }

    public void TasteFood()
    {
        Console.WriteLine("Chef tasting for quality");
    }
}

/// <summary>
/// Waiter - serves customers
/// </summary>
public class Waiter : IServer, ICashier
{
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
        Console.WriteLine($"Processing payment: ${amount}");
    }

    public void GiveChange(decimal amount)
    {
        Console.WriteLine($"Giving change: ${amount}");
    }

    public void PrintReceipt()
    {
        Console.WriteLine("Printing receipt for customer");
    }
}

/// <summary>
/// Restaurant Manager - manages operations
/// </summary>
public class RestaurantManager : IManager, ICashier
{
    public void HireEmployee(string name)
    {
        Console.WriteLine($"Hiring new employee: {name}");
    }

    public void FireEmployee(string name)
    {
        Console.WriteLine($"Terminating employee: {name}");
    }

    public void CreateMenu()
    {
        Console.WriteLine("Creating new seasonal menu");
    }

    public void ReviewPerformance()
    {
        Console.WriteLine("Reviewing restaurant performance");
    }

    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Manager processing special payment: ${amount}");
    }

    public void GiveChange(decimal amount)
    {
        Console.WriteLine($"Manager handling cash: ${amount}");
    }

    public void PrintReceipt()
    {
        Console.WriteLine("Manager printing detailed receipt");
    }
}

/// <summary>
/// Dishwasher - focuses on cleaning
/// </summary>
public class Dishwasher : IDishwasher, ICleaner
{
    public void WashDishes()
    {
        Console.WriteLine("Washing dishes in industrial dishwasher");
    }

    public void OrganizeKitchen()
    {
        Console.WriteLine("Organizing clean dishes and utensils");
    }

    public void CleanArea(string area)
    {
        Console.WriteLine($"Cleaning {area}");
    }

    public void EmptyTrash()
    {
        Console.WriteLine("Emptying kitchen trash bins");
    }
}