using System.Collections.Generic;
using System;
public class Activity

{
    // Attributes
    private string _activityName;
    private string _description;
    private int _duration;
    protected AnimationHelper _animationHelper; // lets child classes use animations
    
    // Constructor
    public Activity(string activity, string description, int duration)
    {
        _activityName = activity;
        _description = description;
        _duration = duration;
        _animationHelper = new AnimationHelper();
    }

    // Getters
    public int GetDuration()
    {
        return _duration;
    }
    public string GetName()
    {
        return _activityName;
    }

    // Behaviors
    public void DisplayStartMessage()
    {
        Console.WriteLine($"Welcome to the {_activityName}");
        
        Console.WriteLine();

        Console.WriteLine($"{_description}");

        Console.WriteLine();

        _duration = GetValidDuration(); // gets duration from user. Ensures int value.
    }
    // Displays the ending message for each activity.
    public void DisplayEndMessage()
    {
        Console.WriteLine();
        Console.WriteLine($"Great job! You have completed another {_duration} seconds of the {_activityName}");
        _animationHelper.ReturnToMenu();
    }
    // Ensures that the duration is an integer.
    private int GetValidDuration()
    {
        int duration;
        bool isValidDuration;

        // This is a do while loop. Prompt will be displayed at least once.
        // This loop will break once the input is an integer.
        do
        {
            Console.Write("How long in seconds would you like for your session? ");
            isValidDuration = int.TryParse(Console.ReadLine(), out duration);

            // If parsing the user input fails...
            if (!isValidDuration)
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        } while (!isValidDuration);

        // Returns the user's integer.
        return duration;
    }

    // All activities loop/last while duration is less than end time.
    // Creates an instance of a loop for each activity to use in their RunActivity() behavior.
    protected void RunActivityLoop(Action loopAction, int durationInSeconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(durationInSeconds);

        while (DateTime.Now < endTime)
        {
            loopAction.Invoke();
        }
    }

    // Converts an instance of an activity into file format to save and load.
    public string ConvertToFileFormat()
    {
        return $"{_activityName}| {_duration}\n";
    }
}