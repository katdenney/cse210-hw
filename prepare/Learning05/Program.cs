using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning 05 Shapes World!");
        Square square1 = new Square ("yellow",7);
        Console.WriteLine(square1.GetArea());
        Rectangle rectangle1 = new Rectangle ("yellow",4,7);
        Console.WriteLine(rectangle1.GetArea());
        Circle circle1 = new Circle ("orange",5);
        Console.WriteLine(circle1.GetArea());

        List<Shapes> shapes = new List<Shapes>();
        shapes.Add(circle1);
        shapes.Add(rectangle1);
        shapes.Add(square1);
        foreach (Shapes shape in shapes)
        {
            Console.WriteLine($"{shape}");
            Console.WriteLine($"{shape.GetArea()}");
        }
        foreach (Shapes shape in shapes)
        {
            Console.WriteLine($"{shape}");
            Console.WriteLine($"The {shape} is {shape.GetColor()} and the area is {shape.GetArea()}");
        }

        
    }
}