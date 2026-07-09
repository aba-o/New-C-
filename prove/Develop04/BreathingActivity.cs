using System;

public class BreathingActivity : Activity
{
    // Constructor
    public BreathingActivity()
        : base(
            "Breathing Activity",
            "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing."
        )
    {
    }


    // This is the unique behavior of the breathing activity
    public override void Run()
    {
        DisplayStartingMessage();


        DateTime aaoEndTime = DateTime.Now.AddSeconds(GetDuration());


        while (DateTime.Now < aaoEndTime)
        {
            Console.WriteLine();

            Console.Write("Breathe in...");
            ShowCountdown(4);

            Console.WriteLine();

            Console.Write("Breathe out...");
            ShowCountdown(6);

            Console.WriteLine();
        }


        DisplayEndingMessage();
    }
}