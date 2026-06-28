using System;

public class Word
{
    // Represents a single word in the scripture and tracks
    // whether it is currently visible or hidden.
    private string _aaoText;
    private bool _aaoIsHidden;

    public Word(string text)
    {
        _aaoText = text;

        // Words start visible and are hidden as the program progresses.
        _aaoIsHidden = false;
    }

    // Marks the word as hidden.
    public void Hide()
    {
        _aaoIsHidden = true;
    }

    // Allows other classes to check if this word has already been hidden.
    public bool IsHidden()
    {
        return _aaoIsHidden;
    }

    // Returns either the original word or a matching number of underscores.
    // Using the word's length helps preserve the structure of the scripture
    // while making the hidden words unreadable.
    public string GetDisplayText()
    {
        if (_aaoIsHidden)
        {
            return new string('_', _aaoText.Length);
        }

        return _aaoText;
    }
}
