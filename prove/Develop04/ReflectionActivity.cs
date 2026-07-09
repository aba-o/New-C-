using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _aaoPrompts;
    private List<string> _aaoQuestions;

    private List<string> _aaoUsedPrompts;
    private List<string> _aaoUsedQuestions;

    private Random _aaoRandom;


    // Constructor
    public ReflectingActivity()
        : base(
            "Reflecting Activity",
            "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life."
        )
    {
        _aaoPrompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };


        _aaoQuestions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
        _aaoUsedPrompts = new List<string>();
        _aaoUsedQuestions = new List<string>();

        _aaoRandom = new Random();
    }


    // Runs the reflection activity
    public override void Run()
    {
        DisplayStartingMessage();


        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();


        string prompt = GetRandomPrompt();

        Console.WriteLine($"--- {prompt} ---");

        Console.WriteLine();

        Console.WriteLine("When you have something in mind, press Enter to continue.");
        Console.ReadLine();


        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());


        while (DateTime.Now < endTime)
        {
            string question = GetRandomQuestion();

            Console.WriteLine();
            Console.WriteLine(question);

            ShowSpinner(5);
        }


        DisplayEndingMessage();
    }


    // Selects a random reflection prompt
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

    // Selects a random question
    private string GetRandomQuestion()
    {
        if (_aaoUsedQuestions.Count == _aaoQuestions.Count)
        {
            _aaoUsedQuestions.Clear();
        }

        string question;

        do
        {
            int index = _aaoRandom.Next(_aaoQuestions.Count);
            question = _aaoQuestions[index];

        } while (_aaoUsedQuestions.Contains(question));

        _aaoUsedQuestions.Add(question);

        return question;
    }
}