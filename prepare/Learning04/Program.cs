using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment myAssignment = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(myAssignment.GetSummary());
        Console.WriteLine(myAssignment.GetHomeworkList());

        Console.WriteLine();

        EnglishAssignment yourAssignment = new EnglishAssignment("Mary Waters", "European History","The Causes of WWII");
        Console.WriteLine(yourAssignment.GetSummary());
        Console.WriteLine(yourAssignment.GetWritingInformation());
    }
}