using System.Collections.Generic;
using System;
public class ReflectingActivity : Activity 
{
    // Attributes
    private List <string> _prompts;
    private List <string> _questions;

    // Constructors
    public  ReflectingActivity(string name, string description) : base(name, description)
    {
        // Initialize the prompts.
        _prompts = new List<string>()
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."                    
        };
        // Intialize the questions.
        _questions = new List<string>()
        {
            "Why was this experience meaningful to you? ",
            "Have you ever done anything like this before? ",
            "How did you get started? ",
            "How did you feel when it was complete? ",
            "What made this time different than other times when you were not as successful? ",
            "What is your favorite thing about this experience? ",
            "What could you learn from this experience that applies to other situations? ",
            "What did you learn about yourself through this experience? ",
            "How can you keep this experience in mind in the future? "                    
        };

    }

    // Behaviors
    // Runs the activity.
    public void RunActivity()
    {
        LoadGetReady(); // Plays animation.

        Console.WriteLine("Consider the following prompt:");
        DisplayPrompt(GetRandomItem(_prompts)); //Selects random prompt and displays it.
        Console.WriteLine("When you have something in mind, press enter to continue.");

        // Listens for when user presses enter.
        ConsoleKeyInfo keyInfo = Console.ReadKey();
        if (keyInfo.Key == ConsoleKey.Enter)
        {
            Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
            BeginInCountdown(); // Plays animation.

            Console.Clear(); // Clears console for questions.

            int durationInSeconds = GetDuration(); // Duration of the while loop in seconds

            DateTime startTime = DateTime.Now; // Get the current time
            DateTime endTime = startTime.AddSeconds(durationInSeconds); // Calculate the end time

            // Continues for the length of the duration.
            while (DateTime.Now < endTime)
            {
                DisplayQuestion(GetRandomItem(_questions)); //Selects random questions and displays it.
                PauseWithSpinner(10); // Plays animation.
                Console.Write("\n"); // New line.
            }
        }
    }

    // Displays a question.
    // This behavior is unique to this acitivty only.
    public void DisplayQuestion(string question)
    {
        Console.Write($"> {question}");
    }

}