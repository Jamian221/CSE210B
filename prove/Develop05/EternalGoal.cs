class EternalGoal :Goal{
    private int _timesDone = 0;
    public EternalGoal(int points, string name, string description, string goalType = "Checklist Goal") :base(points, goalType, description, name){
        
    }  
    public override int GoalComplete(){
        _timesDone++;
        return _points;
    }
    public override string ToString()
    {
        throw new NotImplementedException();
    }
    public override string ReturnStatus()
    {
        return $"[{_timesDone}]";
    }
}