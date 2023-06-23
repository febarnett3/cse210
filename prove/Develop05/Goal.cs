using System;
public class Goal
{
    // Attributes
    private string _name;
    private string _description;
    private int _goalPoints;

    // Constructor
    public Goal(string name, string description)
    {
        _name = name;
        _description = description;
    }
    public Goal(string name, string description, int goalPoints)
    {
        _name = name;
        _description = description;
        _goalPoints = goalPoints;
    }

    //Getters
    public string GetName()
    {
        return _name;
    }
    public string GetDescription()
    {
        return _description;
    }
    public int GetPoints()
    {
        return _goalPoints;
    }

    // Virtual Behaviors
    public virtual void RecordEvent()
    {
        // No default code necessary.
    }
    public virtual bool IsComplete()
    {
        return false;
    }
    public virtual void InquiryGoalDetails()
    {
        InquiryGoalName();
        InquiryGoalDescription();
        InquiryGoalPoints();
    }
    public virtual void DisplayGoal()
    {
        Console.WriteLine($"{GetCheckBox()} {_name} ({_description})");
    }
    public virtual string ConvertToFile()
    {
        return $"Did not properly convert";
    }

    // Private Behaviors
    private void InquiryGoalName()
    {
        Console.Write("What is the name of your goal? ");
        _name = Console.ReadLine();
    }

    private void InquiryGoalDescription()
    {
        Console.Write("What is a short description of it? ");
        _description = Console.ReadLine();
    }
    private void InquiryGoalPoints()
    {
        _goalPoints = InquiryValidInteger("What is the amount of points associated with this goal? ");
    }

    // Unique Behaviors
    public string GetCheckBox()
    {
        if (IsComplete())
        {
            return "[X]";
        }
        else
        {
            return "[ ]";
        }
    }
    public int InquiryValidInteger(string prompt)
    {
        Console.Write(prompt);

        while (true)
        {
            string input = Console.ReadLine();

            if (int.TryParse(input, out int number))
            {
                // The user input is a valid integer
                return number;
            }
            else
            {
                Console.WriteLine($"'{input}' is not an integer. Please try again.");
                Console.Write(prompt);
            }
        }
    }
}