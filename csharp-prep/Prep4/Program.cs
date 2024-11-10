using System;
using System.Globalization;

class Program
{
    static int AddNumbers(List<int> numbers)
    {
        int addedNumbers = 0;
        foreach (int number in numbers){
            addedNumbers += number;
        }
        return addedNumbers;
    }
    static void Main(string[] args)
    {
        // declare variables
        int biggestNumber;
        int average;
        int newNumber;
        int total;
        List<int> numbers = new List<int>();

        do
        {
            Console.Write("What is the next number in the list? ");
            newNumber = int.Parse(Console.ReadLine());
            numbers.Add(newNumber);
        }while (newNumber != 0);
    }
}