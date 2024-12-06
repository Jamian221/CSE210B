abstract class Goal{
    private int points;
    private bool _isComplete = false;
    private string _goalType;
    private string _description;
    private string _name;
    public virtual string ReturnString(){
        return "";
    }
    public override abstract string ToString();
}