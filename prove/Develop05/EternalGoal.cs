class EternalGoal :Goal{
    private int _timesDone = 0;
    public EternalGoal(int points, string description, int timesDone = 0, bool isComplete = false, string goalType = "Eternal Goal") :base(points, goalType, description){
        _timesDone = timesDone;
        _isComplete = isComplete;
    }  
    public override int GoalComplete(){
        _timesDone++;
        return _points;
    }
    public override string ToString()
    {
        return $"{_goalType},{_description},{_points},{_timesDone}";
    }
    public override string ReturnStatus()
    {
        return $"[{_timesDone}]";
    }
}