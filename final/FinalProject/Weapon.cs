using System.ComponentModel;

class Weapon :Equipment{
    private int _damage;
    public Weapon(string name, string description, int damage, int speed, string itemType = "Weapon") :base(name, description, itemType, speed){
        _damage = damage;
    }
    public override string ReturnString()
    {
        return $"{base.ReturnString()} | Damage: {_damage} | Speed: {ReturnSpeed()}";
    }
    public int ReturnDamage(){
        return _damage;
    }
}