using System.Data;

class Breathing :Activity
{

    public Breathing(string name = "Breathing") :base(name)
    {
        SetDescription("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");

    }
    public void BreathingSet(int inTime, int outTime){
        Console.Write("Breath in... ");
        for (int i = 0; i < inTime; i++){
            Console.Write($"\b \b{i+1}");
            Thread.Sleep(1000);
        }
        Console.WriteLine("Breath out...");
        for (int i = 0; i < inTime; i++){
            Console.Write($"\b \b{i+1}");
            Thread.Sleep(1000);
        }
    }

}