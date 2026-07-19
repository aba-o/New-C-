using System;
using System.Collections.Generic;

public class ActivityManager
{
    private List<Activity> _aaoActivities;

    public ActivityManager()
    {
        _aaoActivities = new List<Activity>();
    }

    public void AddActivity(Activity activity)
    {
        _aaoActivities.Add(activity);
    }

    public void DisplayActivities()
    {
        if (_aaoActivities.Count == 0)
        {
            Console.WriteLine("\nNo activities found.");
            return;
        }

        Console.WriteLine("\nActivity Summary");
        Console.WriteLine("----------------");

        foreach (Activity activity in _aaoActivities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }

    public List<Activity> GetActivities()
    {
        return _aaoActivities;
    }

    public void SetActivities(List<Activity> activities)
    {
        _aaoActivities = activities;
    }

    public bool HasActivities()
    {
        return _aaoActivities.Count > 0;
    }

    public int GetActivityCount()
    {
        return _aaoActivities.Count;
    }
}