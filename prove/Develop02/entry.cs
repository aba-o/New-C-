/*
author: Aba Otchere
Date: 14th May 2026

Description: Abstraction(entry class)
*/

using System;
using System.Xml.Serialization;
public class Entry
{
    public string _aaoCurrentDateTime;
    public string _aaoMyPrompt;
    public string _aaoUserResponse;
    public string _aaoMood;

    public void GetEntry()
    {
        _aaoCurrentDateTime = DateTime.Now.ToShortDateString();
        PromptGenerator _aaoUserPrompt = new PromptGenerator();
        _aaoMyPrompt = _aaoUserPrompt.GetRandomPrompt();

        Console.Write(_aaoMyPrompt);
        _aaoUserResponse = Console.ReadLine();
        Console.WriteLine("How are you feeling? (Happy, Sad, Excited, etc.)");
        _aaoMood = Console.ReadLine();
    }
    public string GetFileString()
    {
        return $"{_aaoCurrentDateTime}#{_aaoMyPrompt}#{_aaoUserResponse}#{_aaoMood}";
    }

    public void DisplayEntry()
    {
        Console.WriteLine(_aaoCurrentDateTime);
        Console.WriteLine(_aaoMyPrompt);
        Console.WriteLine(_aaoUserResponse);
        Console.WriteLine(_aaoMood);
    }
}