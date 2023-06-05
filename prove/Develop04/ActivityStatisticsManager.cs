using System;
using System.Collections.Generic;
using System.IO;

public class ActivityStatisticsManager
{
    private List<Activity> _activities;

    public ActivityStatisticsManager()
    {
        _activities = new List<Activity>();
    }

    public void AddActivity(Activity activity)
    {
        if (!_activities.Contains(activity))
        {
            _activities.Add(activity);
        }
    }

    public void SaveActivityStatistics()
    {
        Console.Write("Enter filename: ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            Dictionary<string, int> activityStatistics = CalculateActivityStatistics();

            foreach (KeyValuePair<string, int> entry in activityStatistics)
            {
                writer.WriteLine($"{entry.Key}| {entry.Value}");
            }
        }

        Console.WriteLine("Activity statistics saved successfully.");
        Console.WriteLine("Press any key to return to menu...");
        Console.ReadKey();
    }

    public void LoadActivityStatistics()
    {
        Console.Write("Enter filename: ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine($"File '{filename}' does not exist.");
            return;
        }

        _activities.Clear();

        using (StreamReader reader = new StreamReader(filename))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split("|");
                if (parts.Length == 2)
                {
                    string name = parts[0].Trim();
                    string durationString = parts[1].Trim();
                    if (int.TryParse(durationString, out int duration))
                    {
                        Activity activity = new Activity(name, "", duration);
                        AddActivity(activity);
                    }
                }
            }
        }

        Console.Clear();
        Console.WriteLine("Activity statistics loaded successfully.");
        Console.WriteLine();
        DisplayActivityStatistics();
        Console.WriteLine();
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }

    public void DisplayActivityStatistics()
    {
        if (_activities.Count == 0)
        {
            Console.WriteLine("No activity statistics available.");
            return;
        }

        Dictionary<string, int> activityStatistics = CalculateActivityStatistics();

        Console.WriteLine("Activity Statistics:");
        foreach (KeyValuePair<string, int> entry in activityStatistics)
        {
            Console.WriteLine($"{entry.Key}: {entry.Value} seconds");
        }
    }

    private Dictionary<string, int> CalculateActivityStatistics()
    {
        Dictionary<string, int> activityStatistics = new Dictionary<string, int>();

        foreach (Activity activity in _activities)
        {
            string activityName = activity.GetName();
            int duration = activity.GetDuration();

            if (activityStatistics.ContainsKey(activityName))
            {
                activityStatistics[activityName] += duration;
            }
            else
            {
                activityStatistics.Add(activityName, duration);
            }
        }

        return activityStatistics;
    }
}
