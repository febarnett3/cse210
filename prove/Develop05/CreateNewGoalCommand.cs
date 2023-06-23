using System;
using System.Collections.Generic;

public class CreateNewGoalCommand : Command
{
    // Attributes
    private Dictionary<string, Command> _subMenuCommands;

    // Constructor
    public CreateNewGoalCommand(GoalsManager goalsManager) : base(goalsManager)
    {
        _subMenuCommands = new Dictionary<string, Command>
        {
            { "1", new SimpleGoalCommand(goalsManager) },
            { "2", new EternalGoalCommand(goalsManager) },
            { "3", new ChecklistGoalCommand(goalsManager) },
            { "4", new CancelCommand(goalsManager) },
        };
    }

    // Overridden Behaviors
    public override void Execute()
    {
        while (true)
        {
            DisplayGoalTypes();
            string subMenuInput = Console.ReadLine();

            if (_subMenuCommands.ContainsKey(subMenuInput))
            {
                Command subMenuCommand = _subMenuCommands[subMenuInput];
                subMenuCommand.Execute();

                if (subMenuCommand is CancelCommand)
                {
                    break; // Exit the loop if CancelCommand is executed
                }
            }
            else
            {
                Console.WriteLine("Invalid option! Press any key to continue.");
                Console.ReadKey();
            }
        }
    }

    // Private Behaviors
    private void DisplayGoalTypes()
    {
        Console.Clear();
        Console.WriteLine("Goal Options:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine("4. Cancel");
    }
}
