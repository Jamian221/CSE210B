using System.Net.Quic;

class Menu
{
    private List<string> _menuOptions = new List<string>{"1. Write", "2. Save", "3. Load", "4. Display Entries", "5. Quit"};
    
    private int _menuChoice;
    public void DisplayMenu(){
        Console.WriteLine("Wecome to your journal! what would you like to do today?");
        foreach (string option in _menuOptions){
            Console.WriteLine(option);
        }

    }
    public int GetInput(){
        _menuChoice = int.Parse(Console.ReadLine());
        return _menuChoice;
    }  
    public void Save(){

    }
    public void Load(){

    }
    public void Quit(){
        Environment.Exit(0);
    }
    public void DisplayEntries(){

    }
    
}