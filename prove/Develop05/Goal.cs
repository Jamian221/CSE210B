abstract class Goal{
    protected int _points;
    protected bool _isComplete = false;
    protected string _goalType;
    protected string _description;
    protected string _name;
    protected Goal(int points, string goalType, string description, string name){
        _points = points;
        _goalType = goalType;
        _description = description;
        _name = name;
    }
    public string ReturnInfo(){
        return $"{_name} ({_description})";
    }
    public override abstract string ToString();
    public abstract string ReturnStatus();
    public abstract int GoalComplete();
}