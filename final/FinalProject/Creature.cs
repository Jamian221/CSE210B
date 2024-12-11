abstract class Creature{
    protected int _health;
    private string _name;
    protected int _speed;
    protected int _maxHealth;
    protected int _damage;
    private bool _isDead;
    protected Creature(string name){
        _isDead = false;
        _name = name;
    }
    public virtual int BasicAttack(){
        return _damage;
    }
    public int ReturnSpeed(){
        return _speed;
    }
    public bool ReturnDead(){
        return _isDead;
    }
    public void TakeDamage(int damage){
        _health -= damage;
    }

}