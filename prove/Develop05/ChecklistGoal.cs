class ChecklistGoal :Goal{
    private int _timesToDone;
    public ChecklistGoal(int points, int timesToDone, string name, string description, string goalType = "Checklist Goal") :base(points, goalType, description, name){
        _timesToDone = timesToDone;
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