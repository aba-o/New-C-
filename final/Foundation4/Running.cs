public class Running : Activity
{
    private double _aaoDistance;

    public Running(string date, int minutes, double distance)
        : base(date, minutes)
    {
        _aaoDistance = distance;
    }

    public override double GetDistance()
    {
        return _aaoDistance;
    }

    public override double GetSpeed()
    {
        return (_aaoDistance / GetMinutes()) * 60;
    }

    public override double GetPace()
    {
        return GetMinutes() / _aaoDistance;
    }
}