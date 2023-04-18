using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.Write("What is your score percentage? ");
        string userScore = Console.ReadLine();
        int score = int.Parse(userScore);
        
        //finds the letter score
        
        string letterScore = "E";
        int secondDigit = score%10;
        
        if (score >= 90)
        {
            letterScore = "A";
        }
         else if (score >= 80)
        {
            letterScore = "B";
        }
        else if (score >= 70)
        {
            letterScore = "C";
        }
        else if (score >= 60)
        {
            letterScore = "D";
        }
        else if (score < 60)
        {
            letterScore = "F";
        }

        //finds +/-
        if (letterScore != "F")
        {
            if (secondDigit >= 7)
            {
                letterScore = letterScore + "+";
            }
            else if (secondDigit < 3)
            {
                letterScore = letterScore + "-";
            }
        }

        //prints the letter score
        Console.WriteLine(letterScore);

        //determines whether or not the user passed.
        if (score >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("You failed.");
        }

    }
}