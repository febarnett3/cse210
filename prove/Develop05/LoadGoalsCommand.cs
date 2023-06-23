public class LoadGoalsCommand : Command
{
    // Constructors
    public LoadGoalsCommand(GoalsManager goalsManager) : base(goalsManager)
    {
    }

    // Overridden Behaviors
    public override void Execute()
    {
        goalsManager.LoadGoals();
    }
}