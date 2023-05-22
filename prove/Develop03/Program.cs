using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Scripture Memorizer!");
        Console.WriteLine("Enter 'quit' at any time to exit.");
        Console.WriteLine();

        VerseLibrary verseLibrary = new VerseLibrary();


        // Generate a random scripture from the library.
        Reference reference = verseLibrary.GetRandomVerse();
        // Create a new Scripture object.
        Scripture scripture = new Scripture(reference.GetText());

        while (true)
        {
            Console.Clear(); // Clear the console screen
            Console.WriteLine(reference.ConvertToString() + " " + scripture.GetVisibleText());
            Console.Write("Press Enter to hide a word: ");

            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            scripture.HideWord();

            if (scripture.AllWordsHidden())
            {
                Console.Clear();
                Console.WriteLine(reference.ConvertToString() + " " + scripture.GetVisibleText());
                Console.WriteLine("All words hidden. Exiting program.");
                break;
            }
        }
    }
}
