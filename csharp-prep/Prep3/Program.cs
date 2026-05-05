/*
Author: Aba Otchere
Date: 28th April 2026

Description: While loops
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        Random aaoMagicNumber = new Random();
        int aaonumber = aaoMagicNumber.Next(1,100);
        
        
        int aaoUserGuess = -1;
        
        while (aaoUserGuess != aaonumber)
        {
            Console.Write("Enter your guess(1-100) ");
            string aaoUserInput = Console.ReadLine();
            aaoUserGuess = int.Parse(aaoUserInput);
            /*
            it is best written as
            Console.Write("Enter your guess(1-100)");
            aaoUserGuess = int.Parse(console.ReadLine())
            */
            if (aaoUserGuess > aaonumber)
            {
                Console.WriteLine("Guess Lower!");
            }
            else if (aaoUserGuess < aaonumber)
            {
                Console.WriteLine("Guess Higher!");
            }
            else
            {
                Console.WriteLine("You guessed it!");
                // Console.Write("Would you like to play again?(Yes/No): ");
            }

        }

    }
}