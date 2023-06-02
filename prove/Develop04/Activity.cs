using System.Collections.Generic;
public class Activity : Animations

{
    // Attributes
    private Random _random;
    private string _activityName;
    private string _description;
    private int _duration;

    // Constructor
    public Activity(string activity, string description)
    {
        _random = new Random();
        _activityName = activity;
        _description = description;
    }

    //Getter
    // Returns the int duration the user entered in DisplayStartMessage().
    public int GetDuration()
    {
        return _duration;
    }

    // Behaviors
    // Displays the starting message for each activity.
    public void DisplayStartMessage()
    {
        Console.WriteLine($"Welcome to the {_activityName}");
        
        Console.WriteLine();

        Console.WriteLine($"{_description}");

        Console.WriteLine();

        Console.Write($"How long in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
    }

    // Displays the ending message for each activity.
    public void DisplayEndMessage()
    {
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_activityName}");
        Console.Write("Returning to menu in... ");
        PauseWithCountdown(5);
    }

    // Returns a random string from a list of strings.
    // This function is used in two activities.
    public string GetRandomItem(List<string> items)
     {
        // Defining a random index to select a prompt.
        int index = _random.Next(items.Count);
        // Returns the prompt of the specified random index.
        return items[index];
     }
    
    // Displays the string, prompt.
    // This function is used in two actvities.
    public void DisplayPrompt(string prompt)
    {
        Console.WriteLine($"--- {prompt} ---");
    }
    
}