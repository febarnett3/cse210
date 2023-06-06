using System;
using System.Collections.Generic;
using System.Threading;

public class AnimationHelper
{
    // Attributes

    private List<string> _animationStrings;

    // Constructors
    
    public AnimationHelper()
    {
        // Initialize aniimation strings list for spinner.
        _animationStrings = new List<string>()
        {
            "|", "/", "-", "\\"
        };
    }

    // Behaviors

    // Spinner animation
    public void PauseWithSpinner(int numSeconds)
    {
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

    // Countdown animation.
    public void PauseWithCountdown(int numSeconds)
    {
        for (int i = numSeconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    // Get ready animation with spinner.
    public void LoadGetReady()
    {
        Console.Clear();
        Console.WriteLine("Get Ready... ");
        PauseWithSpinner(5);
    }

    // Begin in: with countdown.
    public void BeginInCountdown()
    {
        Console.Write("You may begin in: ");
        PauseWithCountdown(5);
        Console.Write("\n");
    }

    // Prompts user to enter key to return to menu.
    public void ReturnToMenu()
    {
        Console.WriteLine("Press any key to return to menu...");
        Console.ReadKey();
    }
}
