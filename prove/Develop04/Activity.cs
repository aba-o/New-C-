using System;
using System.Threading;

public abstract class Activity
{
    // Shared attributes for all activities
    protected string _aaoName;
    protected string _aaoDescription;
    protected int _aaoDuration;


    // Constructor
    public Activity(string name, string description)
    {
        _aaoName = name;
        _aaoDescription = description;
        _aaoDuration = 0;
    }


    // Common starting message for all activities
    public void DisplayStartingMessage()
    {
        Console.Clear();

        Console.WriteLine($"Welcome to the {_aaoName}.");
        Console.WriteLine();

        Console.WriteLine(_aaoDescription);
        Console.WriteLine();

        Console.Write("How long, in seconds, would you like for your session? ");
        _aaoDuration = int.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
    }


    // Common ending message for all activities
    public void DisplayEndingMessage()
    {
        Console.WriteLine();

        Console.WriteLine("Well done!!");
        ShowSpinner(2);

        Console.WriteLine();
        Console.WriteLine($"You have completed the {_aaoName} for {_aaoDuration} seconds.");

        ShowSpinner(3);

        Console.WriteLine();
    }


    // Spinner animation used whenever the program pauses
    protected void ShowSpinner(int seconds)
    {
        string[] animation = { "|", "/", "-", "\\" };

        DateTime endTime = DateTime.Now.AddSeconds(seconds);

        int index = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(animation[index]);
            Thread.Sleep(250);

            Console.Write("\b \b");

            index++;

            if (index >= animation.Length)
            {
                index = 0;
            }
        }
    }


    // Countdown animation
    protected void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);

            Console.Write("\b \b");
        }
    }


    // Gives derived classes access to duration
    protected int GetDuration()
    {
        return _aaoDuration;
    }


    // Every activity must have its own Run method
    public abstract void Run();
}