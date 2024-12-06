class ChecklistGoal :Goal{
    private int _timesToDone;
    private int _pointsWhenFinished;
    public ChecklistGoal(int points, int pointsWhenFinished, int timesToDone, string name, string description, string goalType = "Checklist Goal") :base(points, goalType, description, name){
        _timesToDone = timesToDone;
        _pointsWhenFinished = pointsWhenFinished;
    }
    public override string ReturnInfo()
    {
        return "";
    }
    public override string ToString()
    {
        throw new NotImplementedException();
    }
    public override string ReturnStatus()
    {
        throw new NotImplementedException();
    }
}