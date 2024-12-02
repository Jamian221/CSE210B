using System.Data;

class Breathing :Activity
{

    public Breathing(string name) :base(name){}
    public void BreathingDescription(){
        Console.WriteLine();
        Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing."); 
        Console.WriteLine();

    }
}