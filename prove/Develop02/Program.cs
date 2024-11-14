using System;

class Program
{
    static void Main(string[] args)
    {
        int menuChoice;
        Menu menu = new Menu();
        menu.DisplayMenu();
        menuChoice = menu.GetInput();

        if (menuChoice == 1){

        }else if (menuChoice == 2){

        }else if (menuChoice == 3){

        }else if (menuChoice == 4){

        }else if (menuChoice == 5){
            menu.Quit();
        }else Console.WriteLine("Not a valid input, please try again");
    }
}