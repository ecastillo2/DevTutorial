namespace Abstraction;

/// <summary>
/// ABSTRACTION IN OOP:
/// 
/// Abstraction is one of the four fundamental OOP principles (along with Encapsulation, 
/// Inheritance, and Polymorphism). It involves hiding complex implementation details 
/// and showing only the essential features of an object.
/// 
/// Key concepts of Abstraction:
/// 1. Abstract Classes: Cannot be instantiated directly, serve as base classes
/// 2. Abstract Methods: Methods without implementation that MUST be implemented by derived classes
/// 3. Hiding Complexity: Users of the class don't need to know HOW something works, just WHAT it does
/// 4. Contract Definition: Abstract classes define a contract that all derived classes must follow
/// 
/// Benefits:
/// - Reduces complexity by hiding unnecessary details
/// - Enhances code reusability and maintainability
/// - Provides a clear separation between interface and implementation
/// - Allows focus on WHAT an object does rather than HOW it does it
/// </summary>
public abstract class Shape
{
    /// <summary>
    /// Protected property that stores the name of the shape.
    /// 'protected set' means derived classes can modify this value,
    /// but external code can only read it (encapsulation principle).
    /// </summary>
    public string Name { get; protected set; }
    
    /// <summary>
    /// Protected constructor that can only be called by derived classes.
    /// This enforces abstraction - you cannot create a Shape directly,
    /// you must create a specific type of shape (Circle, Rectangle, etc.)
    /// </summary>
    /// <param name="name">The name/type of the shape being created</param>
    protected Shape(string name)
    {
        Name = name;
    }
    
    /// <summary>
    /// Abstract method for calculating area.
    /// This is a CONTRACT - every shape MUST implement this method.
    /// We don't know HOW to calculate area here because it depends on the shape type.
    /// Circle uses πr², Rectangle uses width×height, etc.
    /// This demonstrates abstraction by defining WHAT must be done without specifying HOW.
    /// </summary>
    /// <returns>The calculated area of the shape</returns>
    public abstract double CalculateArea();
    
    /// <summary>
    /// Abstract method for calculating perimeter.
    /// Like CalculateArea(), this forces all derived shapes to provide
    /// their own implementation based on their specific geometry.
    /// This is the essence of abstraction - we know all shapes have a perimeter,
    /// but each calculates it differently.
    /// </summary>
    /// <returns>The calculated perimeter of the shape</returns>
    public abstract double CalculatePerimeter();
    
    /// <summary>
    /// Virtual method that provides a default implementation for displaying shape info.
    /// 'virtual' means derived classes CAN override this if they want to add more details,
    /// but they don't HAVE to (unlike abstract methods).
    /// This method demonstrates abstraction by using the abstract methods above -
    /// it doesn't know HOW area/perimeter are calculated, just that they can be.
    /// </summary>
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Shape: {Name}");
        Console.WriteLine($"Area: {CalculateArea():F2}");
        Console.WriteLine($"Perimeter: {CalculatePerimeter():F2}");
    }
}