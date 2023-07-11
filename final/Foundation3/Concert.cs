using System;

public class Concert : Event
{
    // Attributes
    private string _artist;

    // Constructor
    public Concert(string title, string description, string date, string time, string address, string artist) 
        : base(title, description, date, time, address)
    {
        _artist = artist;
    }

    // Behaviors
    public override void ShowFullDetails()
    {
        base.ShowStandardDetails();
        Console.WriteLine($"{_artist} Concert");
    }
}