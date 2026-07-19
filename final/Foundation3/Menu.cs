using System;

public class Menu
{
    public void DisplayMainMenu()
    {
        Console.WriteLine();
        Console.WriteLine("Event Marketing Menu");
        Console.WriteLine("1. Create Event");
        Console.WriteLine("2. List Events");
        Console.WriteLine("3. Generate Marketing Messages");
        Console.WriteLine("4. Save Events");
        Console.WriteLine("5. Load Events");
        Console.WriteLine("6. Exit");
        Console.Write("Select an option: ");
    }

    public int GetMenuChoice()
    {
        return PromptForInt("");
    }

    public void DisplayEventTypes()
    {
        Console.WriteLine();
        Console.WriteLine("Event Types");
        Console.WriteLine("1. Lecture");
        Console.WriteLine("2. Reception");
        Console.WriteLine("3. Outdoor Gathering");
        Console.Write("Select an event type: ");
    }

    public int GetEventTypeChoice()
    {
        return PromptForInt("");
    }

    public string PromptForString(string prompt)
    {
        Console.Write(prompt);
        return Console.ReadLine();
    }

    public int PromptForInt(string prompt)
    {
        int _aaoResult;

        Console.Write(prompt);

        while (!int.TryParse(
            Console.ReadLine(),
            out _aaoResult))
        {
            Console.Write(
                "Please enter a valid number: ");
        }

        return _aaoResult;
    }

    public void DisplayMessage(string message)
    {
        Console.WriteLine(message);
    }
}