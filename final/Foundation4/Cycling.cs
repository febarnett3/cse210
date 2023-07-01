public class Cycling : Activity
{
    private double _distance;

    public Cycling(string date, double length, double distance) : base(date, length)
    {
        _distance = distance;
    }

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