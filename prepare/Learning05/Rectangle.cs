public class Rectangle : Shape
{
    // Attribute
    private int _length;
    private int _width;

    // Constructor
    public Rectangle(int length, int width, string color) : base(color)
    {
        _length = length;
        _width = width;
    }

    // Behavior
    public override double GetArea()
    {
        return _length*_width;
    }
}