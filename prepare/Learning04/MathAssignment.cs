public class MathAssignment : Assignment
{
    // Attributes
    private string _textBookSection;
    private string _problems;

    // Constructor
    public MathAssignment(string name, string topic, string section, string problems) : base(name, topic)
    {
        _textBookSection = section;
        _problems = problems;
    }


    // Behaviors
    public string GetHomeworkList()
    {
        return $"Section {_textBookSection} Problems {_problems}";
    }
}