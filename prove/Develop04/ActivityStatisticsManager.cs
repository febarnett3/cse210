using System;
using System.Collections.Generic;
using System.IO;

public class ActivityStatisticsManager
{
    // Attributes
    private List<Activity> _activities; // List holds instances of activity

    // Constructor
    public ActivityStatisticsManager()
    {
        _activities = new List<Activity>();
    }

    // Behaviors

    // Adds an activity to the list.
    public void AddActivity(Activity activity)
    {
        // Adds activity to _activities
        if (!_activities.Contains(activity))
        {
            _activities.Add(activity);
        }
    }

    // Saves activity statistics to a file
    public void SaveActivityStatistics()
    {   
        Console.Clear();
        Console.WriteLine("Saving...");
        Console.Write("Enter the filename you want to save to: ");
        string filename = Console.ReadLine();

        // Use streamwrite to write _activities to a file.
        using (StreamWriter writer = new StreamWriter(filename))
        {
            // Defines dictionary to store the activity stats by calling function.
            Dictionary<string, int> activityStatistics = CalculateActivityStatistics();

            // Iterates for each valuepair in dict to write a line to the file.
            foreach (KeyValuePair<string, int> entry in activityStatistics)
            {
                writer.WriteLine($"{entry.Key}| {entry.Value}");
            }
        }

        // Console display for user to see.
        Console.WriteLine();
        Console.WriteLine("Activity statistics saved successfully.");
        Console.WriteLine("Press any key to return to menu...");
        Console.ReadKey();
    }

    // Function that loads a file of user's choice.
    public void LoadActivityStatistics()
    {
        Console.Clear();
        // Gets the file name from user.
        Console.Write("Enter filename you want to load: ");
        string filename = Console.ReadLine();

        // If file does not exist...
        if (!File.Exists(filename))
        {
            Console.WriteLine($"File '{filename}' does not exist.");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            return;
        }

        // Make sure _activities is empty before loading the file.
        _activities.Clear();

        using (StreamReader reader = new StreamReader(filename))
        {
            string line;
            // Runs so long as the line is not null in the file.
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split("|"); // Splits line in file with separator
                if (parts.Length == 2) // if the line is split into two parts like it should be...
                {
                    string name = parts[0].Trim(); // index 0 is name
                    string durationString = parts[1].Trim(); // index 1 is duration
                    // If duration can be turned into an integer...
                    if (int.TryParse(durationString, out int duration))
                    {
                        // Create an instance of activity to then add to list.
                        Activity activity = new Activity(name, "", duration);
                        AddActivity(activity);
                    }
                }
            }
        }


        // What displays on the console to user when file is loaded.
        Console.Clear();
        Console.WriteLine("Activity statistics loaded successfully.");
        Console.WriteLine();
        DisplayActivityStatistics();
        Console.WriteLine();
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }

    // Displays the Activity Statistics.
    public void DisplayActivityStatistics()
    {
        // What to display if there is nothing in _activities.
        if (_activities.Count == 0)
        {
            Console.WriteLine("No activity statistics available.");
            return;
        }

        // Defines a dictionary and calls the function to create the contents of the dictionary.
        Dictionary<string, int> activityStatistics = CalculateActivityStatistics();

        // Iterate through each item in dictionary to display
        Console.WriteLine("Activity Statistics:");
        foreach (KeyValuePair<string, int> entry in activityStatistics)
        {
            Console.WriteLine($"{entry.Key}: {entry.Value} seconds");
        }
    }

    private Dictionary<string, int> CalculateActivityStatistics()
    {
        // Creates a dictionary "activityStatistics," has values string and int for name and duration
        Dictionary<string, int> activityStatistics = new Dictionary<string, int>();

        // Adding activities to the dictionary
        foreach (Activity activity in _activities)
        {   // Getting attributes to add to dict
            string activityName = activity.GetName();
            int duration = activity.GetDuration();

            // If the activity name is already in the dictionary...
            if (activityStatistics.ContainsKey(activityName))
            {   
                //Combine the two together by keeping same name and adding durations
                activityStatistics[activityName] += duration;
            }
            else
            {
                // Create a new instance in the dictionary with the name and duration.
                activityStatistics.Add(activityName, duration);
            }
        }
        return activityStatistics;
    }
}
