public abstract class Shape
{
    // Attributes
    private string _color;

    // Constructor
    public Shape(string color)
    {
        _color = color;
    }

    // Getters & Setters
    public string GetColor()
    {
        return _color;
    }

    // Behaviors
    public abstract double GetArea();
}