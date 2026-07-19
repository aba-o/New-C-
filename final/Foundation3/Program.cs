/*
author: Aba Otchere
Date: 07/15/26
description: Foundation 3 - Inheritance


Resources used: Course marerials, W3Schools, Claude, Coddy, Chat GPT
*/

using System;

public class Program
{
    static void Main(string[] args)
    {
        Menu _aaoMenu = new Menu();

        EventManager _aaoEventManager =
            new EventManager();

        FileManager _aaoFileManager =
            new FileManager("events.txt");

        bool _aaoRunning = true;

        while (_aaoRunning)
        {
            _aaoMenu.DisplayMainMenu();

            int _aaoChoice =
                _aaoMenu.GetMenuChoice();

            switch (_aaoChoice)
            {
                case 1:
                    CreateEvent(
                        _aaoMenu,
                        _aaoEventManager);
                    break;

                case 2:
                    _aaoEventManager.DisplayEvents();
                    break;

                case 3:
                    _aaoEventManager
                        .DisplayMarketingMessages();
                    break;

                case 4:
                    _aaoFileManager.SaveEvents(
                        _aaoEventManager.GetEvents());

                    _aaoMenu.DisplayMessage(
                        "Events saved successfully.");

                    break;

                case 5:

                    foreach (string _aaoLine in
                                _aaoFileManager.LoadEvents())
                    {
                        Console.WriteLine(
                            _aaoLine);
                    }

                    break;

                case 6:
                    _aaoRunning = false;
                    break;

                default:
                    _aaoMenu.DisplayMessage(
                        "Invalid option.");
                    break;
            }
        }
    }

    private static void CreateEvent(
        Menu menu,
        EventManager eventManager)
    {
        menu.DisplayEventTypes();

        int _aaoEventType =
            menu.GetEventTypeChoice();

        string _aaoTitle =
            menu.PromptForString(
                "Title: ");

        string _aaoDescription =
            menu.PromptForString(
                "Description: ");

        string _aaoDate =
            menu.PromptForString(
                "Date: ");

        string _aaoTime =
            menu.PromptForString(
                "Time: ");

        string _aaoStreet =
            menu.PromptForString(
                "Street: ");

        string _aaoCity =
            menu.PromptForString(
                "City: ");

        string _aaoState =
            menu.PromptForString(
                "State: ");

        string _aaoCountry =
            menu.PromptForString(
                "Country: ");

        Address _aaoAddress =
            new Address(
                _aaoStreet,
                _aaoCity,
                _aaoState,
                _aaoCountry);

        switch (_aaoEventType)
        {
            case 1:

                string _aaoSpeakerName =
                    menu.PromptForString(
                        "Speaker Name: ");

                int _aaoCapacity =
                    menu.PromptForInt(
                        "Capacity: ");

                eventManager.AddEvent(
                    new Lecture(
                        _aaoTitle,
                        _aaoDescription,
                        _aaoDate,
                        _aaoTime,
                        _aaoAddress,
                        _aaoSpeakerName,
                        _aaoCapacity));

                break;

            case 2:

                string _aaoRsvpEmail =
                    menu.PromptForString(
                        "RSVP Email: ");

                eventManager.AddEvent(
                    new Reception(
                        _aaoTitle,
                        _aaoDescription,
                        _aaoDate,
                        _aaoTime,
                        _aaoAddress,
                        _aaoRsvpEmail));

                break;

            case 3:

                string _aaoWeatherForecast =
                    menu.PromptForString(
                        "Weather Forecast: ");

                eventManager.AddEvent(
                    new OutdoorGathering(
                        _aaoTitle,
                        _aaoDescription,
                        _aaoDate,
                        _aaoTime,
                        _aaoAddress,
                        _aaoWeatherForecast));

                break;

            default:

                menu.DisplayMessage(
                    "Invalid event type.");

                break;
        }
    }
}