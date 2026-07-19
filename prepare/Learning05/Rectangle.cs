public class Rectangle : Shape
{
    private double _aaoLength;
    private double _aaoWidth;

    public Rectangle(string color, double length, double width) : base (color)
    {
        _aaoLength = length;
        _aaoWidth = width;
    }

    // Notice the use of the override keyword here
    public override double GetArea()
    {
        return _aaoLength * _aaoWidth;
    }
}