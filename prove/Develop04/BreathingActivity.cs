public class BreathingActivity : Activity
{
    // No attributes necessary.

    // Constructor

    public  BreathingActivity(string name, string description, int duration) 
        : base(name, description, duration)
    {
        // No additional logic or attributes needed
    }

    // Behaviors

    public void RunActivity()
    {
        _animationHelper.LoadGetReady(); // Plays animation

        int durationInSeconds = GetDuration(); // Duration of the while loop in seconds

        RunActivityLoop(() => BreathExercise(), durationInSeconds); // Loops the exercise loop through activity loop template.
    }

    // The looped exercise for this activity.
    private void BreathExercise()
    {
        Console.WriteLine();
        BreatheIn();
        BreatheOut();
    }

    // Prints and plays animation for breathing in.
    private void BreatheIn()
    {
        Console.Write("Breath in... ");
        _animationHelper.PauseWithCountdown(4); // Animation
        Console.Write("\n"); // New line
    }

    // Prints and plays animation for breathing out.
    private void BreatheOut()
    {
        Console.Write("Now breath out... ");
        _animationHelper.PauseWithCountdown(6); // Animation
        Console.Write("\n"); // New line
    }
}