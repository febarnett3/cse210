public class SaveGoalsCommand : Command
{
    // Constructors
    public SaveGoalsCommand(GoalsManager goalsManager) : base(goalsManager)
    {
    }

    // Overridden Behaviors
    public override void Execute()
    {
        GoalsManager.SaveGoals();
    }
}