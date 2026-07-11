/*
* Creativity and Exceeding Requirements:
*
* This program can be extended with a Level System.
* Users gain levels as they earn more points.
* I added a menu class that handles the display of the menu so that the program class will be as simple as possible
*
* The user's level can be displayed alongside
* their current score to provide additional
* motivation and gamification.
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        goalManager.Start();
    }
}