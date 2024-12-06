class SimpleGoal :Goal{
    public override string ReturnString()
    {
        return "";
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