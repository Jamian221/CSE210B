using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Threading.Tasks.Dataflow;

class Room {
    private Character _player;
    private List<Item> _rewards = new List<Item>();
    private List<Enemy> _allEnemies = new List<Enemy>();
    private List<Enemy> _enemies = new List<Enemy>();
    private Creature _attacker;
    private Creature _defender;
    private double _chanceOfHitting;
    private int _attackDamage;
    private int _attackerSpeed;
    private int _defenderSpeed;
    public Room(){
        _allEnemies.Add(new Minion());
    }
    public void SetRoom(int[] enemies){
        SetEnemies(enemies);
        ListEnemies();
        Console.WriteLine("Equip armor");
        _player.EquipArmor();
        Console.WriteLine("Equip Weapon");
        _player.EquipWeapon();
        Console.WriteLine("Use consumables");
        _player.UseConsumable();
        _player.CalculateStats();
        Console.WriteLine($"Character stats for this room - {_player.ReturnStats()}");
        Console.WriteLine("Start the fight by hitting 'enter'");
        Console.ReadLine();
        Console.Clear();
    }
    public void PlayerFight(){
        SetAttacker(_player);
        ListEnemies();
        Console.Write("Which enemy will you attack? ");
        int selection = int.Parse(Console.ReadLine()) -1;
        SetDefender(_enemies[selection]);
        CalculateChanceOfHitting();
        Console.WriteLine($"Chance of hitting - {_chanceOfHitting}%");
        Console.Write("Press 'enter' to fight!");
        Console.ReadLine();
        FightAnimation();
        bool hit = IsHit();
        if (hit){
            Console.WriteLine("You hit!");
            _enemies[selection].TakeDamage(_attackDamage);
        }
        else{
            Console.WriteLine("You missed!");
        }
    }
    public void Animate(string animate){
        Console.WriteLine(animate);
        Console.WriteLine("Epic Clashing!");
        Thread.Sleep(100);
        Console.Clear();
    }
    public void FightAnimation(){
        Console.Clear();
        for(int i = 0; i<5;i++){
            Animate("/");
            Animate("|");
            Animate("\\");
            Animate("-");
        }
    }
    public void ListEnemies(){
        int iteration = 1;
        Console.WriteLine("Enemies in this room:");
        foreach (Enemy enemy in _enemies){
            Console.WriteLine($"[{iteration}]. {enemy.ReturnString()}");
            iteration++;
        }
        Console.Write("Press 'Enter' to continue");
        Console.ReadLine();
    }
    public void ListRewards(){
        int iteration = 1;
        Console.WriteLine("Rewards in this room:");
        foreach (Item reward in _rewards){
            Console.WriteLine($"[{iteration}]. {reward.ReturnString()}");
            iteration++;
        }
        Console.Write("Press 'Enter' to continue");
        Console.ReadLine();
    }
    public void SetAttacker(Creature creature){
        _attacker = creature;
        _attackerSpeed = _attacker.ReturnSpeed();
        _attackDamage = _attacker.BasicAttack();
    }
    public void SetDefender(Creature creature){
        _defender = creature;
        _defenderSpeed = _defender.ReturnSpeed();
    }
    public bool CheckIfDead(Creature creature){
        return creature.ReturnDead();
    }
    public void DealDamage(Creature creature){
        creature.TakeDamage(_attackDamage);
    }
    public void CalculateChanceOfHitting(){
        _chanceOfHitting = _attackerSpeed / _defenderSpeed * 40;
        _chanceOfHitting = Math.Round(_chanceOfHitting, 2);
    }
    public bool IsHit(){
        Random random = new Random();
        double randomNumber = random.NextDouble(); // Generates a random number between 0 and 1

        return randomNumber <= _chanceOfHitting; // if random number is less than the chance of hitting, it returns true, otherwise, false. 
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
    public void SetEnemies(int[] enemyCodes){
        foreach(int enemy in enemyCodes){
            _enemies.Add(_allEnemies[enemy]);
        }
    }

}