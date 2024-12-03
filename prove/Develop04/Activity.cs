using System.Reflection;
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
    protected void Animation(int seconds){
        for (int i = 0; i < seconds; i++){
            Console.Write("\b \b/");
            Thread.Sleep(125);
            Console.Write("\b \b-");
            Thread.Sleep(125);
            Console.Write("\b \b\\");
            Thread.Sleep(125);
            Console.Write("\b \b|");
            Thread.Sleep(125);

        }
        Console.Write("\b \b");
    }
    public void GetReady(){
        Console.Clear();
        Console.WriteLine("Get ready...");
        Animation(3);
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
        Console.WriteLine($"Welcome to the {_name} Activity!");
    }
    public void EndMessage(){
        Console.WriteLine();
        Console.WriteLine("Well Done!");
        Animation(3);
        Console.WriteLine();
        Console.WriteLine($"You have completed {_length} seconds of the {_name} activity!");
        Animation(3);
    }
}