public class Swimming : Activity
{
    // Attributes
    private int _numLaps;

    // Constructor
    public Swimming(string date, double length, int numLaps) : base(date, length)
    {
        _numLaps = numLaps;
    }

    // Overridden Behaviors
    public override double CalculateDistance()
    {
        double lapDistanceMeters = 50;
        double distanceKilometers = _numLaps * lapDistanceMeters / 1000;
        return distanceKilometers * 0.621371; // Convert kilometers to miles
    }
    public override double CalculateSpeed()
    {
        return (CalculateDistance() / GetLength()) * 60;
    }
    public override double CalculatePace()
    {
        return GetLength() / CalculateDistance();
    }
}