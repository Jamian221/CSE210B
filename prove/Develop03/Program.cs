using System;

class Program
{
    static void Main(string[] args)
    {
        //create a scripture
        Scripture scripture = new Scripture("Ether 12:27", "And if men come unto me I will show unto them their weakness. " +
                                            "I give unto men weakness that they may be humble; and my grace is sufficient for all men" +
                                            " that humble themselves before me; for if they humble themselves before me, and have faith"+
                                            " in me, then will I make weak things become strong unto them.");
        //loop for hiding words
        while (true){
            //display scripture
            scripture.DisplayScripture();
            //wait for enter key
            Console.ReadLine();
            //hide random words
            scripture.HideWords();
        }
    }
}