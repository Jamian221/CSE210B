class Listing :Activity
{
    private List<string> _prompts = new List<string> {"When have you felt the Holy Ghost this month?", "When have friends lifted you up recently?"};
    public Listing(string name = "listing") :base(name){
        SetDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

    }
    public void ListingActivity(){
        Random random = new Random();
        int promptsIndex = random.Next(_prompts.Count());
        string prompt = _prompts[promptsIndex];
        Console.WriteLine("List as many responses as you can to the following prompt: ");
        Console.WriteLine($" --- {prompt} --- ");
        Console.Write("You may now begin in: ");
        for (int i = 5; i > 0; i--){
            Console.Write($"{i}");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
        DateTime startTime = DateTime.Now;
        DateTime EndTime = startTime.AddSeconds(GetActivityTime());
        int listedItems = 0;
        while(startTime < EndTime){
            Console.Write("> ");
            Console.ReadLine();
            startTime = DateTime.Now;
            listedItems++;
        }
        Console.WriteLine($"You've listed {listedItems}!");
    }
}