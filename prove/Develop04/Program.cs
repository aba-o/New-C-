/*
author: Aba Otchere
date: July 1st 2026
Description: Mindfulness Program

To show creativity, I added another activity; Gratitude Activity,Where users are able to list down things they are
grateful for similar to the listing activity. I also wrote the program such that, the same prompts are not used more than
once if all the other prompts are still unused.
*/


using System;

class Program
{
    //where everything comes together
    static void Main(string[] args)
    {
        Menu menu = new Menu();

        int aaoChoice = 0;

        while (aaoChoice != 5)
        {
            menu.DisplayMenu();

            aaoChoice = menu.GetUserChoice();

            if (aaoChoice >= 1 && aaoChoice <= 4)
            {
                menu.StartActivity(aaoChoice);
            }
            else if (aaoChoice != 5)
            {
                Console.WriteLine("Please select a valid option.");
            }

            Console.WriteLine();
        }


        Console.WriteLine("Thank you for using the Mindfulness Program. Goodbye!");
    }
}