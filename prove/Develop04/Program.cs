using System;

class Program
// Exceeds Requirements. Program has save and load features to record the time spent on each activity onto a file.
{
    static void Main(string[] args)
{
    ActivityStatisticsManager statisticsManager = new ActivityStatisticsManager();
    while (true)
    {
        Console.Clear(); // Clears console

        Console.WriteLine("Welcome to the Mindfulness Program!");
        DisplayMenu(); // Displays the menu

        Console.Write("What would you like to do? ");
        string choice = Console.ReadLine(); // Asks for input

        switch (choice)
        {
            case "1":
                StartBreathingActivity(statisticsManager);
                break;
            case "2":
                StartReflectingActivity(statisticsManager);
                break;
            case "3":
                StartListingActivity(statisticsManager);
                break;
            case "4":
                statisticsManager.SaveActivityStatistics();
                break;
            case "5":
                statisticsManager.LoadActivityStatistics();
                break;
            case "6":
                Console.WriteLine("Exiting Program. Goodbye!");
                return;
            default:
                Console.WriteLine("Invalid option. Please enter a valid option from the menu.");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                break;
        }
    }
}
            
    static void DisplayMenu()
    {
        Console.WriteLine("1. Start breathing activity");
        Console.WriteLine("2. Start reflecting activity");
        Console.WriteLine("3. Start listing activity");
        Console.WriteLine("4. Save statistics");
        Console.WriteLine("5. Load statistics");
        Console.WriteLine("6. Quit");
    }

    static void StartBreathingActivity(ActivityStatisticsManager statisticsManager)
    {
        Console.Clear();
        BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.",0);
        
        breathingActivity.DisplayStartMessage();
        breathingActivity.RunActivity();
        breathingActivity.DisplayEndMessage();

        statisticsManager.AddActivity(breathingActivity); // add activity instance to stat manager.
    }

    static void StartReflectingActivity(ActivityStatisticsManager statisticsManager)
    {
        Console.Clear();
        ReflectingActivity reflectingActivity = new ReflectingActivity("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.",0);
        
        reflectingActivity.DisplayStartMessage();
        reflectingActivity.RunActivity();
        reflectingActivity.DisplayEndMessage();

        statisticsManager.AddActivity(reflectingActivity); // add activity instance to stat manager.
    }

    static void StartListingActivity(ActivityStatisticsManager statisticsManager)
    {
        Console.Clear();
        ListingActivity listingActivity = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.",0);
        
        listingActivity.DisplayStartMessage();
        listingActivity.RunActivity();
        listingActivity.DisplayEndMessage();

        statisticsManager.AddActivity(listingActivity); // add activity instance to stat manager.
    }
}