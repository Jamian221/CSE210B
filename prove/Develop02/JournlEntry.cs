class JournalEntry
{   
    private List<string> _prompts = new List<string>
    {
    "What was the most significant event in your life this week/month/year? How did it impact you?",
    "What is a memory that brings you joy? Describe it in detail.", 
    "What is a lesson you've learned recently? How will you apply it to your life?",
    "What are you grateful for today?",
    "What are your biggest challenges right now? How are you coping with them?",
    "What are your hopes and dreams for the future?"
    };
    private Random random = new Random();
    
    private string _date;
    private string _userInput;
    private string _prompt;
    public JournalEntry()
    {
        GetTime();
        DisplayPrompt();
        GetInput();
    }
    public JournalEntry(string date, string prompt, string userInput)
    {
        _date = date;
        _userInput = userInput;
        _prompt = prompt;
    }
    public void GetTime()
    {
        DateTime now = DateTime.Now;
        _date = now.ToString("yyyy MM dd");
    }
    public void DisplayPrompt()
    {
        int randomIndex = random.Next(_prompts.Count);
        _prompt = _prompts[randomIndex];
        Console.WriteLine(_prompt);
    }
    public void GetInput()
    {
        _userInput = Console.ReadLine();
    }
    public string EntryToString(){
        string bob = $"{_date}#{_prompt}#{_userInput}";
        return bob;
    }
    public string EntryDisplay(){
        string displayString = $"{_date} | {_prompt} | {_userInput}";
        return displayString;
    }
}