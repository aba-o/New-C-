using System.Runtime.CompilerServices;

public class Video
{
    private string _aaoTitle;
    private string _aaoAuthor;
    private int _aaoLength;
    private List<Comment> _aaoComments;

    public Video(string title, string author, int length)
    {
        _aaoTitle = title;
        _aaoAuthor = author;
        _aaoLength = length;
        _aaoComments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        _aaoComments.Add(comment);
    }

    public int GetCommentCount()
    {
        return _aaoComments.Count;
    }

    public List<Comment> GetComments()
    {
        return _aaoComments;
    }

    public string GetTitle()
    {
        return _aaoTitle;
    }

    public string GetAuthor()
    {
        return _aaoAuthor;
    }

    public int GetLength()
    {
        return _aaoLength;
    }
}