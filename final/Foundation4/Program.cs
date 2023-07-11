using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Let's create some activities
        Running running = new Running("03 Nov 2022", 30, 3);
        Cycling cycling = new Cycling("18 Mar 2023", 80, 22.5);
        Swimming swimming = new Swimming("24 Jul 2024", 60, 8);
        Skiing skiing = new Skiing("03 Nov 2022", 30, 25);

        // Let's add activities to a list
        List<Activity> activities = new List<Activity>();
        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);
        activities.Add(skiing);

        // Display summary for each activity
        foreach (Activity activity in activities)
        {
            Console.WriteLine();
            activity.DisplaySummary();
        }
    }
}