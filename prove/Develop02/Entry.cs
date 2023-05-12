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
    public string time;
    
    //Behaviors
    public string ConvertToString()
    {
        return $"{date}\n{time}\n{prompt}\n{response}\n";
    }
    public string ConvertToFile()
    {
        return $"{date}| {time}| {prompt}| {response}\n";
    }
    public void Hold(string prompt, string response, string date, string time)
    {
        this.prompt = prompt;
        this.response = response;
        this.date = date;
        this.time = time;
    }
}
}