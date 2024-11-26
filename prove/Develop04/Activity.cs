class Activity 
{
    private string _name;
    private int _length;
    protected Activity(string name, int length)
    {
        _name = name;
        _length = length;
    }
    protected void StartMessage(){
        Console.WriteLine($"Welcome to the {_name} activity!");
    }
}