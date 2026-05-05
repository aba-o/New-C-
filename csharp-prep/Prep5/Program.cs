using System;

class Program
{
    static void Main(string[] args)
    {
        aaoDisplayWelcomeMessage();

        string aaoUserName = aaoPromptUserName();
        int aaoUserNumber = aaoPromptUserNumber();

        int aaoSquaredNumber = aaoSquareNumber(aaoUserNumber);

        int aaoBirthYear;
        aaoPromptUserBirthYear(out aaoBirthYear);

        aaoDisplayResult(aaoUserName, aaoSquaredNumber, aaoBirthYear);
    }

    static void aaoDisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string aaoPromptUserName()
    {
        Console.Write("Please enter your name: ");
        string aaoName = Console.ReadLine();

        return aaoName;
    }

    static int aaoPromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int aaoNumber = int.Parse(Console.ReadLine());

        return aaoNumber;
    }
    
    static void aaoPromptUserBirthYear(out int aaoBirthYear)
    {
        Console.Write($"Please enter the year you were born: ");
        aaoBirthYear = int.Parse(Console.ReadLine());
    }

    static int aaoSquareNumber(int aaoNumber)
    {
        int aaoSquare = aaoNumber * aaoNumber;
        return aaoSquare;
    }

    static void aaoDisplayResult(string aaoName, int aaoSquare, int aaoBirthYear)
    {
        Console.WriteLine($"{aaoName}, the square of your number is {aaoSquare}.");
        Console.WriteLine($"{aaoName}, you will turn {2025 - aaoBirthYear} years old this year.");
    }
}