class Assignment
{
    private string _name;
    private string _topic;
    protected Assignment(string name, string topic)
    {
        _name = name;
        _topic = topic;
    }
    protected string GetSummary()
    {
        return $"{_name}, {_topic}";
    }
}