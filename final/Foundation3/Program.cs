using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Let's create some events!
        Lecture event1 = new Lecture("Why You Won't Be Rich", "The financial mistakes everyone makes and how to avoid.","06/30/2023","5:00PM MDT","BYU-Idaho I-Center", "Donald Trump", 250);
        Reception event2 = new Reception("Mike & Jenny's Party", "A beautiful wedding reception.","09/12/2024","7:00PM MDT","The Rustic Barnhouse, St. George", "joley63waltz@outlook.com");
        OutdoorGathering event3 = new OutdoorGathering("Grandpa Beck's BBQ","Come enjoy some fresh pork!","07/04/2023","4:00PM MDT", "Smith Park, Rexburg ID","Sunny with a light breeze");

        // create a list of events.
        List<Event>events = new List<Event>();

        // Add events to events list
        events.Add(event1);
        events.Add(event2);
        events.Add(event3);

        // Show details of each event.
        foreach(Event ev in events)
        {
           Console.WriteLine("Standard Details:");
           ev.ShowStandardDetails();
           Console.WriteLine();
           
           Console.WriteLine("Full Details:");
           ev.ShowFullDetails();
           Console.WriteLine();
           
           Console.WriteLine("Short Details:");
           ev.ShowShortDescription();
           Console.WriteLine();
        }
    }
}