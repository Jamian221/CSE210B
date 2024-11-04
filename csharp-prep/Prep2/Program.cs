using System;
using System.Runtime.InteropServices;

class Program
{
    
    static void Main(string[] args)
    {
        //declare variables
        string gradeInString;
        int gradeInInt;
        int aGrade = 90;
        int bGrade = 80;
        int cGrade = 70;
        int dGrade = 60;
        // get grade
        Console.Write("What was your grade? ");
        gradeInString = Console.ReadLine();
        //convert to int
        gradeInInt = int.Parse(gradeInString);

        // if statements!!
        if (gradeInInt >= aGrade){
            Console.WriteLine("You passed the class with an A!");
        } else if(gradeInInt >= bGrade){
            Console.WriteLine("You passed the class with a B!");
        }else if(gradeInInt >= cGrade){
            Console.WriteLine("You passed the class with a C.");
        }else if(gradeInInt >= dGrade){
            Console.WriteLine("You barely passed with a D.");
        } else{
            Console.WriteLine("You failed the class.");
        }
    }
}