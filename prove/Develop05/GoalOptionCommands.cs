// This file contains all the Goal Option Command classes. (4 classes)
using System;

public class SimpleGoalCommand : Command
{
    // Constructors
    public SimpleGoalCommand(GoalsManager goalsManager) : base(goalsManager)
    {
    }

    // Overridden Behaviors
    public override void Execute()
    {
        SimpleGoal simpleGoal = new SimpleGoal("","");
        Console.Clear();               
        Console.WriteLine("Okay! Let's create a simple goal!");
        simpleGoal.InquiryGoalDetails();
        GoalsManager.AddGoal(simpleGoal);
    }
}

public class EternalGoalCommand : Command
{
    // Constructors
    public EternalGoalCommand(GoalsManager goalsManager) : base(goalsManager)
    {
    }

    // Overridden Behaviors
    public override void Execute()
    {
        EternalGoal eternalGoal = new EternalGoal("","");
        Console.Clear();
        Console.WriteLine("Okay! Let's create an eternal goal!");
        eternalGoal.InquiryGoalDetails();
        GoalsManager.AddGoal(eternalGoal);
    }
}

public class ChecklistGoalCommand : Command
{
    // Constructors
    public ChecklistGoalCommand(GoalsManager goalsManager) : base(goalsManager)
    {
    }

    // Overridden Behaviors
    public override void Execute()
    {
        ChecklistGoal checklistGoal = new ChecklistGoal("","");
        Console.Clear();
        Console.WriteLine("Okay! Let's create a checklist goal!");
        checklistGoal.InquiryGoalDetails();
        GoalsManager.AddGoal(checklistGoal);
    }
}

public class CancelCommand : Command
{
    // Constructors
    public CancelCommand(GoalsManager goalsManager) : base(goalsManager)
    {
    }

    // Overridden Behaviors
    public override void Execute()
    {
        // No additional code needed for cancellation
    }
}
