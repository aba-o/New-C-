using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");
        
        Fraction _aaoFirstF = new Fraction();
        Console.WriteLine(_aaoFirstF.GetFractionWithSlash());
        Console.WriteLine(_aaoFirstF.GetDecimalValue());
        
        Fraction _aaoFirstS = new Fraction(7);
        Console.WriteLine(_aaoFirstS.GetFractionWithSlash());
        Console.WriteLine(_aaoFirstS.GetDecimalValue());

        Fraction _aaoFirstN = new Fraction(7, 11);
        Console.WriteLine(_aaoFirstN.GetFractionWithSlash());
        Console.WriteLine(_aaoFirstN.GetDecimalValue());

        Fraction _aaoFirst1 = new Fraction(7, 11);
        Console.WriteLine(_aaoFirst1.GetFractionWithSlash());
        Console.WriteLine(_aaoFirst1.GetDecimalValue());

        Fraction _aaoFirstR = new Fraction();
        _aaoFirstR.GenerateRandomList();
    }
}