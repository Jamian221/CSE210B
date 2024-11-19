using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction noArgument = new Fraction();
        Console.WriteLine(noArgument.GetFractionString());

        Fraction oneArgument = new Fraction(5);
        Console.WriteLine(oneArgument.GetFractionString());

        Fraction twoArguments = new Fraction(5, 10);
        Console.WriteLine(twoArguments.GetFractionString());

    }
}