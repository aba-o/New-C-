/*
Author: Aba Otchere
Date: 12th May 2026

Description: Conditional Statements
*/

using System;
using System.Net.Security;

class Joke
{
    static void Main()
    {
        WriteFile();
        ReadFile();
    }
    static void WriteFile()
    {
        string aao_fileName = "Joke.txt";
        using (StreamWriter jokefile = new StreamWriter(aao_fileName))
        {
            jokefile.WriteLine("Can't really think of one");
            string aao_joke = "This is not funny";
            jokefile.WriteLine($"I can't believe it! {aao_joke}");
        }
    }
    static string ReadFile()
    {
        string[] lines = System.IO.File.ReadAllLines("Joke.txt");
        return lines;

        // foreach (string line in lines)
        // {
        //     string [] parts = line.Split("");
        // }
    }
}