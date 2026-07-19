/*
author: Aba Otchere
Date: 07/15/26
description: Foundation 4 - Polymorphism


Resources used: Course marerials, W3Schools, Claude, Coddy, Chat GPT
*/
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Menu _aaoMenu = new Menu();
        ActivityManager _aaoActivityManager = new ActivityManager();
        FileManager _aaoFileManager = new FileManager("activities.txt");

        bool _aaoRunning = true;

        while (_aaoRunning)
        {
            _aaoMenu.DisplayMenu();

            int _aaoChoice = _aaoMenu.GetMenuChoice();

            switch (_aaoChoice)
            {
                case 1:
                    _aaoActivityManager.AddActivity(
                        _aaoMenu.CreateRunningActivity());

                    _aaoMenu.ShowMessage("Running activity added.");
                    _aaoMenu.PressEnterToContinue();
                    break;

                case 2:
                    _aaoActivityManager.AddActivity(
                        _aaoMenu.CreateCyclingActivity());

                    _aaoMenu.ShowMessage("Cycling activity added.");
                    _aaoMenu.PressEnterToContinue();
                    break;

                case 3:
                    _aaoActivityManager.AddActivity(
                        _aaoMenu.CreateSwimmingActivity());

                    _aaoMenu.ShowMessage("Swimming activity added.");
                    _aaoMenu.PressEnterToContinue();
                    break;

                case 4:
                    _aaoActivityManager.DisplayActivities();
                    _aaoMenu.PressEnterToContinue();
                    break;

                case 5:
                    _aaoMenu.ShowLoadingAnimation("Saving");

                    _aaoFileManager.SaveToFile(
                        _aaoActivityManager.GetActivities());

                    _aaoMenu.ShowMessage("Activities saved successfully.");
                    _aaoMenu.PressEnterToContinue();
                    break;

                case 6:
                    _aaoMenu.ShowLoadingAnimation("Loading");

                    _aaoActivityManager.SetActivities(
                        _aaoFileManager.LoadFromFile());

                    _aaoMenu.ShowMessage("Activities loaded successfully.");
                    _aaoMenu.PressEnterToContinue();
                    break;

                case 7:
                    _aaoMenu.ShowLoadingAnimation("Exiting");

                    _aaoRunning = false;
                    break;
            }
        }

        Console.WriteLine("\nThank you for using Fitness Tracker!");
    }
}