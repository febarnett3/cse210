using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }
        static string PromptUserName(){
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
            return userName;
        }
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int userNum = int.Parse(Console.ReadLine());
            return userNum;
        }
        static int SquareNumber(int userNum)
        {
            int squaredNum = userNum * userNum;
            return squaredNum;
        }
        static void DisplayResult(string userName, int squaredNum)
        {
            Console.WriteLine($"{userName}, the square of your number is {squaredNum}.");
        }

        DisplayWelcome();
        string userName = PromptUserName();
        int userNum = PromptUserNumber();
        int squaredNum = SquareNumber(userNum);
        DisplayResult(userName, squaredNum);
    }
}