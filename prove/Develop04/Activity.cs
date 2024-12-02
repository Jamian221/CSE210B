using System.Runtime.InteropServices;

class Activity 
{
    private string _name;
    private int _length;
    private string _description;
    protected Activity(string name)
    {
        _name = name;
    }
    public void SetActivityTime()
    {
        Console.Write("How long, in seconds, would you like for your session? ");
        _length = int.Parse(Console.ReadLine());
    }
    protected void SetDescription(string description){
        _description = description;
    }
        public void DisplayDescription(){
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();

    }
    
    public void StartMessage(){
        Console.WriteLine($"Welcome to the {_name} activity!");
    }
}