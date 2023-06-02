public class BreathingActivity : Activity
{
    // Notice there are no attributes. None were needed. :)

    // Constructors
    public  BreathingActivity(string name, string description) : base(name, description)
    {
        // No additional logic or attributes needed
    }

    // Behaviors
    //Runs the activity
    public void RunActivity()
    {
        LoadGetReady(); // Plays animation

        int durationInSeconds = GetDuration(); // Duration of the while loop in seconds

        DateTime startTime = DateTime.Now; // Get the current time
        DateTime endTime = startTime.AddSeconds(durationInSeconds); // Calculate the end time

        // Continues for the length of the duration.
        while (DateTime.Now < endTime)
        {
            Console.WriteLine();
            BreatheIn();
            BreatheOut();
        }
    }

    // Prints and plays animation for breathing in.
    private void BreatheIn()
    {
        Console.Write("Breath in... ");
        PauseWithCountdown(4); // Animation
        Console.Write("\n"); // New line
    }

    // Prints and plays animation for breathing out.
    private void BreatheOut()
    {
        Console.Write("Now breath out... ");
        PauseWithCountdown(6); // Animation
        Console.Write("\n"); // New line
    }
}