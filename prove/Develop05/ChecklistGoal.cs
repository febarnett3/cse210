using System;
public class ChecklistGoal : Goal
{
    // Attributes
    private int _bonus;
    private int _bonusDenominator;
    private int _bonusNumerator;

    // Constructors
    public ChecklistGoal(string name, string description) : base(name, description)
    {
        _bonusDenominator = 0;
        _bonus = 0;
        _bonusNumerator = 0;
    }
    public ChecklistGoal(string name, string description, int goalPoints, int bonus, int numForBonus, int currentBonusNum) : base(name, description, goalPoints)
    {
        _bonusDenominator = numForBonus;
        _bonus = bonus;
        _bonusNumerator = currentBonusNum;
    }

    // Getters
    public int GetBonus()
    {
        return _bonus;
    }
    public int GetBonusNumerator()
    {
        return _bonusNumerator;
    }
    public int GetBonusDenominator()
    {
        return _bonusDenominator;
    }

    // Overridden Behaviors
    public override void InquiryGoalDetails()
    {
        base.InquiryGoalDetails();
        InquiryBonusDenominator();
        InquiryBonus();   
    }
    public override bool IsComplete()
    {
        if (_bonusNumerator >= _bonusDenominator)
        {
            int points = GetPoints();
            points += _bonus;
            return true;
        }
        else
        {
            return false;
        }
    }
    public override void RecordEvent()
    {
        Console.WriteLine($"Congragulations! You earned {GetPoints()} points!");
        _bonusNumerator ++;
    }
    public override void DisplayGoal()
    {
        Console.WriteLine($"{GetCheckBox()} {GetName()} ({GetDescription()}) -- Currently Completed: {GetBonusNumerator()}/{GetBonusDenominator()}");
    }
    public override string ConvertToFile()
    {
        return $"ChecklistGoal:{GetName()},{GetDescription()},{GetPoints()},{GetBonus()},{GetBonusDenominator()},{GetBonusNumerator()}";
    }

    // Private behaviors
    private void InquiryBonusDenominator()
    {
        _bonusDenominator = InquiryValidInteger("How many times does this goal need to be accomplished for a bonus? ");
    }
    private void InquiryBonus()
    {
        _bonus = InquiryValidInteger("What is the bonus for accomplishing it that many times? ");
    }

    // Unique Behaviors
    public void DisplayEarnedBonusPoints()
    {
        Console.WriteLine($"Congratulations! You earned an additional {GetBonus()} points!");
    }
}