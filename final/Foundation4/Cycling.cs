public class Cycling : Activity
{
    private double _aaoSpeed;

    public Cycling(string date, int minutes, double speed)
        : base(date, minutes)
    {
        _aaoSpeed = speed;
    }

    public override double GetDistance()
    {
        return (_aaoSpeed * GetMinutes()) / 60;
    }

    public override double GetSpeed()
    {
        return _aaoSpeed;
    }

    public override double GetPace()
    {
        return 60 / _aaoSpeed;
    }
}