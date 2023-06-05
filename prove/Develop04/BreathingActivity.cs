public class BreathingActivity : Activity
{
    // Notice there are no attributes. None were needed. :)

    // Constructors
    public  BreathingActivity(string name, string description, int duration) 
        : base(name, description, duration)
    {
        // No additional logic or attributes needed
    }

    // Behaviors
    //Runs the activity
    public void RunActivity()
    {
        _animationHelper.LoadGetReady(); // Plays animation

        int durationInSeconds = GetDuration(); // Duration of the while loop in seconds

        RunActivityLoop(() =>
        {
            Console.WriteLine();
            BreatheIn();
            BreatheOut();

        }, durationInSeconds);
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