class SimpleGoal :Goal{
    public SimpleGoal(int points, string description, string name, string goalType = "Simple Goal") :base(points, goalType, description, name){

    }
    public override int GoalComplete()
    {
        return _points;
    }
    public override string ToString()
    {
        throw new NotImplementedException();
    }
    public override string ReturnStatus()
    {
        if (_isComplete == true){
            return $"[x]";
        }
        else{
            return "[ ]";
        }
    }
}