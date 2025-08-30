namespace Abstraction;

/// <summary>
/// Concrete implementation of the abstract Shape class for a Circle.
/// This class demonstrates how abstraction works in practice:
/// - It inherits from Shape, gaining all its non-abstract functionality
/// - It MUST implement all abstract methods (CalculateArea, CalculatePerimeter)
/// - It provides Circle-specific implementation details
/// 
/// This is a perfect example of abstraction because:
/// 1. The base Shape class doesn't need to know HOW a circle calculates its area
/// 2. Users of this class don't need to know the mathematical formulas used internally
/// 3. The complex details (π, radius squared, etc.) are hidden behind simple method calls
/// </summary>
public class Circle : Shape
{
    /// <summary>
    /// The radius of the circle. 
    /// Private setter ensures this value can only be set during construction (immutability).
    /// This is an example of encapsulation working together with abstraction.
    /// </summary>
    public double Radius { get; private set; }
    
    /// <summary>
    /// Constructor for creating a Circle object.
    /// Calls the base constructor with "Circle" as the shape name.
    /// The ': base("Circle")' syntax demonstrates inheritance and how derived classes
    /// can utilize base class functionality while adding their own specific features.
    /// </summary>
    /// <param name="radius">The radius of the circle (must be positive)</param>
    public Circle(double radius) : base("Circle")
    {
        Radius = radius;
    }
    
    /// <summary>
    /// Concrete implementation of the abstract CalculateArea method.
    /// This method MUST be implemented because it was declared abstract in Shape.
    /// 
    /// Formula: Area = π × r²
    /// 
    /// This demonstrates abstraction because:
    /// - The Shape class defined WHAT needs to be done (calculate area)
    /// - This Circle class defines HOW it's done for circles specifically
    /// - Users don't need to know this formula, they just call CalculateArea()
    /// </summary>
    /// <returns>The area of the circle</returns>
    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
    
    /// <summary>
    /// Concrete implementation of the abstract CalculatePerimeter method.
    /// For a circle, the perimeter is called circumference.
    /// 
    /// Formula: Circumference = 2 × π × r
    /// 
    /// This is another example of abstraction:
    /// - Different shapes calculate perimeter differently
    /// - The abstract base class doesn't care about these differences
    /// - Each shape provides its own implementation
    /// </summary>
    /// <returns>The circumference (perimeter) of the circle</returns>
    public override double CalculatePerimeter()
    {
        return 2 * Math.PI * Radius;
    }
    
    /// <summary>
    /// Overrides the virtual DisplayInfo method to add Circle-specific information.
    /// First calls the base implementation (base.DisplayInfo()) to display common info,
    /// then adds the radius which is specific to circles.
    /// 
    /// This demonstrates:
    /// - Polymorphism: Same method name, different behavior
    /// - Code reuse: We don't duplicate the base functionality
    /// - Extensibility: We can add shape-specific details
    /// </summary>
    public override void DisplayInfo()
    {
        base.DisplayInfo();  // Calls Shape's DisplayInfo to show name, area, perimeter
        Console.WriteLine($"Radius: {Radius:F2}");  // Adds circle-specific information
    }
}