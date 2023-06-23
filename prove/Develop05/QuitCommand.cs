using System;

public class QuitCommand : Command
{
    // Constructor
    public QuitCommand(GoalsManager goalsManager) : base(goalsManager)
    {
    }

    // Overridden Behaviors
    public override void Execute()
    {
        Console.WriteLine("Exiting Program. Goodbye!");
        Environment.Exit(0);
    }
}