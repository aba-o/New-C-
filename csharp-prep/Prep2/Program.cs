using System;
using System.Net.Security;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.Write("Hello Student! Enter your grade percentage ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);
        string letterGrade = "";

        if (grade >= 90)
        {
            letterGrade = "A";
        }
        else if (grade >= 80)
        {
            letterGrade = "B";
        }
        else if (grade >= 70)
        {
            letterGrade = "C";
        }
        else if (grade >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }
        
        int lastDigit = grade % 10;
        string sign = "";

        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else 
        {
            sign = "-";
        }

        if (letterGrade == "A" && sign == "+")
        {
            sign = "";
        }
        if (letterGrade == "F")
        {
            sign = "";
        }


        Console.WriteLine($"Your letter grade is {letterGrade}{sign}!");

        if (grade >= 70)
        {
            Console.WriteLine("Yayy! You passed this class!");
        }
        else
        {
            Console.WriteLine("Bummer, you failed!");
        }

    }
}