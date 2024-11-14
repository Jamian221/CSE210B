using System;

class Program
{
    static void Main(string[] args)
    {
        int menuChoice;
        Journal journal = new Journal();
        Menu menu = new Menu();
        while (true){
            menu.DisplayMenu();
            menuChoice = menu.GetInput();

            if (menuChoice == 1){       //Creates a new entry
                JournalEntry Entry = new JournalEntry();
                journal.AddEntry(Entry);

            }else if (menuChoice == 2){ //saves
                
            }else if (menuChoice == 3){ //loads

            }else if (menuChoice == 4){ //Displays entries
                journal.DisplayAllEntries();
            }else if (menuChoice == 5){ //quits the program
                menu.Quit();
            }else Console.WriteLine("Not a valid input, please try again");//they inputed something wrong, isn't it obvious?
        }
    }
}