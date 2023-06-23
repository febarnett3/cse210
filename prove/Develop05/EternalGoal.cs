using System;

public class EternalGoal : Goal
{
    // Constructors
    public EternalGoal(string name, string description) : base(name, description)
    {
        
    }
    public EternalGoal(string name, string description, int goalPoints) : base(name, description, goalPoints)
    {
        
    }

    // Overridden Behaviors
    public override bool IsComplete()
    {
        return false;
    }
    public override void RecordEvent()
    {
        Console.WriteLine($"Congratulations! You earned {GetPoints()} points!");
    }
    public override string ConvertToFile()
    {
        return $"EternalGoal:{GetName()},{GetDescription()},{GetPoints()}";
    }
}