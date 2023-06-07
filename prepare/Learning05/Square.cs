public class Square : Shape
{
    // Attribute
    private int _side;

    // Constructor
    public Square(int side, string color) : base(color)
    {
        _side = side;
    }

    // Behavior
    public override double GetArea()
    {
        return _side*_side;
    }
}