using System;

class Program
{
    static void Main(string[] args)
    {
        GoalsManager goalsManager = new GoalsManager();
        while (true)
        {
            Console.Clear(); // Clears console

            Console.WriteLine("Welcome to the goal tracker program!");
            goalsManager.DisplayTotalPoints();
            Console.WriteLine("Menu Options: ");
            DisplayMenu(); // Displays the menu

            Console.Write("What would you like to do? ");
            string choice = Console.ReadLine(); // Asks for input

            switch (choice)
            {
                case "1":
                    CreateNewGoal(goalsManager);
                    break;
                case "2":
                    goalsManager.DisplayGoals();
                    break;
                case "3":
                    goalsManager.SaveGoals();
                    break;
                case "4":
                    goalsManager.LoadGoals();
                    break;
                case "5":
                    RecordEvent(goalsManager);
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
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Quit");
    }

    static void DisplayGoalTypes()
    {
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine("4. Cancel");

    }

    static void CreateNewGoal(GoalsManager goalsManager)
    {
        Console.Clear();
        Console.WriteLine("Okay! Let's create a new goal!");
        Console.WriteLine("The types of goals are: ");
        DisplayGoalTypes();
        Console.Write("Which type of goal would you like to create? ");
        string goalType = Console.ReadLine(); // gets the goal type the user wants to create.

        switch (goalType)
        {
            case "1":
                SimpleGoal simpleGoal = new SimpleGoal("","");
                Console.Clear();               
                Console.WriteLine("Okay! Let's create a simple goal!");
                simpleGoal.InquiryGoalDetails();
                goalsManager.AddGoal(simpleGoal);
                break;
            case "2":
                EternalGoal eternalGoal = new EternalGoal("","");
                Console.Clear();
                Console.WriteLine("Okay! Let's create an eternal goal!");
                eternalGoal.InquiryGoalDetails();
                goalsManager.AddGoal(eternalGoal);
                break;
            case "3":
                ChecklistGoal checklistGoal = new ChecklistGoal("","");
                Console.Clear();
                Console.WriteLine("Okay! Let's create a checklist goal!");
                checklistGoal.InquiryGoalDetails();
                goalsManager.AddGoal(checklistGoal);
                return;
            case "4":
                // User doesn't want to create a new goal.
                break;
            default:
                Console.WriteLine("Invalid option. Make sure you entered a valid option.");
                Console.WriteLine("Press any key to return to menu...");
                Console.ReadKey();
                break;
        }
    }

    static void RecordEvent(GoalsManager goalsManager)
    {
        goalsManager.CalculateRecordedEvent();
    }
}