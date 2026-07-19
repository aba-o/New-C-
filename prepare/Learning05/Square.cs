public class Square : Shape
{
    private double _aaoSide;

    public Square(string color, double side) : base (color)
    {
        _aaoSide = side;
    }
    public override double GetArea()
    {
        return _aaoSide * _aaoSide;
    }
}