using System.Net.Quic;

class Menu
{
    private bool _quit = false;
    private List<string> _menuOptions = new List<string>{"1. Create new goal", "2. List Goals", "3. Save goals", "4. Load goals", "5. Record Event", "6. Quit"};
    private List<int> _possibleInputs = new List<int>{1, 2, 3, 4, 5, 6};
    private int _menuChoice;
    public void DisplayMenu(Goals goals){
        Console.Clear();
        Console.WriteLine($"You have {goals.GetPoints()} points.");
        Console.WriteLine();
        Console.WriteLine("Menu Options:");
        foreach (string option in _menuOptions){
            Console.WriteLine(option);
        }
        Console.WriteLine();
    }
    public void GetInput(){
        bool validInput = false;
        while (validInput == false){
            Console.Write("Select a choice from the menu: ");
            _menuChoice = int.Parse(Console.ReadLine());
            if (_possibleInputs.Contains(_menuChoice)){
                validInput = true;
            }
            else{
                Console.WriteLine("Please input a valid menu option. ");
            }
        }
        // return _menuChoice;
    }  
    public int ReturnChoice(){
        return _menuChoice;
    }
    public void Quit(){
        _quit = true;
    }
    public bool ReturnQuit(){
        return _quit;
    }
}