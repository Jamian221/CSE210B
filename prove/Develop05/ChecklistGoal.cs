class ChecklistGoal :Goal{
    private int _timesToDone;
    private int _timesDone;
    private int _pointsWhenFinished;
    public ChecklistGoal(int points, int pointsWhenFinished, int timesToDone, string description, int timesDone = 0, bool isComplete = false, string goalType = "Checklist Goal") :base(points, goalType, description){
        _timesToDone = timesToDone;
        _pointsWhenFinished = pointsWhenFinished;
        _timesDone = timesDone;
    }
    public override int GetPoints()
    {
        if ((_timesDone+1) == _timesToDone){
            return _pointsWhenFinished + base.GetPoints();
        }
        else{
            return base.GetPoints();
        }
    }
    public override int GoalComplete(){
        if(_timesDone < _timesToDone){
        _timesDone++;
            if (_timesDone == _timesToDone){
                _isComplete = true;
                return _pointsWhenFinished;
            }
            else {
                return _points;
        }
        }
        else{
            Console.WriteLine("This goal is already complete weirdo.");
            return 0;
        }

    }
    public override string ToString()
    {
        return $"{_goalType},{_description},{_points},{_pointsWhenFinished},{_timesDone},{_timesToDone},{_isComplete}";
    }
    public override string ReturnStatus()
    {
        if (_isComplete){
            return $"[X]";
        }
        else{
            return $"[{_timesDone}/{_timesToDone}]";
        }
    }
}