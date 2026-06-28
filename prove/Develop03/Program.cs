/*
author: aba otchere
date: 28/06/2026
description: scripture memorizer

Exceeding Requirements:
- Instead of hardcoding a scripture, the program allows the user to enter
any book, chapter, and verse or verse range.
- Scripture text is loaded dynamically from a KJV CSV file, allowing access
to many scriptures rather than a single predefined verse.
*/
using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a Passage object to handle user input and scripture retrieval.
        Passage passage = new Passage();

        // Get the scripture reference from the user and load the matching
        // verse(s) from the CSV file.
        passage.GetUserScripture();
        passage.GetScripture("kjv.csv");

        // Retrieve the reference object created from the user's input.
        Reference reference = passage.GetReference();

        // Create a Scripture object that combines the reference and verse text.
        // This object controls displaying and hiding words.
        Scripture scripture = new Scripture(
            reference,
            passage.GetScriptureText());

        // Continue until every word has been hidden or the user chooses to quit.
        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            Console.Write("\nPress Enter or type quit: ");
            string input = Console.ReadLine();

            // Allow the user to exit early instead of completing the scripture.
            if (input.ToLower() == "quit")
                break;

            // Hide three random visible words each time Enter is pressed.
            scripture.HideRandomWords(3);

            // Display the updated scripture immediately after hiding words.
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
        }
    }
}