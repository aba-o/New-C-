using System;

public abstract class Activity
{
    private string _aaoDate;
    private int _aaoMinutes;

    public Activity(string date, int minutes)
    {
        _aaoDate = date;
        _aaoMinutes = minutes;
    }

    public string GetDate()
    {
        return _aaoDate;
    }

    public int GetMinutes()
    {
        return _aaoMinutes;
    }

    public abstract double GetDistance();

    public abstract double GetSpeed();

    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{_aaoDate} {GetType().Name} ({_aaoMinutes} min): " +
                $"Distance: {GetDistance():F2} km, " +
                $"Speed: {GetSpeed():F2} kph, " +
                $"Pace: {GetPace():F2} min per km";
    }
}