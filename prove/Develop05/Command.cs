public abstract class Command
{
    protected GoalsManager GoalsManager;

    public Command(GoalsManager goalsManager)
    {
        this.GoalsManager = goalsManager;
    }

    public abstract void Execute();
}