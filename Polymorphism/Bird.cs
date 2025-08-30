namespace Polymorphism;

/// <summary>
/// Bird class - Demonstrates polymorphism with different characteristics
/// 
/// Shows how polymorphism handles objects with fundamentally different
/// capabilities (flying vs walking) through the same interface
/// </summary>
public class Bird : Animal
{
    /// <summary>
    /// Bird-specific properties
    /// </summary>
    public bool CanFly { get; private set; }
    public double WingSpan { get; private set; } // in meters

    /// <summary>
    /// Constructor with bird-specific parameters
    /// </summary>
    public Bird(string name, int age, bool canFly, double wingSpan) : base(name, age, "Bird")
    {
        CanFly = canFly;
        WingSpan = wingSpan;
    }

    /// <summary>
    /// OVERRIDE - MakeSound
    /// 
    /// Birds make different sounds - demonstrates polymorphic behavior
    /// The same method call produces different results for different animals
    /// </summary>
    public override void MakeSound()
    {
        Console.WriteLine($"{Name} the bird chirps: Tweet! Tweet!");
    }

    /// <summary>
    /// OVERRIDE - Move
    /// 
    /// This is particularly interesting for polymorphism because:
    /// - Not all birds fly (penguins, ostriches)
    /// - Shows how polymorphism handles variation within a type
    /// - Same interface, different behaviors based on properties
    /// </summary>
    public override void Move()
    {
        if (CanFly)
        {
            Console.WriteLine($"{Name} soars through the sky with {WingSpan}m wingspan");
        }
        else
        {
            Console.WriteLine($"{Name} walks on two legs");
        }
    }

    /// <summary>
    /// OVERRIDE - Sleep
    /// Birds sleep differently than mammals
    /// </summary>
    public override void Sleep()
    {
        Console.WriteLine($"{Name} tucks head under wing and sleeps on one leg");
    }

    /// <summary>
    /// NEW METHOD - Fly
    /// Bird-specific method
    /// Note: This could throw exception for flightless birds
    /// Shows importance of proper design in polymorphic systems
    /// </summary>
    public void Fly(int height)
    {
        if (CanFly)
        {
            Console.WriteLine($"{Name} flies up to {height} meters high");
        }
        else
        {
            Console.WriteLine($"{Name} cannot fly - flightless bird");
        }
    }

    /// <summary>
    /// NEW METHOD - BuildNest
    /// Bird-specific behavior
    /// </summary>
    public void BuildNest()
    {
        Console.WriteLine($"{Name} builds a nest using twigs and leaves");
    }

    /// <summary>
    /// NEW METHOD - LayEgg
    /// Another bird-specific capability
    /// </summary>
    public void LayEgg()
    {
        Console.WriteLine($"{Name} lays an egg in the nest");
    }
}