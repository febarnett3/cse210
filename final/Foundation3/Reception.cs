using System;

public class Reception : Event
{
    // Attributes
    private string _rsvpEmail;

    // Constructor
    public Reception(string title, string description, string date, string time, string address, string rsvpEmail) 
        : base(title, description, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
    }

    // Behaviors
    public override void ShowFullDetails()
    {
        base.ShowStandardDetails();
        Console.WriteLine($"RSVP {_rsvpEmail} before");
    }
}