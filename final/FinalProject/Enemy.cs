class Enemy :Creature{
    protected Enemy(string name, int health, int damage, int speed) :base(name){
        _health = health;
        _damage = damage;
        _speed = speed;
    }
    public virtual string ReturnString(){
        return $"{ReturnName()} - Health: {_health} | Damage: {_damage} | Speed: {_speed}";
    }

}