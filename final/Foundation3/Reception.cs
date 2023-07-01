public class Reception : Event
{
    // Attributes
    private string _type;
    private string _rsvpEmail;

    // Constructor
    public Reception(string title, string description, string date, string time, string address, string rsvpEmail) 
        : base(title, description, date, time, address)
    {
        _type = "Reception";
        _rsvpEmail = rsvpEmail;
    }

    // Behaviors
    public override void ShowFullDetails()
    {
        Console.WriteLine("Full Details:");
        base.ShowStandardDetails();
        Console.WriteLine($"RSVP {_rsvpEmail} before");
    }
    public override void ShowShortDescription()
    {
        Console.WriteLine($"{_type}: {GetTitle()} on {GetDate()}");
    }
}