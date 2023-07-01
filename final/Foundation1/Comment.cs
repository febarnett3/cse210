public class Comment
{
    // Attributes
    private string _authorName;
    private string _commentText;

    // Constructor
    public Comment(string authorName, string commentText)
    {
        _authorName = authorName;
        _commentText = commentText;
    }

    // Behavior
    public string DisplayComment()
    {
        return $"{_authorName}: '{_commentText}'";
    }
}