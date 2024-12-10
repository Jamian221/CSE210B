class EternalGoal :Goal{
    private int _timesDone = 0;
    public EternalGoal(int points, string description, string goalType = "Checklist Goal") :base(points, goalType, description){
        
    }  
    public override int GoalComplete(){
        _timesDone++;
        return _points;
    }
    public override string ToString()
    {
        return $"{_goalType},{_description},{_points}{_timesDone}";
    }
    public override string ReturnStatus()
    {
        return $"[{_timesDone}]";
    }
}