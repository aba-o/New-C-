/// <summary>
/// This is the core class of the project. The most important concept here is that the scripture text is converted into a collection of Word objects, 
/// allowing each word to manage its own hidden state independently. 
/// The HideRandomWords() method then works only with visible words, ensuring the same word is never selected twice.
/// </summary>

public class Scripture
{
    // Stores the scripture reference and a collection of Word objects
    // that make up the scripture text.
    private Reference _aaoReference;
    private List<Word> _aaoWords;

    // Used to randomly select words to hide during the memorization process.
    private Random _random = new Random();

    public Scripture(Reference reference, string text)
    {
        _aaoReference = reference;

        _aaoWords = new List<Word>();

        // Break the scripture into individual words and create
        // a Word object for each one.
        string[] words = text.Split(' ');

        foreach (string word in words)
        {
            _aaoWords.Add(new Word(word));
        }
    }

    // Randomly hides a specified number of visible words.
    // Already hidden words are excluded from selection.
    public void HideRandomWords(int numberToHide)
    {
        for (int i = 0; i < numberToHide; i++)
        {
            // Create a temporary list containing only visible words.
            var visibleWords = _aaoWords
                .Where(w => !w.IsHidden())
                .ToList();

            // Stop early if every word has already been hidden.
            if (visibleWords.Count == 0)
                return;

            int index = _random.Next(visibleWords.Count);

            // Hide the randomly selected word.
            visibleWords[index].Hide();
        }
    }

    // Builds the display text by combining the reference
    // and the current state of each word.
    public string GetDisplayText()
    {
        string text = "";

        foreach (Word word in _aaoWords)
        {
            text += word.GetDisplayText() + " ";
        }

        return $"{_aaoReference.GetDisplayText()}\n{text}";
    }

    // Checks whether every word in the scripture has been hidden.
    // Used by the main program to determine when to stop.
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _aaoWords)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }

        return true;
    }
}