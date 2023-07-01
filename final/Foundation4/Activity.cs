public abstract class Activity
{
    private string _date;
    private double _length;

    public Activity(string date, double length)
    {
        _date = date;
        _length = length;
    }

    public string GetDate()
    {
        return _date;
    }

    public double GetLength()
    {
        return _length;
    }

    public abstract double CalculateDistance();
    public abstract double CalculateSpeed();
    public abstract double CalculatePace();

    public void DisplaySummary()
    {
        Console.WriteLine($"{GetDate()} {GetType().Name} ({GetLength()} min): Distance {CalculateDistance()} miles, Speed {CalculateSpeed()} mph, Pace: {CalculatePace()} min per mile");
    }
}