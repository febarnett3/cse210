using System;
using System.Collections.Generic;

public class OutdoorGathering : Event
{
    // Attributes
    private string _forecast;

    // Constructor
    public OutdoorGathering(string title, string description, string date, string time, string address, string forecast) 
        : base(title, description, date, time, address)
    {
        _forecast = forecast;
    }

    // Behaviors
    public override void ShowFullDetails()
    {
        base.ShowStandardDetails();
        Console.WriteLine($"The weather is {_forecast}");
    }
}