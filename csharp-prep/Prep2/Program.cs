/*
Author: Aba Otchere
Date: 22nd April 2026

Description: COnditional Statements
*/

using System;
using System.Net.Security;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.Write("Hello Student! Enter your AAOgrade percentage ");
        string userInput = Console.ReadLine();
        int AAOgrade = int.Parse(userInput);
        string AAOletterGrade = "";

        if (AAOgrade >= 90)
        {
            AAOletterGrade = "A";
        }
        else if (AAOgrade >= 80)
        {
            AAOletterGrade = "B";
        }
        else if (AAOgrade >= 70)
        {
            AAOletterGrade = "C";
        }
        else if (AAOgrade >= 60)
        {
            AAOletterGrade = "D";
        }
        else
        {
            AAOletterGrade = "F";
        }
        
        int lastDigit = AAOgrade % 10;
        string sign = "";

        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else 
        {
            sign = "-";
        }

        if (AAOletterGrade == "A" && sign == "+")
        {
            sign = "";
        }
        if (AAOletterGrade == "F")
        {
            sign = "";
        }


        Console.WriteLine($"Your letter grade is {AAOletterGrade}{sign}!");

        if (AAOgrade >= 70)
        {
            Console.WriteLine("Yayy! You passed this class!");
        }
        else
        {
            Console.WriteLine("Bummer, you failed!");
        }

    }
}