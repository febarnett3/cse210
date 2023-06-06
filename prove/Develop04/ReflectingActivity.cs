using System.Collections.Generic;
using System;
public class ReflectingActivity : Activity 
{
    // Attributes

    private Random _random;
    private List <string> _prompts;
    private List <string> _questions;

    // Constructors

    public  ReflectingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        _random = new Random();

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

    public void RunActivity()
    {
        _animationHelper.LoadGetReady(); // Plays animation.

        Console.WriteLine("Consider the following prompt:");
        DisplayPrompt(GetRandomItem(_prompts)); // Selects random prompt and displays it.
        Console.WriteLine("When you have something in mind, press enter to continue.");

        // Listens for when user presses enter.
        // Also handles the exception if key pressed is not Enter.
        bool isEnterKey;
        do
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            isEnterKey = (keyInfo.Key == ConsoleKey.Enter);
            
            if (isEnterKey)
            {
                Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
                _animationHelper.BeginInCountdown(); // Plays animation.
                Console.Clear(); // Clears console for questions.

                int durationInSeconds = GetDuration(); // Duration of the while loop in seconds

                RunActivityLoop(() => ReflectExercise(), durationInSeconds); // Loops the exercise loop through activity loop template.
            }
        } while (!isEnterKey); // Will keep reading user keystroke until it is the enter key.
    }

    // Returns a random string from a list of strings.
    private string GetRandomItem(List<string> items)
     {
        // Defining a random index to select a prompt.
        int index = _random.Next(items.Count);
        // Returns the prompt of the specified random index.
        return items[index];
     }

    // Displays a question.
    private void DisplayQuestion(string question)
    {
        Console.Write($"> {question}");
    }
    
    // Displays a prompt.
    private void DisplayPrompt(string prompt)
    {
        Console.WriteLine($"--- {prompt} ---");
    }

    // The looped exercise for this activity.
    private void ReflectExercise()
    {
        DisplayQuestion(GetRandomItem(_questions)); //Selects random questions and displays it.
        _animationHelper.PauseWithSpinner(10); // Plays animation.
        Console.Write("\n"); // New line.
    }

}