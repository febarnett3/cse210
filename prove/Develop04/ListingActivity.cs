public class ListingActivity : Activity 
{
    // Attributes
    private Random _random;
    private List <string> _prompts;

    // Constructors
    public  ListingActivity(string name, string description) : base(name, description)
    {
        // Intialize random
        _random = new Random();

        // Initialize the prompts.
        _prompts = new List<string>()
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"                    
        };
    }

    // Behaviors   
    // Runs the activity.
    public void RunActivity()
    {
        _animationHelper.LoadGetReady(); // Plays animation.

        Console.WriteLine("List as many responses you can to the following prompt:");
        DisplayPrompt(GetRandomItem(_prompts)); //Selects random prompt and displays it.

        _animationHelper.BeginInCountdown(); // Plays animation.

        int durationInSeconds = GetDuration(); // Duration of the while loop in seconds

        RunActivityLoop(() =>
        {
            Console.Write("> ");
            string userInput = Console.ReadLine(); // Gets user input.

        }, durationInSeconds);
        
    }

    // Returns a random string from a list of strings.
    public string GetRandomItem(List<string> items)
     {
        // Defining a random index to select a prompt.
        int index = _random.Next(items.Count);
        // Returns the prompt of the specified random index.
        return items[index];
     }
    
    // Displays the string, prompt.
    public void DisplayPrompt(string prompt)
    {
        Console.WriteLine($"--- {prompt} ---");
    }
    
}