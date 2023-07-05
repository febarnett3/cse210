using System;

public abstract class Activity
{
    // Attributes
    private string _date;
    private double _length;

    // Constructors
    public Activity(string date, double length)
    {
        _date = date;
        _length = length;
    }

    // Getters
    public string GetDate()
    {
        return _date;
    }
    public double GetLength()
    {
        return _length;
    }

    // Abstract Behaviors
    public abstract double CalculateDistance();
    public abstract double CalculateSpeed();
    public abstract double CalculatePace();

    // Behaviors
    public void DisplaySummary()
    {
        Console.WriteLine($"{GetDate()} {GetType().Name} ({GetLength()} min): Distance {CalculateDistance()} miles, Speed {CalculateSpeed()} mph, Pace: {CalculatePace()} min per mile");
    }
}