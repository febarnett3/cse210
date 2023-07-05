using System;
public abstract class Event
{
    // Attributes
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private string _address;

    // Constructor
    public Event(string title, string description, string date, string time, string address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    // Getters
    public string GetTitle()
    {
        return _title;
    }
    public string GetDate()
    {
        return _date;
    }
    
    // Behaviors
    public void ShowStandardDetails()
    {
        Console.WriteLine(_title);
        Console.WriteLine(_description);
        Console.WriteLine($"{_date} | {_time}");
        Console.WriteLine($"At {_address}");
    }
    public void ShowShortDescription()
    {
        Console.WriteLine($"{GetType()}: '{GetTitle()}' on {GetDate()}");
    }
    
    // Abstract Behaviors
    public abstract void ShowFullDetails();

}