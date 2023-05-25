using System;

class Program
{
    static void Main()
    {
        // Create an instance of the verLibrary that stores and generates a random verse.
        VerseLibrary verseLibrary = new VerseLibrary();

        // Generate a random scripture from the library. This object stores reference and text of the verse.
        Reference reference = verseLibrary.GetRandomVerse();

        // Create a new Scripture object. This object handles the text of the verse.
        Scripture scripture = new Scripture(reference.GetText());

        while (true)
        {
            // Clear console screen everytime while loop runs so that the text of the scripture simultaneously updates itself.
            Console.Clear(); // Clear the console screen

            // Welcome text of the program.
            Console.WriteLine("Welcome to Scripture Memorizer!");
            Console.WriteLine();

            // Prints updated text of verse.
            Console.WriteLine(reference.ConvertToString() + " " + scripture.GetVisibleText());
            // Informs user of possible actions.
            Console.WriteLine();
            Console.Write("Press Enter to continue or type 'quit' to finish: ");

            // Defines user input.
            string input = Console.ReadLine();

            //If user input is 'quit' the program will stop.
            if (input.ToLower() == "quit")
                break;

            // Program will continue to this point if user didn't enter 'quit'. Now, the program will select random words and hide them.
            scripture.HideWords();

            //After each iteration of the loop, it will always check to see if all the words are hidden. 
            // If they are, program will print the update string and inform the user all words are hidden.
            if (scripture.IsCompletelyHidden())
            {
                // Clearing the console to update verse text one last time.
                Console.Clear();
                // Prints out the updated text where all the words are hidden.
                Console.WriteLine(reference.ConvertToString() + " " + scripture.GetVisibleText());
                // Informs user that all words are hidden and exits program.
                Console.WriteLine("All words hidden. Exiting program.");
                break;
            }
        }
    }
}
