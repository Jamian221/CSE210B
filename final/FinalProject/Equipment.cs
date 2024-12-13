abstract class Equipment :Item{
    private int _speed;
    protected Equipment(string name, string description, string itemType, int speed) :base(name, description, itemType){
        _speed = speed;
    }
    public override int ReturnSpeed(){
        return _speed;
    }
}