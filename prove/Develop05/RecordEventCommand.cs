public class RecordEventCommand : Command
{
    // Constructors
     public RecordEventCommand(GoalsManager goalsManager) : base(goalsManager)
    {
    }

    // Overridden Behaviors
    public override void Execute()
    {
        goalsManager.CalculateRecordedEvent();
    }
}