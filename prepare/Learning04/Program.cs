using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment assignment1 = new("Ian Olson", "Geometry", "1.7", "1-11 odd");
        WritingAssignment assignment2 = new("Ian Olson", "English", "Why are people weird?");
        Console.WriteLine($"{assignment1.GetHomeworkList()}");
        Console.WriteLine($"{assignment2.GetWritingInformation()}");

    }
}