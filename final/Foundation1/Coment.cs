public class Comment
{
    private string _aaoName;
    private string _aaoText;

    public Comment(string name, string text)
    {
        _aaoName = name;
        _aaoText = text;
    }

    public string GetName()
    {
        return _aaoName;
    }

    public string GetText()
    {
        return _aaoText;
    }
}