public class SimpleGoal : Goal
{
    // Attributes
    bool _isComplete;
    public SimpleGoal(string name, string description) : base(name, description)
    {
    }
    public SimpleGoal(string name, string description, int goalPoints, bool isComplete) : base(name, description, goalPoints)
    {
        _isComplete = isComplete;
    }

// Overridden Behaviors
public override void RecordEvent()
    {
        _isComplete = true;
        Console.WriteLine($"Congratulations! You earned {GetPoints()} points!");
    }
    public override string ConvertToFile()
    {
        return $"SimpleGoal:{GetName()},{GetDescription()},{GetPoints()},{IsComplete()}";
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }
}