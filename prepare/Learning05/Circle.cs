public class Circle : Shape
{
    private double _aaoRadius;

    public Circle(string color, double radius) : base (color)
    {
        _aaoRadius = radius;
    }

    public override double GetArea()
    {
        return _aaoRadius * _aaoRadius * Math.PI;
    }
}