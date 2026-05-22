using System;
using System.Reflection;
/// <summary>
/// author: Aba Otchere
/// date: 21st May 2026
/// 
/// Description: Abstraction(Journal Program)
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        Journal _aaoJournal = new Journal();
        

        int _aaoresponsint = 0;
        while (_aaoresponsint != 6)
        {
            Console.WriteLine("Hello Develop02 World!");
            Console.WriteLine(
                @"Please select one of the following choices 
                1. Write 
                2. Display 
                3. Load 
                4. Save
                5. Filter entries
                6. Quit "
            ); //I added a filter option to search for entries
            _aaoresponsint = int.Parse(Console.ReadLine());

            if (_aaoresponsint == 1)
            {
                Entry _aaoNewEntry = new Entry();
                _aaoNewEntry.GetEntry();
                _aaoJournal.AddEntry(_aaoNewEntry);
            }
            else if (_aaoresponsint == 2)
            {
                _aaoJournal.DisplayEntries();
            }
            else if (_aaoresponsint == 3)
            {
                Console.WriteLine("Enter the file name:  ");
                Console.WriteLine("Here's your Journal! ");
                string _aaoName = Console.ReadLine();
                _aaoJournal.LoadFromFile(_aaoName);
            }
            else if (_aaoresponsint == 4)
            {
                Console.WriteLine("Enter the file name:  ");
                string _aaoName = Console.ReadLine();
                _aaoJournal.SaveToFile(_aaoName);
                Console.WriteLine("It has been saved to your Journal! ");
            }
            else if (_aaoresponsint == 5)
            {
                Console.Write("Enter mood to filter by: ");
                string mood = Console.ReadLine();
                _aaoJournal.FilterByMood(mood);
            }
            else if (_aaoresponsint == 6)
            {
                Console.WriteLine("You're a great writer! \n Hope to see you again!");
            }
            else
            {
                Console.Write("That was not an option!!");
            }
        }
    }
}