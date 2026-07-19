public class Swimming : Activity
{
    private int _aaoLaps;

    public Swimming(string date, int minutes, int laps)
        : base(date, minutes)
    {
        _aaoLaps = laps;
    }

    public override double GetDistance()
    {
        return (_aaoLaps * 50.0) / 1000.0;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / GetMinutes()) * 60;
    }

    public override double GetPace()
    {
        return GetMinutes() / GetDistance();
    }
}