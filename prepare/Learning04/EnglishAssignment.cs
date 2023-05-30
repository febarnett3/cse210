public class EnglishAssignment : Assignment
{
    // Attributes
    private string _title;

    // Constructor
    public EnglishAssignment(string name, string topic, string title) : base(name, topic)
    {
        _title = title;
    }

    // Behaviors
    public string GetWritingInformation()
    {
        return $"{_title} by {GetStudentName()}";
    }
}