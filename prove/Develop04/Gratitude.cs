using System;
using System.Collections.Generic;

public class GratitudeActivity : Activity
{
    private List<string> _gratitudePrompts;
    private List<string> _responses;
    private List<string> _usedPrompts;

    private Random _random;


    // Constructor
    public GratitudeActivity()
        : base(
            "Gratitude Activity",
            "This activity will help you focus on the positive things in your life by thinking about the people, experiences, and blessings you are grateful for."
        )
    {
        _gratitudePrompts = new List<string>
        {
            "What is something small that brought you joy today?",
            "Who is someone you are grateful for and why?",
            "What is a talent or ability you are thankful for?",
            "What is a memory that you appreciate?",
            "What is something positive that happened this week?",
            "What is something in your life that you often take for granted?"
        };


        _responses = new List<string>();

        _usedPrompts = new List<string>();
        _random = new Random();
    }


    // Runs the gratitude activity
    public override void Run()
    {
        DisplayStartingMessage();


        Console.WriteLine();
        Console.WriteLine("Take some time to think about gratitude.");
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
                _responses.Add(response);
            }
        }


        Console.WriteLine();
        Console.WriteLine($"You recorded {_responses.Count} things you are grateful for.");


        DisplayEndingMessage();
    }


    // Selects a random gratitude prompt
    private string GetRandomPrompt()
    {
        if (_usedPrompts.Count == _gratitudePrompts.Count)
        {
            _usedPrompts.Clear();
        }

        string prompt;

        do
        {
            int index = _random.Next(_gratitudePrompts.Count);

            prompt = _gratitudePrompts[index];

        } while (_usedPrompts.Contains(prompt));

        _usedPrompts.Add(prompt);

        return prompt;
    }
}