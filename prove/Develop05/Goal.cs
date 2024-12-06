abstract class Goal{
    private int _points;
    protected bool _isComplete = false;
    private string _goalType;
    private string _description;
    private string _name;
    protected Goal(int points, string goalType, string description, string name){
        _points = points;
        _goalType = goalType;
        _description = description;
        _name = name;
    }
    public virtual string ReturnInfo(){
        return "";
    }
    public override abstract string ToString();
    public abstract string ReturnStatus();
}