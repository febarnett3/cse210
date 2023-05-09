using System.Collections.Generic;
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

     public List<Entry> GetAllEntries()
    {
        return this.entries;
    }
}
}