using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");
        Console.Write("Hello user! What is your first name? ");
        string firstName = Console.ReadLine();

        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();
        

        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}");
    }
}
// I would've loved to put a capitalize function where it displavs a capitalized version of the names, 
// no matter how it was typed