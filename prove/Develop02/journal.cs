/*
author: Aba Otchere
Date: 14th May 2026

Description: Abstraction(journal class)
*/
using System.IO; 
using System;
using System.Globalization;

public class Journal
{
    public List<Entry> _aaoEntries = new List<Entry>();
    public string _aaoFileName = "journal.txt";
    public string _fileString = "";
    public void AddEntry(Entry aaoSingleEntry)
    {
        _aaoEntries.Add(aaoSingleEntry);
    }
    public void DisplayEntries()
    {
        foreach (Entry _aaoentry in _aaoEntries)
        {
            _aaoentry.DisplayEntry();
        }
    }
    public void SaveToFile(string _aaoFileName)
    {
        using(StreamWriter writer = new StreamWriter(_aaoFileName))
        {
            foreach(Entry _aaoentry in _aaoEntries)
            {
                writer.WriteLine(_aaoentry.GetFileString());
            }
        }
    }

    public void LoadFromFile(string _aaoFileName)
    {
        string[] lines = System.IO.File.ReadAllLines(_aaoFileName);
        foreach(string line in lines)
        {
            string[] parts = line.Split("#");
            string date = parts[0];
            string prompt = parts[1];
            string response = parts[2];
            string mood = parts[3]; //Mood was added in order to track all different moods from the different entries
            
            Console.WriteLine(
                $@"Date: {date} 
                Prompt: {prompt} 
                Response: {response}
                Mood: {mood}"
            );
        }
    }

    public void FilterByMood(string mood)
    {
        foreach (Entry entry in _aaoEntries)
        {
            if (entry._aaoMood.ToLower() == mood.ToLower())
            {
                entry.DisplayEntry();
                Console.WriteLine();
            }
        }
    }

}

