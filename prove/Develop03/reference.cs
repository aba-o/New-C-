public class Reference
{
    // Stores the scripture reference information entered by the user.
    private string _aaoBook;
    private string _aaoChapter;
    private int _aaoStartVerse;
    private int _aaoEndVerse;

    // Getter methods allow other classes to access reference data
    // without directly modifying it.
    public string GetBook()
    {
        return _aaoBook;
    }

    public string GetChapter()
    {
        return _aaoChapter;
    }

    public int GetStartVerse()
    {
        return _aaoStartVerse;
    }

    public int GetEndVerse()
    {
        return _aaoEndVerse;
    }

    // Determines whether the reference contains multiple verses.
    public bool IsRange()
    {
        return _aaoStartVerse != _aaoEndVerse;
    }

    // Constructor for a single verse reference (e.g., John 3:16).
    public Reference(string book, string chapter, string verse)
    {
        _aaoBook = book;
        _aaoChapter = chapter;
        _aaoStartVerse = int.Parse(verse);
        _aaoEndVerse = _aaoStartVerse;
    }

    // Constructor for a verse range (e.g., John 3:16-17).
    public Reference(string book, string chapter, string startVerse, string endVerse)
    {
        _aaoBook = book;
        _aaoChapter = chapter;
        _aaoStartVerse = int.Parse(startVerse);
        _aaoEndVerse = int.Parse(endVerse);
    }

    // Formats the reference for display. The format changes depending
    // on whether the user selected a single verse or a range.
    public string GetDisplayText()
    {
        if (_aaoStartVerse == _aaoEndVerse)
        {
            return $"{_aaoBook} {_aaoChapter}:{_aaoStartVerse}";
        }

        return $"{_aaoBook} {_aaoChapter}:{_aaoStartVerse}-{_aaoEndVerse}";
    }
}

