using System;
using System.Diagnostics;
using System.Net.Quic;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new();
        while (menu.ReturnQuit() != true)
        {
            menu.DisplayMenu();
            menu.GetInput();
            switch (menu.ReturnChoice())
            {
                case 1:
                    // Breathing
                    Breathing breathingActivity = new();
                    breathingActivity.StartMessage();
                    breathingActivity.DisplayDescription();
                    breathingActivity.SetActivityTime();
                    breathingActivity.BreathingActivity();
                    break;
                case 2:
                    // Reflecting
                    Reflecting reflectingActivity = new();
                    break;
                case 3:
                    // listing
                    Listing listingActivity = new();
                    break;
                case 4:
                    // quit
                    menu.Quit();
                    break;
            }
        }
    }
}