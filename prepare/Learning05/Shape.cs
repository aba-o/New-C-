public abstract class Shape
{
    private string _aaoColor;

    public Shape(string color)
    {
        _aaoColor = color;
    }

    public string GetColor()
    {
        return _aaoColor;
    }

    public void SetColor(string color)
    {
        _aaoColor = color;
    }
    public abstract double GetArea();
}