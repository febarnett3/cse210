using System;
public class Circle : Shape
{
    // Attribute
    private int _radius;

    // Constructor
    public Circle(int radius, string color) : base(color)
    {
        _radius = radius;
    }

    // Behavior
    public override double GetArea()
    {
        return (Math.Pow(_radius, 2)) * (Math.PI);
    }
}