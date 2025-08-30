namespace Polymorphism;

/// <summary>
/// INTERFACE POLYMORPHISM
/// 
/// Interfaces provide another form of polymorphism:
/// - Define a contract that multiple unrelated classes can implement
/// - Each class can implement the interface methods differently
/// - Allows treating different objects uniformly through the interface
/// 
/// This is more flexible than inheritance-based polymorphism because:
/// - A class can implement multiple interfaces
/// - No inheritance hierarchy required
/// - Completely unrelated classes can share behavior
/// </summary>
public interface IPlayable
{
    /// <summary>
    /// Interface method - must be implemented by all classes
    /// No implementation here, just the signature
    /// </summary>
    void Play();
    
    /// <summary>
    /// Interface can have multiple methods
    /// All implementing classes must provide these
    /// </summary>
    void StopPlaying();
    
    /// <summary>
    /// Interface property
    /// Implementing classes must provide this property
    /// </summary>
    bool IsPlaying { get; }
    
    /// <summary>
    /// C# 8.0+ allows default interface implementations
    /// Classes can override this or use the default
    /// </summary>
    string GetPlayStatus()
    {
        return IsPlaying ? "Currently playing" : "Not playing";
    }
}

/// <summary>
/// Another interface to demonstrate multiple interface implementation
/// </summary>
public interface ITrainable
{
    void Train(string command);
    void PerformTrick();
    int TrainingLevel { get; set; }
}

/// <summary>
/// PlayfulDog - Implements both Animal inheritance AND interface
/// This demonstrates how polymorphism can work at multiple levels
/// </summary>
public class PlayfulDog : Dog, IPlayable, ITrainable
{
    private bool isPlaying;
    private int trainingLevel;
    
    public PlayfulDog(string name, int age, string breed) : base(name, age, breed)
    {
        isPlaying = false;
        trainingLevel = 0;
    }
    
    /// <summary>
    /// Implementation of IPlayable.Play
    /// Each implementing class can play differently
    /// </summary>
    public void Play()
    {
        isPlaying = true;
        Console.WriteLine($"{Name} starts playing fetch enthusiastically!");
        WagTail();
    }
    
    /// <summary>
    /// Implementation of IPlayable.StopPlaying
    /// </summary>
    public void StopPlaying()
    {
        isPlaying = false;
        Console.WriteLine($"{Name} stops playing and pants happily");
    }
    
    /// <summary>
    /// Implementation of IPlayable.IsPlaying property
    /// </summary>
    public bool IsPlaying => isPlaying;
    
    /// <summary>
    /// Implementation of ITrainable.Train
    /// </summary>
    public void Train(string command)
    {
        Console.WriteLine($"{Name} is learning the command: {command}");
        trainingLevel++;
    }
    
    /// <summary>
    /// Implementation of ITrainable.PerformTrick
    /// </summary>
    public void PerformTrick()
    {
        if (trainingLevel > 5)
        {
            Console.WriteLine($"{Name} performs an amazing backflip!");
        }
        else if (trainingLevel > 2)
        {
            Console.WriteLine($"{Name} rolls over!");
        }
        else
        {
            Console.WriteLine($"{Name} sits and gives paw!");
        }
    }
    
    /// <summary>
    /// Implementation of ITrainable.TrainingLevel
    /// </summary>
    public int TrainingLevel 
    { 
        get => trainingLevel; 
        set => trainingLevel = value; 
    }
}

/// <summary>
/// RobotDog - Completely unrelated to Animal hierarchy
/// But can still be IPlayable and ITrainable
/// This shows interface polymorphism's flexibility
/// </summary>
public class RobotDog : IPlayable, ITrainable
{
    private string model;
    private bool isPlaying;
    private int trainingLevel;
    
    public RobotDog(string model)
    {
        this.model = model;
        isPlaying = false;
        trainingLevel = 0;
    }
    
    public void Play()
    {
        isPlaying = true;
        Console.WriteLine($"Robot {model} activates play mode - LED eyes flash happily!");
    }
    
    public void StopPlaying()
    {
        isPlaying = false;
        Console.WriteLine($"Robot {model} enters standby mode");
    }
    
    public bool IsPlaying => isPlaying;
    
    public void Train(string command)
    {
        Console.WriteLine($"Robot {model} downloads {command} module");
        trainingLevel++;
    }
    
    public void PerformTrick()
    {
        Console.WriteLine($"Robot {model} executes programmed routine #{trainingLevel}");
    }
    
    public int TrainingLevel 
    { 
        get => trainingLevel; 
        set => trainingLevel = value; 
    }
    
    public void Recharge()
    {
        Console.WriteLine($"Robot {model} returns to charging station");
    }
}