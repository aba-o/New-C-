using System;
using System.Threading;

public class Menu
{
    public void DisplayMenu()
    {
        Console.Clear();

        Console.WriteLine("=================================");
        Console.WriteLine("       FITNESS TRACKER");
        Console.WriteLine("=================================");
        Console.WriteLine("1. Add Running Activity");
        Console.WriteLine("2. Add Cycling Activity");
        Console.WriteLine("3. Add Swimming Activity");
        Console.WriteLine("4. View Activities");
        Console.WriteLine("5. Save Activities");
        Console.WriteLine("6. Load Activities");
        Console.WriteLine("7. Exit");
        Console.WriteLine("=================================");
    }

    public int GetMenuChoice()
    {
        Console.Write("\nSelect an option: ");

        int _aaoChoice;

        while (!int.TryParse(Console.ReadLine(), out _aaoChoice) ||
                _aaoChoice < 1 ||
                _aaoChoice > 7)
        {
            Console.Write("Invalid choice. Try again: ");
        }

        return _aaoChoice;
    }

    public Running CreateRunningActivity()
    {
        Console.Write("\nDate: ");
        string _aaoDate = Console.ReadLine();

        Console.Write("Minutes: ");
        int _aaoMinutes = int.Parse(Console.ReadLine());

        Console.Write("Distance (km): ");
        double _aaoDistance = double.Parse(Console.ReadLine());

        return new Running(
            _aaoDate,
            _aaoMinutes,
            _aaoDistance);
    }

    public Cycling CreateCyclingActivity()
    {
        Console.Write("\nDate: ");
        string _aaoDate = Console.ReadLine();

        Console.Write("Minutes: ");
        int _aaoMinutes = int.Parse(Console.ReadLine());

        Console.Write("Speed (kph): ");
        double _aaoSpeed = double.Parse(Console.ReadLine());

        return new Cycling(
            _aaoDate,
            _aaoMinutes,
            _aaoSpeed);
    }

    public Swimming CreateSwimmingActivity()
    {
        Console.Write("\nDate: ");
        string _aaoDate = Console.ReadLine();

        Console.Write("Minutes: ");
        int _aaoMinutes = int.Parse(Console.ReadLine());

        Console.Write("Number of laps: ");
        int _aaoLaps = int.Parse(Console.ReadLine());

        return new Swimming(
            _aaoDate,
            _aaoMinutes,
            _aaoLaps);
    }

    public void ShowLoadingAnimation(string message)
    {
        string[] _aaoFrames = { "|", "/", "-", "\\" };

        Console.Write($"\n{message} ");

        for (int i = 0; i < 12; i++)
        {
            Console.Write($"\r{message} {_aaoFrames[i % 4]}");
            Thread.Sleep(100);
        }

        Console.WriteLine("\r" + message + " Complete!      ");
    }

    public void Pause(int milliseconds)
    {
        Thread.Sleep(milliseconds);
    }

    public void PressEnterToContinue()
    {
        Console.WriteLine("\nPress Enter to continue...");
        Console.ReadLine();
    }

    public void ShowMessage(string message)
    {
        Console.WriteLine($"\n{message}");
    }
}