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
    protected int GetActivityTime(){
        return _length;
    }
    public void Animation(){
        Console.Clear();
        Console.WriteLine("Get ready...");
        for (int i = 0; i < 10; i++){
            Console.Write("\b \b/");
            Thread.Sleep(100);
            Console.Write("\b \b-");
            Thread.Sleep(100);
            Console.Write("\b \b\\");
            Thread.Sleep(100);
            Console.Write("\b \b|");
            Thread.Sleep(100);

        }
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
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} activity!");
    }
}