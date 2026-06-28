public class Passage
{
    // Stores the scripture text retrieved from the CSV file
    // and the reference selected by the user.
    private string _aaoScriptureVerse;
    private Reference _aaoReferenceUser;

    // Provides access to the user's scripture reference.
    public Reference GetReference()
    {
        return _aaoReferenceUser;
    }

    // Provides access to the scripture text that was loaded.
    public string GetScriptureText()
    {
        return _aaoScriptureVerse;
    }

    // Searches the CSV file for the scripture reference entered by the user.
    // Supports both single verses and verse ranges.
    public void GetScripture(string _aaofilenme)
    {
        string[] lines = System.IO.File.ReadAllLines(_aaofilenme);

        _aaoScriptureVerse = "";

        // Start at index 1 to skip the CSV header row.
        for (int i = 1; i < lines.Length; i++)
        {
            // Limit the split to 6 parts so commas inside verse text
            // do not break the parsing.
            string[] parts = lines[i].Split(',', 6);

            // Check that the book and chapter match the user's request.
            if (parts[1] == _aaoReferenceUser.GetBook() &&
                parts[3] == _aaoReferenceUser.GetChapter())
            {
                int verseNum = int.Parse(parts[4].Trim().Trim('"'));

                // Include verses that fall within the selected range.
                if (verseNum >= _aaoReferenceUser.GetStartVerse() &&
                    verseNum <= _aaoReferenceUser.GetEndVerse())
                {
                    // Clean up formatting from the CSV before storing.
                    string text = parts[5]
                        .Trim('"')
                        .Replace("¶", "")
                        .Trim();

                    _aaoScriptureVerse += text + " ";
                }
            }
        }

        // Remove the extra space added after the final verse.
        _aaoScriptureVerse = _aaoScriptureVerse.Trim();
    }

    // Collects scripture reference information from the user
    // and creates the appropriate Reference object.
    public void GetUserScripture()
    {
        Console.WriteLine("Please enter the book: ");
        string book = Console.ReadLine();

        Console.WriteLine("Please enter the chapter: ");
        string chapter = Console.ReadLine();

        Console.Write("Is this a range of verses? (y/n): ");
        string answer = Console.ReadLine().ToLower();

        if (answer == "y")
        {
            Console.Write("Please enter the starting verse: ");
            string startVerse = Console.ReadLine();

            Console.Write("Please enter the ending verse: ");
            string endVerse = Console.ReadLine();

            // Uses the range constructor in Reference.
            _aaoReferenceUser = new Reference(book, chapter, startVerse, endVerse);
        }
        else if (answer == "n")
        {
            Console.WriteLine("Please enter the verse");
            string verse = Console.ReadLine();

            // Uses the single-verse constructor in Reference.
            _aaoReferenceUser = new Reference(book, chapter, verse);
        }
        else
        {
            Console.WriteLine("invalid");
        }
    }
}