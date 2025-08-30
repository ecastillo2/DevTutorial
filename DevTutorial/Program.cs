using Abstraction;

/// <summary>
/// This program demonstrates OOP Abstraction in action.
/// 
/// Key concepts demonstrated:
/// 1. We cannot create a Shape directly (it's abstract)
/// 2. We create concrete shapes (Circle, Rectangle) but treat them as Shape objects
/// 3. Each shape calculates area/perimeter differently, but we use the same methods
/// 4. The complexity of calculations is hidden from the user
/// </summary>

Console.WriteLine("OOP Abstraction Example");
Console.WriteLine("======================\n");

// Display abstraction diagram
Console.WriteLine("ABSTRACTION HIERARCHY DIAGRAM:");
Console.WriteLine("==============================");
Console.WriteLine();
Console.WriteLine("                    ┌─────────────────────────────┐");
Console.WriteLine("                    │      Shape (Abstract)       │");
Console.WriteLine("                    ├─────────────────────────────┤");
Console.WriteLine("                    │ + Name: string              │");
Console.WriteLine("                    ├─────────────────────────────┤");
Console.WriteLine("                    │ # Shape(name)               │");
Console.WriteLine("                    │ + CalculateArea() ⚡        │");
Console.WriteLine("                    │ + CalculatePerimeter() ⚡   │");
Console.WriteLine("                    │ + DisplayInfo() 🔄          │");
Console.WriteLine("                    └─────────────┬───────────────┘");
Console.WriteLine("                                  │");
Console.WriteLine("                    ┌─────────────┴───────────────┐");
Console.WriteLine("                    │         ABSTRACTION         │");
Console.WriteLine("                    │    (Hidden Complexity)      │");
Console.WriteLine("                    └─────────────┬───────────────┘");
Console.WriteLine("              ┌───────────────────┴───────────────────┐");
Console.WriteLine("              │                                       │");
Console.WriteLine("    ┌─────────┴─────────┐                   ┌────────┴──────────┐");
Console.WriteLine("    │   Circle (Concrete)│                   │Rectangle (Concrete)│");
Console.WriteLine("    ├───────────────────┤                   ├───────────────────┤");
Console.WriteLine("    │ + Radius: double  │                   │ + Width: double   │");
Console.WriteLine("    ├───────────────────┤                   │ + Height: double  │");
Console.WriteLine("    │ + Circle(radius)  │                   ├───────────────────┤");
Console.WriteLine("    │ + CalculateArea() │                   │ + Rectangle(w, h) │");
Console.WriteLine("    │   → π × r²        │                   │ + CalculateArea() │");
Console.WriteLine("    │ + CalculatePerim()│                   │   → w × h         │");
Console.WriteLine("    │   → 2 × π × r     │                   │ + CalculatePerim()│");
Console.WriteLine("    │ + DisplayInfo()   │                   │   → 2 × (w + h)   │");
Console.WriteLine("    └───────────────────┘                   │ + DisplayInfo()   │");
Console.WriteLine("                                            └───────────────────┘");
Console.WriteLine();
Console.WriteLine("LEGEND:");
Console.WriteLine("⚡ = Abstract method (no implementation)");
Console.WriteLine("🔄 = Virtual method (has default implementation, can be overridden)");
Console.WriteLine("# = Protected (only accessible by derived classes)");
Console.WriteLine("+ = Public (accessible by everyone)");
Console.WriteLine();
Console.WriteLine("KEY ABSTRACTION CONCEPTS:");
Console.WriteLine("┌────────────────────────────────────────────────────────────┐");
Console.WriteLine("│ 1. HIDING COMPLEXITY: Users don't see formulas            │");
Console.WriteLine("│ 2. COMMON INTERFACE: All shapes have same methods         │");
Console.WriteLine("│ 3. POLYMORPHISM: Different shapes, same treatment         │");
Console.WriteLine("│ 4. EXTENSIBILITY: Easy to add Triangle, Pentagon, etc.    │");
Console.WriteLine("└────────────────────────────────────────────────────────────┘");
Console.WriteLine();
Console.WriteLine("\n════════════════════════════════════════════════════════════\n");

Console.WriteLine("OOP Abstraction Example - Running Code");
Console.WriteLine("======================================\n");

