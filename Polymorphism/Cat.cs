namespace Polymorphism;

/// <summary>
/// Cat class - Another example of polymorphic behavior
/// 
/// Shows how different derived classes can have:
/// - Different implementations of the same virtual methods
/// - Their own unique properties and methods
/// - Different behaviors while being treated as the same base type
/// </summary>
public class Cat : Animal
{
    /// <summary>
    /// Cat-specific property
    /// </summary>
    public bool IsIndoor { get; private set; }

    /// <summary>
    /// Constructor with cat-specific parameters
    /// </summary>
    public Cat(string name, int age, bool isIndoor) : base(name, age, "Cat")
    {
        IsIndoor = isIndoor;
    }

    /// <summary>
    /// OVERRIDE - MakeSound
    /// 
    /// Different implementation than Dog
    /// This demonstrates the "many forms" aspect of polymorphism
    /// Same method call, different behavior based on actual type
    /// </summary>
    public override void MakeSound()
    {
        Console.WriteLine($"{Name} the cat meows: Meow! Meow!");
    }

    /// <summary>
    /// OVERRIDE - Move
    /// Cat-specific movement
    /// </summary>
    public override void Move()
    {
        Console.WriteLine($"{Name} prowls silently with feline grace");
    }

    /// <summary>
    /// OVERRIDE - Eat
    /// Overrides base eating behavior with cat-specific implementation
    /// Shows selective overriding - not all virtual methods need overriding
    /// </summary>
    public override void Eat(string food)
    {
        if (food.ToLower().Contains("fish") || food.ToLower().Contains("mouse"))
        {
            Console.WriteLine($"{Name} eagerly devours the {food}");
        }
        else
        {
            Console.WriteLine($"{Name} sniffs the {food} and walks away");
        }
    }

    /// <summary>
    /// NEW METHOD - Purr
    /// Cat-specific behavior
    /// </summary>
    public void Purr()
    {
        Console.WriteLine($"{Name} purrs contentedly: Purrrrr...");
    }

    /// <summary>
    /// NEW METHOD - ClimbTree
    /// Another cat-specific ability
    /// </summary>
    public void ClimbTree()
    {
        if (!IsIndoor)
        {
            Console.WriteLine($"{Name} climbs up the nearest tree");
        }
        else
        {
            Console.WriteLine($"{Name} climbs on the cat tree");
        }
    }

    /// <summary>
    /// NEW METHOD - Hunt
    /// Demonstrates behavior that varies based on cat type
    /// </summary>
    public void Hunt()
    {
        if (IsIndoor)
        {
            Console.WriteLine($"{Name} hunts a toy mouse");
        }
        else
        {
            Console.WriteLine($"{Name} hunts real prey outside");
        }
    }
}