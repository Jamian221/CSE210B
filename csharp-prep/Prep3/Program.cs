using System;

class Program
{
    static int GuessNumber(){
        Console.Write("Guess a number: ");
        int guessedNumber = int.Parse(Console.ReadLine());
        return guessedNumber;
    }
    static void Main(string[] args)
    {
        // declare var
        int magicNumber;
        int guessedNumber;
        bool keepPlaying;
        string playAgain;
        // get magic number
        do{
            Console.Write("What is your magic number? ");
            magicNumber = int.Parse(Console.ReadLine());

            do
            {
                // retrieve a number
                guessedNumber = GuessNumber();

                // test and tell the user whether they guess it, higher or lower
                if (guessedNumber == magicNumber){
                    Console.WriteLine("You guessed it!");
                } else if (guessedNumber > magicNumber){
                    Console.WriteLine("Lower");
                } else if (guessedNumber < magicNumber){
                    Console.WriteLine("Higher");
                }
            }while(guessedNumber != magicNumber); // restart the loop if they did not guess it

                // ask if they would like to play again and repeat if they say "yes"
                Console.Write("Want to play again? ");
                playAgain = Console.ReadLine();
                if (playAgain == "yes"){
                    keepPlaying = true;
                } else keepPlaying = false;
        } while (keepPlaying == true);
    }
}