// ABSTRACTION IN ACTION #1: Polymorphism
// We declare the variable as Shape (abstract type), not Circle
// This shows we're working with the abstraction, not the concrete implementation
// The actual object is a Circle, but we interact with it through the Shape interface
Shape circle = new Circle(5);
circle.DisplayInfo();  // Calls Circle's version of DisplayInfo
Console.WriteLine();

// ABSTRACTION IN ACTION #2: Same Interface, Different Implementation
// Rectangle has completely different properties and calculations than Circle
// But we interact with it the same way - through the Shape abstraction
Shape rectangle = new Rectangle(10, 20);
rectangle.DisplayInfo();  // Calls Rectangle's version of DisplayInfo
Console.WriteLine();

// ABSTRACTION IN ACTION #3: Collections and Polymorphism
// We can store different types of shapes in the same collection
// because they all inherit from Shape (Liskov Substitution Principle)
List<Shape> shapes = new List<Shape>
{
    new Circle(3),
    new Rectangle(4, 6),
    new Circle(7),
    new Rectangle(5, 5)  // Square is just a special rectangle
};

// ABSTRACTION IN ACTION #4: Uniform Treatment
// We don't need to know what type of shape we're dealing with
// We just know that all shapes can calculate area and perimeter
Console.WriteLine("Processing multiple shapes:");
Console.WriteLine("===========================");
foreach (var shape in shapes)
{
    // This loop demonstrates the power of abstraction:
    // - We don't use if/else or switch to check shape types
    // - We don't need to know the formulas for each shape
    // - We just call the methods defined in the abstract base class
    // - Each shape "knows" how to calculate its own area/perimeter
    Console.WriteLine($"\n{shape.Name}: Area = {shape.CalculateArea():F2}, Perimeter = {shape.CalculatePerimeter():F2}");
}

// BENEFITS OF THIS ABSTRACTION:
// 1. Extensibility: We can add new shapes (Triangle, Pentagon, etc.) without changing this code
// 2. Maintainability: Changes to how a shape calculates area don't affect other code
// 3. Simplicity: Users of shapes don't need to understand mathematical formulas
// 4. Consistency: All shapes follow the same interface pattern

Console.WriteLine("\n\nABSTRACTION IN ACTION - RUNTIME VISUALIZATION:");
Console.WriteLine("==============================================");
Console.WriteLine();
Console.WriteLine("When we call shape.CalculateArea(), here's what happens:");
Console.WriteLine();
Console.WriteLine("┌─────────────────────────────────────────────────────────┐");
Console.WriteLine("│                     YOUR CODE                           │");
Console.WriteLine("│                                                         │");
Console.WriteLine("│    Shape myShape = new Circle(5);                      │");
Console.WriteLine("│    double area = myShape.CalculateArea();              │");
Console.WriteLine("│             ↓                                           │");
Console.WriteLine("│    ┌───────────────────┐                               │");
Console.WriteLine("│    │ ABSTRACTION LAYER │                               │");
Console.WriteLine("│    │ \"I need the area\" │                               │");
Console.WriteLine("│    └─────────┬─────────┘                               │");
Console.WriteLine("└──────────────┼─────────────────────────────────────────┘");
Console.WriteLine("               ↓");
Console.WriteLine("    ┌──────────┴──────────┐");
Console.WriteLine("    │ Runtime Polymorphism│");
Console.WriteLine("    │ \"What type is it?\"  │");
Console.WriteLine("    └──────────┬──────────┘");
Console.WriteLine("               ↓");
Console.WriteLine("    ┌──────────────────────┐");
Console.WriteLine("    │ It's a Circle!       │");
Console.WriteLine("    │ Call Circle's method │");
Console.WriteLine("    └──────────┬───────────┘");
Console.WriteLine("               ↓");
Console.WriteLine("    ┌──────────────────────┐");
Console.WriteLine("    │ return π × 5 × 5     │");
Console.WriteLine("    │ = 78.54              │");
Console.WriteLine("    └──────────────────────┘");
Console.WriteLine();
Console.WriteLine("The beauty: Your code doesn't need to know it's a Circle!");
Console.WriteLine("It just knows it's a Shape that can calculate area.");
