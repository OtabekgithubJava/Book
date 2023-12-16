using System;


public class ShapesRunner {
    public static void Run() {
        Circle circle = new Circle(5, 0, 0);
        Console.WriteLine($"Circle Area: {circle.CalculateArea()}");
        Console.WriteLine($"Circle Perimeter: {circle.CalculatePerimeter()}");

        Rectangular rectangular = new Rectangular(4, 6, 0, 0);
        Console.WriteLine($"Rectangular Area: {rectangular.CalculateArea()}");
        Console.WriteLine($"Rectangular Perimeter: {rectangular.CalculatePerimeter()}");

        Triangle triangle = new Triangle(3, 4, 5, 0, 0);
        Console.WriteLine($"Triangle Area: {triangle.CalculateArea()}");
        Console.WriteLine($"Triangle Perimeter: {triangle.CalculatePerimeter()}");
    }
}
