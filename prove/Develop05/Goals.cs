class Goals{
    private List<Goal> _goals = new List<Goal>();
    private int _points;
    private int _activeGoals = 0;
    private int _finishedGoals = 0;
    public void ListGoals(){
        Console.WriteLine("The goals are: ");
        int times_iterated = 1;
        foreach (Goal goal in _goals){
            Console.WriteLine($"{times_iterated}. {goal.ReturnStatus()} {goal.ReturnInfo()}");
            times_iterated++;
        }
        Console.WriteLine();
        Console.Write("Press enter to continue");
        Console.ReadLine();
    }
    public int GetPoints(){
        return _points;
    }
    public void CreateGoal(){
        int goalChoice;
        int points;
        int timesToDone;
        int endingPoints;
        string name;
        string description;
        Goal goal;

        Console.WriteLine("The types of Goals are: ");
        Console.WriteLine("    1. Simple Goal");
        Console.WriteLine("    2. Eternal Goal");
        Console.WriteLine("    3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        goalChoice = int.Parse(Console.ReadLine());
        Console.Write("What is the name of your goal? ");
        name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        description = Console.ReadLine();

        switch (goalChoice){
            case 1:
                Console.Write("What is the amount of points for this goal? ");
                points = int.Parse(Console.ReadLine());
                goal = new SimpleGoal(points, description, name);
                _goals.Add(goal);
                break;
            case 2:
                Console.Write("How many points do you want to get each time you do this goal? ");
                points = int.Parse(Console.ReadLine());
                goal = new EternalGoal(points, name, description);
                _goals.Add(goal);
                break;
            case 3:
                Console.Write("How many points do you want to get each time you do this goal? ");
                points = int.Parse(Console.ReadLine());
                Console.Write("How many times will this goal be repeated until it's finished? ");
                timesToDone = int.Parse(Console.ReadLine());
                Console.Write("How many bonus points do you want when the goal is finished? ");
                endingPoints = int.Parse(Console.ReadLine());
                goal = new ChecklistGoal(points, endingPoints, timesToDone, name, description);
                _goals.Add(goal);
                break;
        }
    }
}