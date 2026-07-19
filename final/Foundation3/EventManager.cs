using System;
using System.Collections.Generic;

public class EventManager
{
    private List<Event> _aaoEvents;

    public EventManager()
    {
        _aaoEvents = new List<Event>();
    }

    public void AddEvent(Event eventToAdd)
    {
        _aaoEvents.Add(eventToAdd);
    }

    public List<Event> GetEvents()
    {
        return _aaoEvents;
    }

    public void DisplayEvents()
    {
        if (_aaoEvents.Count == 0)
        {
            Console.WriteLine(
                "No events available.");

            return;
        }

        for (int _aaoIndex = 0;
                _aaoIndex < _aaoEvents.Count;
                _aaoIndex++)
        {
            Console.WriteLine(
                $"{_aaoIndex + 1}. " +
                $"{_aaoEvents[_aaoIndex].GetEventType()} - " +
                $"{_aaoEvents[_aaoIndex].GetTitle()}");
        }
    }

    public void DisplayMarketingMessages()
    {
        if (_aaoEvents.Count == 0)
        {
            Console.WriteLine(
                "No events available.");

            return;
        }

        foreach (Event _aaoEvent in _aaoEvents)
        {
            Console.WriteLine();
            Console.WriteLine(
                "STANDARD DETAILS");

            Console.WriteLine(
                _aaoEvent.GetStandardDetails());

            Console.WriteLine();

            Console.WriteLine(
                "FULL DETAILS");

            Console.WriteLine(
                _aaoEvent.GetFullDetails());

            Console.WriteLine();

            Console.WriteLine(
                "SHORT DESCRIPTION");

            Console.WriteLine(
                _aaoEvent.GetShortDescription());

            Console.WriteLine(
                "\n--------------------------------");
        }
    }
}