class Consumable :Item{
    private int _healthBonus;
    private int _speedBonus;
    private int _damageBonus;
    private int _uses;
    public Consumable(string name, string description, int uses = 1, int damageBonus = 0, int healthBonus = 0, int speedBonus = 0, string itemType = "Consumable") :base(name, description, itemType){
        _healthBonus = healthBonus;
        _damageBonus = damageBonus;
        _speedBonus = speedBonus;
        _uses = uses;
    }
    public int ReturnHealthBonus(){
        return _healthBonus;
    }
    public int ReturnSpeedBonus(){
        return _speedBonus;
    }
    public int ReturnDamageBonus(){
        return _damageBonus;
    }
    public void Use(){
        _uses++;
    }
    public bool IsUsed(){
        if (_uses == 0){
            return true;
        }
        else return false;
    }
}