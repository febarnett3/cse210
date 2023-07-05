public class Running : Activity
{
    // Attributes
    private double _distance;

    // Constructor
    public Running(string date, double length, double distance) : base(date, length)
    {
        _distance = distance;
    }
    
    // Overridden Behaviors
    public override double CalculateDistance()
    {
        return _distance;
    }
    public override double CalculateSpeed()
    {
        return (_distance / GetLength()) * 60;
    }
    public override double CalculatePace()
    {
        return GetLength() / _distance;
    }
}