public class ListingActivity : Activity 
{
    // Attributes
    private List <string> _prompts;

    // Constructors
    public  ListingActivity(string name, string description) : base(name, description)
    {
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
        LoadGetReady(); // Plays animation.

        Console.WriteLine("List as many responses you can to the following prompt:");
        DisplayPrompt(GetRandomItem(_prompts)); //Selects random prompt and displays it.

        BeginInCountdown(); // Plays animation.

        int durationInSeconds = GetDuration(); // Duration of the while loop in seconds

        DateTime startTime = DateTime.Now; // Get the current time
        DateTime endTime = startTime.AddSeconds(durationInSeconds); // Calculate the end time

        // Continues for the length of the duration.
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string userInput = Console.ReadLine(); // Gets user input.
        }
    }
    
}