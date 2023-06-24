using System;
using System.Collections.Generic;

// Exceeds Requirements. 
// Implemented the "Command Pattern" into my menu systems. 
// Main menu also displays number of events recorded.
// Number of Events can be saved and loaded on a text file.

class Program
{
    static void Main(string[] args)
    {
        GoalsManager goalsManager = new GoalsManager();

        Dictionary<string, Command> commands = new Dictionary<string, Command>
            {
                { "1", new CreateNewGoalCommand(goalsManager) },
                { "2", new ListGoalsCommand(goalsManager) },
                { "3", new SaveGoalsCommand(goalsManager) },
                { "4", new LoadGoalsCommand(goalsManager) },
                { "5", new RecordEventCommand(goalsManager) },
                { "6", new QuitCommand(goalsManager) }
            };

        while (true)
        {
            Console.Clear();
            goalsManager.DisplayTotalPoints();
            goalsManager.DisplayNumRecordedEvents();
            DisplayMenu();
            // Read the user input
            Console.Write("What would you like to do? ");
            string userCommand = Console.ReadLine();

            // Check if the command exists in the dictionary
            if (commands.ContainsKey(userCommand))
            {
                // Create an instance of the corresponding command class
                Command command = commands[userCommand];

                // Execute the command
                command.Execute();
            }
            else
            {
                Console.WriteLine("Invalid command!");
            }
        }

        // Short method
        static void DisplayMenu()
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
        }
    }
}