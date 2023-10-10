using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("Red", 4);
        Console.WriteLine($"Color: {square.GetColor()}");
        Console.WriteLine($"Area: {square.GetArea()}");
        Rectangle rectangle = new Rectangle("Blue", 5, 10);
        Console.WriteLine($"Color: {rectangle.GetColor()}");
        Console.WriteLine($"Area: {rectangle.GetArea()}");

        Circle circle = new Circle("Green", 3);
        Console.WriteLine($"Color: {circle.GetColor()}");
        Console.WriteLine($"Area: {circle.GetArea()}");

            List<Shape> shapes = new List<Shape>
            {
                new Square("Yellow", 6),
                new Rectangle("Purple", 4, 8),
                new Circle("Orange", 5)
            };

            foreach (var shape in shapes)
            {
                Console.WriteLine($"Color: {shape.GetColor()}");
                Console.WriteLine($"Area: {shape.GetArea()}");
            }

    }
}
