public class ListGoalsCommand : Command
{
    // Constructor
    public ListGoalsCommand(GoalsManager goalsManager) : base(goalsManager)
    {
    }
    // Overridden Behaviors
    public override void Execute()
    {
        goalsManager.DisplayGoals();
    }
}