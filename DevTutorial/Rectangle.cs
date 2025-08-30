namespace Abstraction;

/// <summary>
/// Concrete implementation of the abstract Shape class for a Rectangle.
/// 
/// This class demonstrates key abstraction principles:
/// - It provides a completely different implementation than Circle
/// - Both Circle and Rectangle can be treated as Shape objects (polymorphism)
/// - The internal details of how a rectangle works are hidden from users
/// 
/// Real-world analogy:
/// Think of Shape as a "contract" that says "all shapes must be able to calculate area and perimeter"
/// Rectangle "signs" this contract by implementing these methods in its own way.
/// </summary>
public class Rectangle : Shape
{
    /// <summary>
    /// The width of the rectangle.
    /// Private setters demonstrate encapsulation - these values are read-only after construction.
    /// This prevents accidental modification and ensures object consistency.
    /// </summary>
    public double Width { get; private set; }
    
    /// <summary>
    /// The height of the rectangle.
    /// Together with Width, these properties define the rectangle's dimensions.
    /// </summary>
    public double Height { get; private set; }
    
    /// <summary>
    /// Constructor for creating a Rectangle object.
    /// Requires both dimensions to be specified at creation time.
    /// 
    /// The ': base("Rectangle")' syntax shows inheritance in action:
    /// - We're calling the Shape constructor to set the name
    /// - This ensures all shapes are properly initialized through their base class
    /// </summary>
    /// <param name="width">The width of the rectangle</param>
    /// <param name="height">The height of the rectangle</param>
    public Rectangle(double width, double height) : base("Rectangle")
    {
        Width = width;
        Height = height;
    }
    
    /// <summary>
    /// Concrete implementation of the abstract CalculateArea method.
    /// 
    /// Formula: Area = width × height
    /// 
    /// This is much simpler than Circle's area calculation, demonstrating that:
    /// - Each shape has its own complexity hidden behind the same interface
    /// - Users don't need to remember different formulas for different shapes
    /// - The abstraction allows us to treat all shapes uniformly despite their differences
    /// </summary>
    /// <returns>The area of the rectangle</returns>
    public override double CalculateArea()
    {
        return Width * Height;
    }
    
    /// <summary>
    /// Concrete implementation of the abstract CalculatePerimeter method.
    /// 
    /// Formula: Perimeter = 2 × (width + height)
    /// 
    /// Notice how different this is from Circle's perimeter calculation:
    /// - Circle uses π and radius
    /// - Rectangle uses width and height
    /// - But both implement the same abstract method
    /// This is the power of abstraction - same interface, different implementations
    /// </summary>
    /// <returns>The perimeter of the rectangle</returns>
    public override double CalculatePerimeter()
    {
        return 2 * (Width + Height);
    }
    
    /// <summary>
    /// Overrides the virtual DisplayInfo method to add Rectangle-specific information.
    /// 
    /// This method shows how abstraction and inheritance work together:
    /// - We reuse the base class functionality (displaying name, area, perimeter)
    /// - We extend it with rectangle-specific details (width and height)
    /// - Each shape can customize how it presents itself while maintaining consistency
    /// 
    /// This is a key benefit of abstraction - we get both:
    /// 1. Consistency (all shapes display basic info the same way)
    /// 2. Flexibility (each shape can add its own details)
    /// </summary>
    public override void DisplayInfo()
    {
        base.DisplayInfo();  // Reuse base functionality - DRY principle
        Console.WriteLine($"Width: {Width:F2}");   // Add rectangle-specific info
        Console.WriteLine($"Height: {Height:F2}");
    }
}