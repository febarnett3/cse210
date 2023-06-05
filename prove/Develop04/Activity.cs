using System.Collections.Generic;
public class Activity

{
    // Attributes
    private string _activityName;
    private string _description;
    private int _duration;
    protected AnimationHelper _animationHelper;
    // Constructor
    public Activity(string activity, string description, int duration)
    {
        _activityName = activity;
        _description = description;
        _duration = duration;
        _animationHelper = new AnimationHelper();
    }
    // Getter
    // Returns the int duration the user entered in DisplayStartMessage().
    public int GetDuration()
    {
        return _duration;
    }
    public string GetName()
    {
        return _activityName;
    }
    // Behaviors
    // Displays the starting message for each activity.
    public void DisplayStartMessage()
    {
        Console.WriteLine($"Welcome to the {_activityName}");
        
        Console.WriteLine();

        Console.WriteLine($"{_description}");

        Console.WriteLine();

        _duration = GetValidDuration();
    }
    // Displays the ending message for each activity.
    public void DisplayEndMessage()
    {
        Console.WriteLine();
        Console.WriteLine($"Great job! You have completed another {_duration} seconds of the {_activityName}");
        _animationHelper.ReturningToMenu();
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

    public string ConvertToFileFormat()
    {
        return $"{_activityName}| {_duration}\n";
    }

    public void Hold(string name, int duration)
    {
        _activityName = name;
        _duration = duration;
    }
}