using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

public class GoalsManager
{
    // Attributes
    private List<Goal> _goals;
    private int _totalPoints;

    // Constructors
    public GoalsManager()
    {
        _goals = new List<Goal>();
        _totalPoints = 0;
    }

    // Unique Behaviors
    public void AddGoal(Goal goal)
    {
        // Adds activity to _activities
        if (!_goals.Contains(goal))
        {
            _goals.Add(goal);
        }
    }
    public void DisplayGoals()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals available.");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            return;
        } 

        int index = 1;
        Console.Clear();
        Console.WriteLine("The goals are: ");
        foreach (Goal goal in _goals)
        {
            Console.Write($"{index}. ");
            goal.DisplayGoal();
            index ++;
        }
        Console.WriteLine();
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }
    public void CalculateRecordedEvent()
    {
        List<Goal> incompleteGoals = FilterIncompleteGoals();
        if (incompleteGoals.Count == 0)
        {
            Console.WriteLine("No incomplete goals available.");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            return;
        }
        DisplayIncompleteGoals(incompleteGoals);
        int selectedIndex = GetValidGoalIndex("Which goal did you accomplish? ", incompleteGoals)-1;
        Goal selectedGoal = incompleteGoals[selectedIndex];
        selectedGoal.RecordEvent();
        selectedGoal.IsComplete();
        if (selectedGoal is ChecklistGoal checklistGoal)
        {
            if (checklistGoal.GetBonusNumerator() == checklistGoal.GetBonusDenominator())
            {
                checklistGoal.DisplayEarnedBonusPoints();
            }
        }
        int earnedPoints = selectedGoal.GetPoints();
        _totalPoints += earnedPoints;
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }
    public void DisplayTotalPoints()
    {
        Console.WriteLine($"You have {_totalPoints} points.");
    }
    public int GetValidGoalIndex(string prompt, List<Goal> list)
    {
        while (true)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();

            if (int.TryParse(input, out int number))
            {
                // The user input is a valid integer
                if (number <= list.Count())
                {
                    return number;
                }
            }
            else
            {
                Console.WriteLine($"'{input}' is not a valid integer. Please try again.");
                Console.Write(prompt);
            }
        }
    }
    public void SaveGoals()
    {
        Console.Clear();
        Console.WriteLine("Saving...");
        string filename = GetFileName();
        UpdateFile(filename);
    }
    public void LoadGoals()
    {
        Console.Clear();
        Console.WriteLine("Loading...");
        string filename = GetFileName();

        if (!File.Exists(filename))
        {
            Console.WriteLine($"File '{filename}' does not exist.");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            return;
        }

        ConvertFileToGoals(filename);
        foreach (Goal goal in _goals)
        {
            goal.IsComplete();
        }

        Console.WriteLine();
        Console.WriteLine($"Contents of {filename}:");
        DisplayGoals();
    }

    // Private Behaviors
    private void DisplayIncompleteGoals(List<Goal> incompleteGoals)
    {
        int index = 1;
        Console.Clear();
        Console.WriteLine("Current incomplete goals: ");
        foreach (Goal goal in incompleteGoals)
        {
            if (!goal.IsComplete())
            {
                Console.WriteLine($"{index}. {goal.GetName()}");
                index ++;
            }
        }
    }
    private List<Goal> FilterIncompleteGoals()
    {
        List<Goal> incompleteGoals = new List<Goal>();
        foreach (Goal goal in _goals)
        {
            if(!goal.IsComplete())
            {
                incompleteGoals.Add(goal);
            }
        }
        return incompleteGoals;
    }
    private void UpdateFile(string filename)
    {
        File.WriteAllText(filename,string.Empty);

        using (StreamWriter w = File.AppendText(filename))
            {
                w.WriteLine(_totalPoints);

                foreach (Goal goal in _goals)
                {
                    w.WriteLine(goal.ConvertToFile());
                }
            }
    }
    private void ConvertFileToGoals(string filename)
    {
        _goals.Clear();

        string[] lines = File.ReadAllLines(filename);
        string line1 = lines[0].Trim();
        _totalPoints = Convert.ToInt32(line1);

        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i];
            string[] parts = line.Split(":");
            string goalType = parts[0].Trim();

            string goalInfo = parts[1].Trim();
            string[] goalParts = goalInfo.Split(',');

            string name = goalParts[0];
            string description = goalParts[1];
            int points = Convert.ToInt32(goalParts[2]);

            switch (goalType)
            {
                case "SimpleGoal":
                    bool isComplete = Convert.ToBoolean(goalParts[3]);
                    SimpleGoal simpleGoal = new SimpleGoal(name, description, points, isComplete);
                    AddGoal(simpleGoal);
                    break;

                case "EternalGoal":
                    EternalGoal eternalGoal = new EternalGoal(name, description, points);
                    AddGoal(eternalGoal);
                    break;

                case "ChecklistGoal":
                    int bonus = Convert.ToInt32(goalParts[3]);
                    int numForBonus = Convert.ToInt32(goalParts[4]);
                    int currentBonusNum = Convert.ToInt32(goalParts[5]);
                    ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, bonus, numForBonus, currentBonusNum);
                    AddGoal(checklistGoal);
                    break;
            }
        }
    }
    private string GetFileName()
    {
        Console.Write("Enter the filename: ");
        string filename = Console.ReadLine();
        return filename;
    }
}