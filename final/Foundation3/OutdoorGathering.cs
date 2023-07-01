public class OutdoorGathering : Event
{
    // Attributes
    private string _type;
    private string _forecast;

    // Constructor
    public OutdoorGathering(string title, string description, string date, string time, string address, string forecast) 
        : base(title, description, date, time, address)
    {
        _type = "Reception";
        _forecast = forecast;
    }

    // Behaviors
    public override void ShowFullDetails()
    {
        Console.WriteLine("Full Details:");
        base.ShowStandardDetails();
        Console.WriteLine($"The weather is {_forecast}");
    }
    public override void ShowShortDescription()
    {
        Console.WriteLine($"{_type}: {GetTitle()} on {GetDate()}");
    }
}