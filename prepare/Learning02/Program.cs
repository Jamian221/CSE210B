using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Input your age: ");
        string userInput = Console.ReadLine();
        int age = int.Parse(userInput);

        Console.WriteLine($"Your age is {age}!");
        // Console.WriteLine("Hello Learning02 World!");
    }
}