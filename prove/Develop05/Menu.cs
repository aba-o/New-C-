using System;

public class Menu
{
    public void DisplayMainMenu(int score)
    {
        Console.WriteLine();
        Console.WriteLine($"You have {score} points.");
        Console.WriteLine();
        Console.WriteLine("Menu Options:");
        Console.WriteLine("  1. Create New Goal");
        Console.WriteLine("  2. List Goals");
        Console.WriteLine("  3. Save Goals");
        Console.WriteLine("  4. Load Goals");
        Console.WriteLine("  5. Record Event");
        Console.WriteLine("  6. Display Score");
        Console.WriteLine("  7. Quit");
        Console.Write("Select a choice from the menu: ");
    }

    public int GetMenuChoice()
    {
        int choice;

        while (!int.TryParse(Console.ReadLine(), out choice))
        {
            Console.Write("Please enter a valid number: ");
        }

        return choice;
    }

    public void DisplayGoalTypes()
    {
        Console.WriteLine();
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
    }

    public int GetGoalTypeChoice()
    {
        int choice;

        while (!int.TryParse(Console.ReadLine(), out choice))
        {
            Console.Write("Please enter a valid number: ");
        }

        return choice;
    }

    public string PromptForString(string prompt)
    {
        Console.Write(prompt);
        return Console.ReadLine();
    }

    public int PromptForInt(string prompt)
    {
        int value;

        Console.Write(prompt);

        while (!int.TryParse(Console.ReadLine(), out value))
        {
            Console.Write("Please enter a valid number: ");
        }

        return value;
    }

    public void DisplayMessage(string message)
    {
        Console.WriteLine(message);
    }
}