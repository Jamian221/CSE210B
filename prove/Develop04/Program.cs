using System;
using System.Diagnostics;
using System.Net.Quic;

class Program{
    static void Main(string[] args){
        Menu menu = new();
        while (menu.ReturnQuit() != true){
            menu.DisplayMenu();
            menu.GetInput();
            switch (menu.ReturnChoice()){
                case 1:
                    // Breathing
                    Breathing breathingActivity = new();
                    breathingActivity.StartMessage();
                    breathingActivity.DisplayDescription();
                    breathingActivity.SetActivityTime();
                    breathingActivity.GetReady();
                    breathingActivity.BreathingActivity();
                    breathingActivity.EndMessage();
                    break;
                case 2:
                    // Reflecting
                    Reflecting reflectingActivity = new();
                    reflectingActivity.StartMessage();
                    reflectingActivity.DisplayDescription();
                    reflectingActivity.SetActivityTime();
                    reflectingActivity.GetReady();
                    reflectingActivity.ReflectingActivity();
                    reflectingActivity.EndMessage();
                    break;
                case 3:
                    // listing
                    Listing listingActivity = new();
                    listingActivity.StartMessage();
                    listingActivity.DisplayDescription();
                    listingActivity.SetActivityTime();
                    listingActivity.GetReady();
                    listingActivity.ListingActivity();
                    listingActivity.EndMessage();
                    break;
                case 4:
                    // quit
                    menu.Quit();
                    break;
            }
        }
    }
}