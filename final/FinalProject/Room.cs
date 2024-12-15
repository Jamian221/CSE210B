using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

class Room {
    private Character _player;
    private List<Item> _rewards = new List<Item>();
    private List<Creature> _allEnemies = new List<Creature>();
    private List<Enemy> _enemies = new List<Enemy>();
    private Creature _attacker;
    private Creature _defender;
    private float _chanceOfHitting;
    private int _attackDamage;
    private int _attackerSpeed;
    private int _defenderSpeed;
    public Room(){
        _allEnemies.Add(new Minion());
    }
    public void SetRoom(int[] enemies){
        Console.WriteLine("Equip armor");
        _player.EquipArmor();
        Console.WriteLine("Equip Weapon");
        _player.EquipWeapon();
        Console.WriteLine("Use consumables");
        _player.UseConsumable();
        _player.CalculateStats();
        Console.WriteLine($"Character stats for this room - {_player.ReturnStats()}");
    }
    public void ListEnemies(){
        foreach (Enemy enemy in _enemies){
            
        }
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
    public void CreateCharacter(){
        Console.Write("What name would you like to give your character? ");
        string name = Console.ReadLine().Trim();
        _player = new Character(name);
    }
    public void SetDefenders(int[] enemyCodes){
        foreach(int enemy in enemyCodes){

        }
    }

}