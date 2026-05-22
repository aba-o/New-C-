/*
author: Aba Otchere
Date: 14th May 2026

Description: Abstraction(prompt generator class)
*/

using System;

public class PromptGenerator
{
    public List<string> _aaoPromptGen = new List<string>
    {
        "What's something you misunderstood recently?",
        "Describe a moment that changed your mood today.",
        "What are you avoiding right now?",
        "What does success mean to you this week?",
        "What memory keeps resurfacing lately?",
        "What's something you wish people understood about you?",
        "What drains your energy most?",
        "What motivates you even on bad days?",
        "What's a lesson you learned the hard way?",
        "What would your younger self think of your life today?"
    };
    Random _aaoRandomPrompt = new Random();
    public string GetRandomPrompt()
    {
        int _aaoRandomIndex = _aaoRandomPrompt.Next(_aaoPromptGen.Count);
        string _aaoRandomPrompts = _aaoPromptGen[_aaoRandomIndex];
        return _aaoRandomPrompts;
    }
    
}