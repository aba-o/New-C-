using System;

public class Fraction
{
    private int _aaoTop;
    private int _aaoBottom;
    public Fraction()
    {
        _aaoTop = 1;
        _aaoBottom = 1;
    }
    public Fraction(int aaoWholeNumber)
    {
        _aaoTop = aaoWholeNumber;
        _aaoBottom = 1;
    }
    public Fraction(int top, int bottom)
    {
        _aaoTop = top;
        _aaoBottom = bottom;
    }
    
    public void SetBottom(int bottom)
    {
        if (bottom != 0)
        {
            _aaoBottom = bottom;
        }
        else
        {
            _aaoBottom = 1;
        }
    }
    public void SetTop(int top)
    {
        _aaoTop = top;
    }

    public int GetBottom()
    {
        return _aaoBottom;
    }
    public int GetTop()
    {
        return _aaoTop;
    }
    
    public string GetFractionWithSlash()
    {
        return _aaoTop + "/" + _aaoBottom;
    }

    public double GetDecimalValue()
    {
        return (double)_aaoTop/(double)_aaoBottom;
    }

    public void GenerateRandomList()
    {
        Random random = new Random();
        
        for (int i = 0; i < 20; i++)
        {
            int _aaotopValue = random.Next(1, 11);
            int _aaobottomValue = random.Next(1, 11);
            
            // this refers to the current fraction object running the method
            this.SetTop(_aaotopValue);
            this.SetBottom(_aaobottomValue);
            
            Console.Write($"Fraction {i + 1}: ");
            Console.Write($"string: {this.GetFractionWithSlash()}");
            Console.WriteLine($" Number: {this.GetDecimalValue()}");
        }
    }
}