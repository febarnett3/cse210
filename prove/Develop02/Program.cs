using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;


//I exceeded the requirements for this assignment:
//First, I made date an object instead of a string. The user no longer needs to enter a date.
//Second, I added an additional item to the entry, time. This gives the time the entry was written.
//That way, if there are several entries a day, you can see the different times they were recorded.
//Just for fun, I made the prompts sound like the program is asking you instead of the user asking themself.
//Basically I replaced the I's with you's in the prompts.

namespace Develop02{
    class Program
    {
        static Journal journal = new Journal();
        
        static void Main(string[] args)
        {
            while (true)
            {
            DisplayMenu();
            string choice = Console.ReadLine();
            switch (choice)
            {

                case "1":
                    AddEntry();
                    break;

                case "2":
                    DeleteEntry();
                    break;

                case "3":
                    DisplayEntries();
                    break;

                case "4":
                    SaveJournal();
                    break;

                case "5":
                    LoadJournal();
                    break;

                case "6":
                    return;

            }
            }

            static void DisplayMenu()
            {
                Console.WriteLine("1. Add entry");
                Console.WriteLine("2. Delete entry");
                Console.WriteLine("3. Display entries");
                Console.WriteLine("4. Save journal");
                Console.WriteLine("5. Load journal");
                Console.WriteLine("6. Exit");
            }

            static void AddEntry()
            {
                Entry entry = new Entry();
                Prompts prompts = new Prompts();
                string prompt = prompts.GetRandomPrompt();

                DateTime theCurrentDate = DateTime.Now;
                string date = theCurrentDate.ToShortDateString();
                
                string time = DateTime.Now.ToString("h:mm:ss tt");
                
                Console.WriteLine(prompt);

                Console.Write("Type here: ");
                string response = Console.ReadLine();
                
                entry.Hold(prompt, response, date, time);
                journal.AddEntry(entry);
            }

            static void DeleteEntry()
            {
                Console.Write("Enter entry number to delete: ");
                int index = int.Parse(Console.ReadLine());
                journal.DeleteEntry(index);
            }

            static void DisplayEntries()
            {
                Console.WriteLine();
                Console.WriteLine("Here are your entries: ");
                journal.DisplayEntries();
            }


            static void SaveJournal()
            {
                journal.SaveJournal();
            }

            static void LoadJournal()

            {
                Console.Write("Enter filename: ");
                string filename = Console.ReadLine();
                string[] lines = File.ReadAllLines(filename);

                foreach (string line in lines)
                {
                    Entry entry = new Entry();
                    string[] parts = line.Split("|");
                    string date = parts[0].Trim();
                    string time = parts[1].Trim();
                    string prompt = parts[2].Trim();
                    string response = parts[3].Trim();
                    entry.Hold(prompt, response, date, time);
                    journal.AddEntry(entry);
                }
                Console.WriteLine();
                Console.WriteLine($"Contents of {filename}:");
                DisplayEntries();
            }
          
        }

            
            
        }
    }