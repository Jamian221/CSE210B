using System.Runtime.CompilerServices;

class Room {
    private Character _player;
    private List<Item> _rewards;
    private List<Enemy> _enemies;
    private Creature _attacker;
    private Creature _defender;
    private float _chanceOfHitting;
    private int _attackDamage;
    private int _attackerSpeed;
    private int _defenderSpeed;
    public Room(List<Item> reward, List<Enemy> enemies){
        _rewards = reward;
        _enemies = enemies;
    }
    public void SetAttackerStats(){
        _attackerSpeed = _attacker.ReturnSpeed();
        _attackDamage = _attacker.BasicAttack();
    }
    public void SetDefenderStats(){
        _defenderSpeed = _defender.ReturnSpeed();
    }
    public bool CheckIfDead(Creature creature){
        return creature.ReturnDead();
    }
    public void DealDamage(Creature creature){
        creature.TakeDamage(_attackDamage);

    }
    public void ClaculateChanceOfHitting(){
        _chanceOfHitting = _attackerSpeed / _defenderSpeed;
    }
    public void SetAttacker(Creature creature){
        _attacker = creature;
    }
    public void SetDefender(Creature creature){
        _defender = creature;
    }
    public void EndFight(){

    }
    public void EndRoom(){
        
    }

}