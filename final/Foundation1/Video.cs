using System;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void DisplayVideo()
    {
        Console.WriteLine($"Video Title: {_title}\nBy: {_author}\nDuration: {_length}\n\nComments:");
        foreach (Comment c in _comments)
        {
            c.DisplayComment();
        }
        Console.WriteLine($"\n");
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

}