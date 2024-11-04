using System;

class Program
{
    static void Main(string[] args)
    {
        // // declare variables
        // int age;
        // do
        // {
        //     Console.Write("Please enter age (0-125): ");
        //     age = int.Parse(Console.ReadLine());
        //     Console.WriteLine($"Your age is: {age}.");

        // }while( age < 0 || age > 125);

        List <string> myColors = new List<string>();

        myColors.Add("Red");
        myColors.Add("Green");
        myColors.Add("Blue");

        foreach(string color in myColors)
        {
            Console.WriteLine(color);
        }
    }
}