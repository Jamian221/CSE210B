class Goals{
    private Dictionary<string, Goal> _allGoals = new Dictionary<string, Goal>();
    private Dictionary<string, Goal> _activeGoals = new Dictionary<string, Goal>(); 
    private int _points;
    public void ListGoals(Dictionary<string, Goal> goals){
        Console.WriteLine("The goals are: ");
        int times_iterated = 1;
        foreach (KeyValuePair<string, Goal> goal in goals){
            Console.WriteLine($"{times_iterated}. {goal.Value.ReturnStatus()} {goal.Key} {goal.Value.ReturnInfo()}");
            times_iterated++;
        }
    }
    public Dictionary<string, Goal> ReturnAllGoalsDict(){
        return _allGoals;
    }
    public int GetPoints(){
        return _points;
    }
    private string GetKey(){
        string key;
        while (true){
            Console.Write("Input the name of the goal you completed: ");
            key = Console.ReadLine();
            if (_activeGoals.ContainsKey(key)){
                return key;
            }
            else{
                Console.WriteLine("please input a valid goal name");
            }
        }
    }
    public void RecordEvent(){
        if (_activeGoals.Count ==0){
            Console.WriteLine("There are no active goals to record");
            Console.Write("Press enter to continue");
            Console.ReadLine();
        }
        else{
            ListGoals(_activeGoals);
            string key = GetKey();
            Console.WriteLine($"Congradulations, you got {_activeGoals[key].GetPoints()} points!");
            Console.Write("Press enter to continue ");
            _points+= _activeGoals[key].GoalComplete();
            if (_activeGoals[key].CheckIfComplete() == true){
                _activeGoals.Remove(key);
            }
            Console.ReadLine();
        }
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
                goal = new SimpleGoal(points, description);
                _allGoals.Add(name, goal);
                _activeGoals.Add(name, goal);
                break;
            case 2:
                Console.Write("How many points do you want to get each time you do this goal? ");
                points = int.Parse(Console.ReadLine());
                goal = new EternalGoal(points, description);
                _allGoals.Add(name, goal);
                _activeGoals.Add(name, goal);
                break;
            case 3:
                Console.Write("How many points do you want to get each time you do this goal? ");
                points = int.Parse(Console.ReadLine());
                Console.Write("How many times will this goal be repeated until it's finished? ");
                timesToDone = int.Parse(Console.ReadLine());
                Console.Write("How many bonus points do you want when the goal is finished? ");
                endingPoints = int.Parse(Console.ReadLine());
                goal = new ChecklistGoal(points, endingPoints, timesToDone, description);
                _allGoals.Add(name, goal);
                _activeGoals.Add(name, goal);
                break;
        }
    }
    public void Save(){
        Console.Write("What is the name of the file you'd like to write to? ");
        string fileName = Console.ReadLine();

        using (StreamWriter saveFile = new StreamWriter(fileName)){
            foreach(KeyValuePair<string, Goal> pair in _allGoals){
                saveFile.WriteLine($"{pair.Key},{pair.Value}");
            }
        }
        Console.WriteLine("Saved successfully!");
        Console.Write("Press 'enter' to continue");
        Console.ReadLine();
    }
    public void Load(){
        Console.Write("What is the name of the file you'd like to load from? ");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines){
            string[] parts = line.Split(",");

            string name = parts[0];
            string goalType = parts[1];
            string description = parts[2];
            int points = int.Parse(parts[3]);

            if (goalType == "Eternal Goal"){
                int timesDone = int.Parse(parts[4]);
                _allGoals.Add(name, new EternalGoal(points, description, timesDone));
            }else if (goalType == "Checklist Goal"){
                int pointsWhenFinished = int.Parse(parts[4]);
                int timesDone = int.Parse(parts[5]);
                int timesToDone = int.Parse(parts[6]);
                bool isComplete = bool.Parse(parts[7]);
                _allGoals.Add(name, new ChecklistGoal(points, pointsWhenFinished, timesToDone, description, timesDone, isComplete));

            }else if (goalType == "Simple Goal"){
                bool isComplete = bool.Parse(parts[4]);
                _allGoals.Add(name, new SimpleGoal(points, description, isComplete));
            }else Console.WriteLine("Could not read goal type");

            if (_allGoals[name].CheckIfComplete() == false){
                _activeGoals.Add(name, _allGoals[name]);
            }

        }
        Console.WriteLine("Saved Succesfully!");
        Console.Write("Press 'enter' to continue");
        Console.ReadLine();
    }
}