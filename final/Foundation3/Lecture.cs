using System;

public class Lecture : Event
{
    // Attributes
    private string _speaker;
    private int _capacity;

    // Constructor
    public Lecture(string title, string description, string date, string time, string address, string speaker, int capacity) 
        : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    // Behaviors
    public override void ShowFullDetails()
    {
        base.ShowStandardDetails();
        Console.WriteLine($"{GetType()} given by {_speaker}");
        Console.WriteLine($"{_capacity} max guests");
    }
}