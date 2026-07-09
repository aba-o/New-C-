using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _aaoPrompts;
    private List<string> _aaoResponses;

    private List<string> _aaoUsedPrompts;

    private Random _aaoRandom;


    // Constructor
    public ListingActivity()
        : base(
            "Listing Activity",
            "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."
        )
    {
        _aaoPrompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };


        _aaoResponses = new List<string>();

        _aaoUsedPrompts = new List<string>();
        _aaoRandom = new Random();
    }


    // Runs the listing activity
    public override void Run()
    {
        DisplayStartingMessage();


        Console.WriteLine();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine();


        string prompt = GetRandomPrompt();

        Console.WriteLine($"--- {prompt} ---");


        Console.WriteLine();
        Console.WriteLine("You may begin in:");
        ShowCountdown(5);


        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());


        while (DateTime.Now < endTime)
        {
            Console.Write("> ");

            string response = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(response))
            {
                _aaoResponses.Add(response);
            }
        }


        Console.WriteLine();

        Console.WriteLine($"You listed {_aaoResponses.Count} items.");


        DisplayEndingMessage();
    }


    // Selects a random prompt at least once hence do while
    private string GetRandomPrompt()
    {
        if (_aaoUsedPrompts.Count == _aaoPrompts.Count)
        {
            _aaoUsedPrompts.Clear();
        }

        string prompt;

        do
        {
            int index = _aaoRandom.Next(_aaoPrompts.Count);

            prompt = _aaoPrompts[index];

        } while (_aaoUsedPrompts.Contains(prompt));

        _aaoUsedPrompts.Add(prompt);

        return prompt;
    }
}