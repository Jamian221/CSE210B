class Goals{
    private List<Goal> _goals;
    private int _points;
    private int _activeGoals;
    private int _finishedGoals;
    public void ListGoals(){
        foreach (Goal goal in _goals){
            Console.WriteLine($"{goal.ReturnStatus()} {goal.ReturnInfo()}");
        }
    }
    public void CreateGoal(){
        int goalChoice;
        int points;
        string name;
        string description;
        Console.WriteLine("The types of Goals are: ");
        Console.WriteLine("    1. Simple Goal");
        Console.WriteLine("    2. Eternal Goal");
        Console.WriteLine("    3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        goalChoice = int.Parse(Console.ReadLine());
        Console.Write("What is the namne of your goal? ");
        name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        description = Console.ReadLine();
        Console.Write("What is the amount of points for this goal? ");
        points = int.Parse(Console.ReadLine());
        switch (goalChoice){
            case 1:
                _goals.Add(new SimpleGoal(points, description, name));
                break;
        }
    }
}