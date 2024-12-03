using System.Reflection;

class Reflecting :Activity
{
    List<string> _prompts = new List<string>{"Think of a time when you did something really difficult.", "Think of the last time you felt the Holy Ghost."};
    List<string> _questions = new List<string>{"How did you feel when it was complete?", "What is your favorite thing about this experience?"};
    public Reflecting(string name = "Reflecting") :base(name){
        SetDescription("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
    }
    public void ReflectingActivity(){
        Random random = new Random();
        int randomPrompts = random.Next(_prompts.Count);
        string prompt = _prompts[randomPrompts];
        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine();
        Console.Write($" --- {prompt} ---");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.Write("You may now begin in: ");
                for (int i = 5; i > 0; i--){
            Console.Write($"{i}");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        int totalTime = 0;
        int questionNumber = 0;
        while (totalTime < GetActivityTime()){
            Console.WriteLine();
            Console.Write($"> {_questions[questionNumber]}");
            Animation(6);
            questionNumber++;
            if (questionNumber == _questions.Count()){
                totalTime = GetActivityTime();
            }
            totalTime+=6;
        }

    }
}