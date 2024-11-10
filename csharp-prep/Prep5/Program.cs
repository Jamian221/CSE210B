using System;

/* 
DisplayWelcome - Displays the message, "Welcome to the Program!"
PromptUserName - Asks for and returns the user's name (as a string)
PromptUserNumber - Asks for and returns the user's favorite number (as an integer)
SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)
DisplayResult - Accepts the user's name and the squared number and displays them.
*/ 



class Program
{
    static void DisplayWelcome(){
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName(){
        Console.Write("What is your name? ");
        string name = Console.ReadLine();
        return name;
    }

    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
    }
}
