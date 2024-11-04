using System;

class Program
{
    static void Main(string[] args)
    {
        // declare variables
        string firstName;
        string lastName;
        // get first name
        Console.Write("What is your first name? ");
        firstName = Console.ReadLine();
        // get last name
        Console.Write("What is your last name? ");
        lastName = Console.ReadLine();
        // line space
        Console.WriteLine("");
        

        Console.Write($"Your name is {lastName}, {firstName} {lastName}.");
    }
}