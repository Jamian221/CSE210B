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
    public void GetInput(){

    }
    public void Save(){

    }
    public void Load(){

    }
    public void Quit(){

    }
    public void DisplayEntries(){

    }
    
}