using System.Data;
using System.Transactions;

class Breathing :Activity
{

    public Breathing(string name = "Breathing") :base(name)
    {
        SetDescription("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");

    }
    private void BreathingSet(int inTime, int outTime){
        Console.Write($"Breath in for {inTime}... ");
        for (int i = 0; i < inTime; i++){
            Console.Write($"\b \b{i+1}");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
        Console.Write($"Now breath out for {outTime}...");
        for (int i = 0; i < outTime; i++){
            Console.Write($"\b \b{i+1}");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
    public void BreathingActivity(){
        Console.Clear();
        int currentTime = 0;
        while (GetActivityTime() >= currentTime){
            Random random = new Random();
            int inTime = random.Next(4, 11);
            int outTime = random.Next(4, 11);
            BreathingSet(inTime, outTime);
            Console.WriteLine();
            int setTime = inTime + outTime;
            currentTime += setTime;
        }
        
    }
}