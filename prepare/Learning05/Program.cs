using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        
        Square square = new Square("blue", 5);
        Rectangle rectangle = new Rectangle("red", 5.5, 12);
        Circle circle = new Circle("green", 6);
        
        /*Console.WriteLine(square.GetColor());
        Console.WriteLine(square.GetArea());
        Console.WriteLine(rectangle.GetColor());
        Console.WriteLine(rectangle.GetArea());
        Console.WriteLine(circle.GetColor());
        Console.WriteLine(circle.GetArea());
        Console.WriteLine();*/

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape item in shapes)
        {
            Console.WriteLine(item.GetColor());
            Console.WriteLine(item.GetArea());
        }

        Console.WriteLine();
    }
}