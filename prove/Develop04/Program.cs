using System;

class Program
{
    static void Main(string[] args)
    {
         while (true)
            {
                Console.Clear(); // Clears console

                Console.WriteLine("Welcome to the Mindfulness Program!");
                DisplayMenu(); // Displays the menu
                
                Console.Write("What would you like to do? ");
                string choice = Console.ReadLine(); // Asks for input

                switch (choice)
                {

                    case "1":
                        StartBreathingActivity();
                        break;

                    case "2":
                        StartReflectingActivity();
                        break;

                    case "3":
                        StartListingActivity();
                        break;

                    case "4":
                        Console.WriteLine("Exiting Program. Goodbye!");
                        return;

                }
            }
        
        static void DisplayMenu()
            {
                Console.WriteLine("1. Start breathing activity");
                Console.WriteLine("2. Start reflecting activity");
                Console.WriteLine("3. Start listing activity");
                Console.WriteLine("4. Quit");
            }

        static void StartBreathingActivity()
        {
            Console.Clear();
            BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
            breathingActivity.DisplayStartMessage();
            breathingActivity.RunActivity();
            breathingActivity.DisplayEndMessage();
        }

        static void StartReflectingActivity()
        {
            Console.Clear();
            ReflectingActivity reflectingActivity = new ReflectingActivity("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
            reflectingActivity.DisplayStartMessage();
            reflectingActivity.RunActivity();
            reflectingActivity.DisplayEndMessage();
        }

        static void StartListingActivity()
        {
            Console.Clear();
            ListingActivity listingActivity = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
            listingActivity.DisplayStartMessage();
            listingActivity.RunActivity();
            listingActivity.DisplayEndMessage();
        }
    }
}