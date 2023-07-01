public class Lecture : Event
{
    // Attributes
    private string _type;
    private string _speaker;
    private int _capacity;

    // Constructor
    public Lecture(string title, string description, string date, string time, string address, string speaker, int capacity) 
        : base(title, description, date, time, address)
    {
        _type = "Lecture";
        _speaker = speaker;
        _capacity = capacity;
    }

    // Behaviors
    public override void ShowFullDetails()
    {
        Console.WriteLine("Full Details:");
        base.ShowStandardDetails();
        Console.WriteLine($"{_type} given by {_speaker}");
        Console.WriteLine($"{_capacity} max guests");
    }
    public override void ShowShortDescription()
    {
        Console.WriteLine($"{_type}: {GetTitle()} on {GetDate()}");
    }
}