class ChecklistGoal :Goal{
    private int _timesToDone;
    private int _timesDone = 0;
    private int _pointsWhenFinished;
    public ChecklistGoal(int points, int pointsWhenFinished, int timesToDone, string name, string description, string goalType = "Checklist Goal") :base(points, goalType, description, name){
        _timesToDone = timesToDone;
        _pointsWhenFinished = pointsWhenFinished;
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
        throw new NotImplementedException();
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