public abstract class Command
{
    protected GoalsManager goalsManager;

    public Command(GoalsManager goalsManager)
    {
        this.goalsManager = goalsManager;
    }

    public abstract void Execute();
}