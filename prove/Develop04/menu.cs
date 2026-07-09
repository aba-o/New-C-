using System;

public class Menu
{
    private Activity _currentActivity;


    // Constructor
    public Menu()
    {
        _currentActivity = null;
    }


    // Displays the main menu
    public void DisplayMenu()
    {
        Console.WriteLine("\n Mindfulness Program");
        Console.WriteLine("-------------------");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflecting Activity");
        Console.WriteLine("3. Listing Activity");
        Console.WriteLine("4. Gratitude Activity");
        Console.WriteLine("5. Quit");
        Console.WriteLine("------------------- \n");
    }


    // Gets user's choice
    public int GetUserChoice()
    {
        Console.Write("Select a choice from the menu: ");

        string input = Console.ReadLine();

        return int.Parse(input);
    }


    // Creates and starts the selected activity
    public void StartActivity(int choice)
    {
        switch (choice)
        {
            case 1:
                _currentActivity = new BreathingActivity();
                break;

            case 2:
                _currentActivity = new ReflectingActivity();
                break;

            case 3:
                _currentActivity = new ListingActivity();
                break;

            case 4:
                _currentActivity = new GratitudeActivity();
                break;

            default:
                Console.WriteLine("Invalid choice.");
                return;
        }

        _currentActivity.Run();
    }
}