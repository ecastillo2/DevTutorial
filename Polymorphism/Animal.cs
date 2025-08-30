namespace Polymorphism;

/// <summary>
/// POLYMORPHISM IN OOP:
/// 
/// Polymorphism means "many forms" - it allows objects of different types to be treated
/// as instances of the same type through inheritance or interfaces.
/// 
/// TWO MAIN TYPES OF POLYMORPHISM:
/// 1. COMPILE-TIME (Static) Polymorphism:
///    - Method Overloading: Same method name, different parameters
///    - Operator Overloading: Redefining operators for custom types
/// 
/// 2. RUNTIME (Dynamic) Polymorphism:
///    - Method Overriding: Derived classes provide specific implementations
///    - Interface Implementation: Different classes implement same interface differently
/// 
/// BENEFITS:
/// - Code Reusability: Write code once, use with many types
/// - Flexibility: Easy to add new types without changing existing code
/// - Extensibility: New behaviors can be added through inheritance
/// - Maintainability: Changes in one class don't affect others
/// </summary>
public class Animal
{
    /// <summary>
    /// Properties common to all animals
    /// These demonstrate that polymorphism works with shared data
    /// </summary>
    public string Name { get; protected set; }
    public int Age { get; protected set; }
    public string Species { get; protected set; }

    /// <summary>
    /// Constructor for base Animal class
    /// Protected to encourage use of derived classes
    /// </summary>
    public Animal(string name, int age, string species)
    {
        Name = name;
        Age = age;
        Species = species;
    }

    /// <summary>
    /// VIRTUAL METHOD - MakeSound
    /// 
    /// The 'virtual' keyword is KEY to runtime polymorphism:
    /// - It allows derived classes to override this method
    /// - The actual method called is determined at runtime
    /// - Based on the actual object type, not the reference type
    /// 
    /// This is the foundation of polymorphic behavior
    /// </summary>
    public virtual void MakeSound()
    {
        Console.WriteLine($"{Name} the {Species} makes a generic animal sound");
    }

    /// <summary>
    /// VIRTUAL METHOD - Move
    /// Another polymorphic method that can be overridden
    /// Each animal type can move differently
    /// </summary>
    public virtual void Move()
    {
        Console.WriteLine($"{Name} moves in a generic way");
    }

    /// <summary>
    /// VIRTUAL METHOD - Eat
    /// Demonstrates that not all virtual methods need to be overridden
    /// Derived classes can choose to use base implementation
    /// </summary>
    public virtual void Eat(string food)
    {
        Console.WriteLine($"{Name} is eating {food}");
    }

    /// <summary>
    /// NON-VIRTUAL METHOD - GetInfo
    /// This method CANNOT be overridden (no polymorphism here)
    /// All animals will use exactly this implementation
    /// </summary>
    public string GetInfo()
    {
        return $"{Name} is a {Age} year old {Species}";
    }

    /// <summary>
    /// VIRTUAL METHOD - Sleep
    /// Can be overridden but provides default behavior
    /// </summary>
    public virtual void Sleep()
    {
        Console.WriteLine($"{Name} is sleeping peacefully");
    }

    /// <summary>
    /// METHOD OVERLOADING - Example of Compile-Time Polymorphism
    /// Same method name (Feed) but different parameters
    /// Compiler determines which one to call based on arguments
    /// </summary>
    public void Feed()
    {
        Console.WriteLine($"Feeding {Name} with default food");
    }

    public void Feed(string food)
    {
        Console.WriteLine($"Feeding {Name} with {food}");
    }

    public void Feed(string food, int quantity)
    {
        Console.WriteLine($"Feeding {Name} with {quantity} portions of {food}");
    }
}