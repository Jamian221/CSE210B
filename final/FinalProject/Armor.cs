class Armor :Equipment{
    private int _health;
    public Armor(string name, string description, int health, int speed, string itemType = "Armor") :base(name, description, itemType, speed){
        _health = health;
    }
    public override int ReturnHealth(){
        return _health;
    }
    public override string ReturnString()
    {
        return $"{base.ReturnString()} | Health: {_health} | Speed: {ReturnSpeed()}";
    }

}