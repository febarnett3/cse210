public class Animations
{
    // This class holds all the animations.
    // Is parent class of Activity.

    //Spinner animation. Takes integer parameter for specified time it will last.
    public void PauseWithSpinner(int numSeconds)
    {
        List<string> _animationStrings = new List<string>()
                    {
                        "|","/","-","\\","|","/","-","\\"                    
                    };
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(numSeconds);

        int i = 0;
        
        while (DateTime.Now < endTime)
        {
            string s = _animationStrings[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;

            if (i >= _animationStrings.Count)
            {
                i = 0;
            }
        }

    }

    //Countdown animation. Takes integer parameter for specified time it will last.
    public void PauseWithCountdown(int numSeconds)
    {
        for (int i = numSeconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    // Loading animation. Clears whole screen and says "Get Ready..." with a spinner animation.
    public void LoadGetReady()
    {
        Console.Clear();
        Console.WriteLine("Get Ready... ");
        PauseWithSpinner(5);
    }

    // Countdown animation that says "You may begin in: " with a countdown animation.
    public void BeginInCountdown()
    {
        Console.Write("You may begin in: ");
        PauseWithCountdown(5);
        Console.Write("\n");
    }
}