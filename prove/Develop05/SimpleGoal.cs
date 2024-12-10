class SimpleGoal :Goal{
    public SimpleGoal(int points, string description, string goalType = "Simple Goal") :base(points, goalType, description){

    }
    public override int GoalComplete()
    {
        _isComplete = true;
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