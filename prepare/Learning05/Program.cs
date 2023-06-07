using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");

        List<Shape> shapes = new List<Shape>();
        // You need to add the shapes to the list now.
        shapes.Add(new Square(2, "red"));
        shapes.Add(new Rectangle(3, 4, "blue"));
        shapes.Add(new Circle(5, "yellow"));

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }

    }
}