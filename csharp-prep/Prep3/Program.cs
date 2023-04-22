using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        bool gameOver = false;
        while (gameOver == false)
        {
            //set magic number
            Random randomGenerator = new Random();
            int magicNum = randomGenerator.Next(1, 101);
        
            //intializing variables
            int guess = -1;
            int numGuess = 0;

            //tells user is guess it lower, higher, or correct.
            while (guess != magicNum)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                numGuess += 1;

                if (guess > magicNum)
                {
                    Console.WriteLine("Lower");
                }
                else if (guess < magicNum)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"You guessed {numGuess} times! ");
                }
            }
            
            //asks if user wants to play again
            Console.Write("Do you want to play again (y/n)? ");
            string playAgain = Console.ReadLine();
            if (playAgain == "y")
            {
                gameOver = false;
            }
            else if (playAgain == "n")
            {
                gameOver = true;
                Console.WriteLine("Thanks for playing!");
            }
        }
        
    }
}