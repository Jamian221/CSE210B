abstract class Item{
    private string _name;
    private string _description;
    private string _itemType;
    protected Item(string name, string description, string itemType){
        _name = name;
        _description = description;
        _itemType = itemType;
    }

    virtual public string ReturnString(){
        return $"{_name}: {_description}";
    }
    public string GetName(){
        return _name;
    }
}