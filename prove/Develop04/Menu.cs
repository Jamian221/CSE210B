using System.Net.Quic;

class Menu
{
    private List<string> _menuOptions = new List<string>{"1. Start Breathing Activity", "2. Start Reflecting Activity", "3. Start Listing Activity", "4. Quit"};
    
    private int _menuChoice;
    public void DisplayMenu(){
        Console.WriteLine("Menu Options:");
        foreach (string option in _menuOptions){
            Console.WriteLine(option);
        }
        Console.WriteLine();
    }
    public void GetInput(){
        Console.Write("Select a choice from the menu: ");
        _menuChoice = int.Parse(Console.ReadLine());
        // return _menuChoice;
    }  
    public int ReturnChoice(){
        return _menuChoice;
    }
    public void Quit(){
        Environment.Exit(0);
    }
    public void DisplayEntries(){

    }
    
}