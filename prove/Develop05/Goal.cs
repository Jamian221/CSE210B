abstract class Goal{
    protected int _points;
    protected bool _isComplete = false;
    protected string _goalType;
    protected string _description;
    protected Goal(int points, string goalType, string description){
        _points = points;
        _goalType = goalType;
        _description = description;
    }
    public string ReturnInfo(){
        return $"({_description})";
    }
    public override abstract string ToString();
    public abstract string ReturnStatus();
    public abstract int GoalComplete();
    public bool CheckIfComplete(){
        return _isComplete;
    }
    public virtual int GetPoints(){
        return _points;
    }
}