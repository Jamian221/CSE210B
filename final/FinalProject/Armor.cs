class Armor :Equipment{
    private int _health;
    public Armor(string name, string description, int health, int speed, string itemType = "Armor") :base(name, description, itemType, speed){
        _health = health;
    }
    public int ReturnHealth(){
        return _health;
    }
}