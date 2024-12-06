class Goals{
    private List<Goal> _goals;
    private int _points;
    private int _activeGoals;
    private int _finishedGoals;
    public void ListGoals(){
        foreach (Goal goal in _goals){
            Console.WriteLine($"{goal.ReturnStatus()} {goal.ReturnString()}");
        }
    }
}