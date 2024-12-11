class Enemy :Creature{
    protected Enemy(string name, int maxHealth, int damage, int speed) :base(name){
        _maxHealth = maxHealth;
        _health = maxHealth;
        _damage = damage;
        _speed = speed;
    }
}