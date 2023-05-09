namespace Develop02
{
    ///<summary>
    ///The responsibility of an entry is to hold a prompt, response, and date.
    ///</summary>
public class Entry
{
    //Attributes
    public string prompt;
    public string response;
    public string date;
    
    //Behaviors
    public string ConvertToString()
    {
        return $"{date}\n{prompt}\n{response}\n";
    }
    public void Hold(string prompt, string response, string date)
    {
        this.prompt = prompt;
        this.response = response;
        this.date = date;
    }
}
}