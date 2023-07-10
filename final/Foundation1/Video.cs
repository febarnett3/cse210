using System;
using System.Collections.Generic;
using System.Linq;

public class Video
{
    // Attributes
    private string _title;
    private string _author;
    private int _videoLength;
    private List<Comment>_comments;

    // Constructor
    public Video(string title, string author, int videoLength)
    {
        _title = title;
        _author = author;
        _videoLength = videoLength;
        _comments = new List<Comment>();
    }

    // Behaviors
    public int GetNumComments()
    {
        return _comments.Count();
    }
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
    public void DisplayVideo()
    {
        Console.WriteLine($"'{_title}' | By: {_author} | Length: {_videoLength}s | There are {GetNumComments()} comments");
        
        DisplayComments();
    }
    private void DisplayComments()
    {
        Console.WriteLine("Comments: ");
        foreach (Comment comment in _comments)
        {
            Console.WriteLine(comment.DisplayComment());
        }
    }
}