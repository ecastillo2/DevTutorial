namespace Polymorphism;

/// <summary>
/// Dog class - Demonstrates METHOD OVERRIDING for polymorphism
/// 
/// This class shows how derived classes can:
/// 1. Override virtual methods from the base class
/// 2. Provide their own specific implementations
/// 3. Call base class methods when needed
/// 4. Add new methods specific to the derived class
/// </summary>
public class Dog : Animal
{
    /// <summary>
    /// Dog-specific property
    /// Shows that derived classes can add their own members
    /// </summary>
    public string Breed { get; private set; }

    /// <summary>
    /// Constructor calls base constructor
    /// Demonstrates proper initialization in inheritance hierarchy
    /// </summary>
    public Dog(string name, int age, string breed) : base(name, age, "Dog")
    {
        Breed = breed;
    }

    /// <summary>
    /// OVERRIDE - MakeSound
    /// 
    /// The 'override' keyword is essential for polymorphism:
    /// - It replaces the base class implementation
    /// - Called when the object is treated as Animal or Dog
    /// - This is RUNTIME polymorphism in action
    /// 
    /// When you have: Animal myPet = new Dog("Rex", 3, "Labrador");
    /// Calling myPet.MakeSound() will execute THIS method, not the base one
    /// </summary>
    public override void MakeSound()
    {
        Console.WriteLine($"{Name} the {Breed} barks: Woof! Woof!");
    }

    /// <summary>
    /// OVERRIDE - Move
    /// Provides dog-specific movement behavior
    /// </summary>
    public override void Move()
    {
        Console.WriteLine($"{Name} runs on four legs, wagging tail");
    }

    /// <summary>
    /// OVERRIDE - Sleep
    /// Overrides base behavior but also calls it
    /// Demonstrates extending rather than replacing functionality
    /// </summary>
    public override void Sleep()
    {
        Console.WriteLine($"{Name} circles three times before lying down");
        base.Sleep(); // Call the base implementation
    }

    /// <summary>
    /// NEW METHOD - Fetch
    /// Dog-specific method not in base class
    /// Shows that derived classes can add new behaviors
    /// This is NOT polymorphism - it's just inheritance
    /// </summary>
    public void Fetch(string item)
    {
        Console.WriteLine($"{Name} fetches the {item} and brings it back");
    }

    /// <summary>
    /// NEW METHOD - WagTail
    /// Another dog-specific behavior
    /// </summary>
    public void WagTail()
    {
        Console.WriteLine($"{Name} wags tail happily");
    }
}