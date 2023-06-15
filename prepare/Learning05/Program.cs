/*using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");
    }
}*/

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Shape> shapes = new List<Shape>();

        // Create instances of different shapes
        Square square = new Square("Red", 5);
        Rectangle rectangle = new Rectangle("Blue", 4, 6);
        Circle circle = new Circle("Green", 3);

        // Add the shapes to the list
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        // Iterate through the list and display the color and area of each shape
        foreach (Shape shape in shapes)
        {
            Console.WriteLine("Color: " + shape.Color);
            Console.WriteLine("Area: " + shape.GetArea());
            Console.WriteLine();
        }

        Console.ReadLine();
    }
}
