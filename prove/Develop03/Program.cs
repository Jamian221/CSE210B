using System;

class Program
{
    static void Main(string[] args)
    {
        Word word = new Word("hello");
        Console.WriteLine(word.GetWord());
        word.HideWord();
        Console.WriteLine(word.GetWord());
        
    }
}