public class Skiing : Activity
{
    // Attributes
    private double _speed;

    // Constructor
    public Skiing(string date, double length, double speed) : base(date, length)
    {
        _speed = speed;
    }

    // Overridden Behaviors
    public override double CalculateDistance()
    {
        return _speed*(GetLength()/60);
    }
    public override double CalculateSpeed()
    {
        return _speed;
    }
    public override double CalculatePace()
    {
        return 60 / _speed;
    }
}