using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new();
        menu.DisplayMenu();
        menu.GetInput();
        switch(menu.ReturnChoice()){
            case 1:
                // Breathing
                break;
            case 2:
                // Reflecting
                break;
            case 3: 
                // listing
                break;
            case 4:
                // quit
                menu.Quit();
                break;
        }
    }
}