using System;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        List<int> aaoNumbers = new List<int>();
        float aaoSum = 0;
        int aaoMax = -1;

        int aaonumber = -1;
        while (aaonumber != 0)
        {
            Console.WriteLine("Enter a list of numbers, type 0 when finished");
            Console.Write("Enter a number: ");
            aaonumber = int.Parse(Console.ReadLine());
            if (aaonumber != 0)
            {
                aaoNumbers.Add(aaonumber);
            }
        }
        // foreach(int number in aaoNumbers)
        // {
        //     Console.Write(number);
        // }
        foreach(int number in aaoNumbers)
        {
            aaoSum += number;
        }
        foreach(int number in aaoNumbers)
        {
            if (number > aaoMax)
            {
                aaoMax = number;
            }
        }

        Console.WriteLine($"The sum of numbers is: {aaoSum}");
        Console.WriteLine($"The average of numbers is: {aaoSum/aaoNumbers.Count}");
        Console.WriteLine($"The maximum number is: {aaoMax}");
    }
}