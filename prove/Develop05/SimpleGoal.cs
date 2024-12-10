class SimpleGoal :Goal{
    public SimpleGoal(int points, string description, bool isComplete = false, string goalType = "Simple Goal") :base(points, goalType, description){
        _isComplete = isComplete;
    }
    public override int GoalComplete()
    {
        _isComplete = true;
        return _points;
    }
    public override string ToString()
    {
        return $"{_goalType},{_description},{_points},{_isComplete}";
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