using System;

class Program
{
    static void Main(string[] args)
    {
        // Fraction noArgument = new Fraction();
        // Console.WriteLine(noArgument.GetFractionString());

        // // Fraction oneArgument = new Fraction(5);
        // // Console.WriteLine(oneArgument.GetFractionString());

        // // Fraction twoArguments = new Fraction(5, 10);
        // // Console.WriteLine(twoArguments.GetFractionString());

        // Console.WriteLine($"numertor = {noArgument.GetNumerator()} Denominator = {noArgument.GetDenominator()}");
        // noArgument.SetDenominator(7);
        // noArgument.SetNumerator(5);
        // Console.WriteLine($"numertor = {noArgument.GetNumerator()} Denominator = {noArgument.GetDenominator()}");

        Fraction one = new();
        Console.WriteLine(one.GetFractionString());
        Console.WriteLine(one.GetDecimalValue());
        Console.WriteLine();

        Fraction five = new(5);
        Console.WriteLine(five.GetFractionString());
        Console.WriteLine(five.GetDecimalValue());
        Console.WriteLine();

        Fraction threeFourths = new(3, 4);
        Console.WriteLine(threeFourths.GetFractionString());
        Console.WriteLine(threeFourths.GetDecimalValue());
        Console.WriteLine();

        Fraction oneThird = new(1, 3);
        Console.WriteLine(oneThird.GetFractionString());
        Console.WriteLine(oneThird.GetDecimalValue());
        Console.WriteLine();


    }
}