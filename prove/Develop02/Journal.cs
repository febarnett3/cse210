using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;
namespace Develop02 {
    ///<summaary>
    ///The responsibility of a Journal is to store entries.
    ///</summary>
public class Journal
{
    
    // Attributes
    public List<Entry> entries;
    
    public Journal()
    {
        entries = new List<Entry>();
    }

    // Behaviors
    public void AddEntry(Entry entry)
    {
        if (!entries.Contains(entry))
        {
            entries.Add(entry);
        }
        
    }

    public void SaveJournal()
        {
        Console.Write("Enter filename: ");
        string filename = Console.ReadLine();
        File.WriteAllText(filename,string.Empty);

        using (StreamWriter w = File.AppendText(filename))
            {
                foreach (Entry entry in entries)
                {
                    w.Write(entry.ConvertToFile());
                }
            }
        }

     public List<Entry> GetAllEntries()
    {
        return this.entries;
    }

    public void DeleteEntry(int index)
    {
        entries.RemoveAt(index - 1);
    }

    public void DisplayEntries()
    {
        foreach (Entry entry in entries)
        {
            Console.WriteLine($"{entries.IndexOf(entry)+1}. {entry.ConvertToString()}");
        }
    }

}
}