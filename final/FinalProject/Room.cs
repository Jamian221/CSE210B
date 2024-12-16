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
    private double _attackerSpeed;
    private double _defenderSpeed;
    private bool _hit;
    private int _level = 1;
    public Room(){
        
    }
    public void SetRoom(){
        int[] enemies;
        switch (_level){
            case 1:
                enemies = [0, 0, 0];
                break;
            case 2:
                enemies = [0, 0, 0, 0, 0];
                break;
            default:
                Console.WriteLine("Game Completed!");
                return;
            
        }
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
    public void Fight(){
        CalculateChanceOfHitting();
        Console.WriteLine($"Chance of hitting - {_chanceOfHitting * 100}%");
        Console.Write("Press 'enter' to fight!");
        Console.ReadLine();
        FightAnimation();
        _hit = IsHit();
    }
    public void PlayerFight(){
        SetAttacker(_player);
        ListEnemies();
        Console.Write("Which enemy will you attack? ");
        int selection = int.Parse(Console.ReadLine()) -1;
        SetDefender(_enemies[selection]);
        Fight();
        if (_hit){
            Console.WriteLine($"You hit for {_attackDamage} damage!");
            _enemies[selection].TakeDamage(_attackDamage);
            if (_enemies[selection].ReturnDead()){
                _enemies.RemoveAt(selection);
            }
        }
        else{
            Console.WriteLine("You missed!");
        }
    }
    public void EnemyFight(){
        SetAttacker(SelectRandomEnemy());
        SetDefender(_player);
        Console.WriteLine($"{_attacker.ReturnName()} is attacking you!");
        Console.WriteLine($"Chance of hitting - {_chanceOfHitting * 100}%");
        Thread.Sleep(2000);
        FightAnimation();
        _hit = IsHit();
        if (_hit){
            Console.WriteLine($"You got hit for {_attackDamage} damage!");
            _player.TakeDamage(_attackDamage);
        }
        else{
            Console.WriteLine($"{_attacker.ReturnName()} missed!"); 
        }
    }
    public Creature SelectRandomEnemy(){
        // Create a random number generator
        Random random = new Random();

        // Generate a random index within the bounds of the list
        int randomIndex = random.Next(0, _enemies.Count);

        // Select the item at the random index
        Creature selectedCreature = _enemies[randomIndex];

        return selectedCreature;
    }
    public void Animate(string animate, string message){
        Console.WriteLine(animate);
        Console.WriteLine(message);
        Thread.Sleep(100);
        Console.Clear();
    }
    public void FightAnimation(){
        Console.Clear();
        string message = "Epic clashing";
        for(int i = 0; i<5;i++){
            Animate("/", message);
            Animate("|", message);
            Animate("\\", message);
            Animate("-", message);
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
        double firstPart = _attackerSpeed / _defenderSpeed;
        _chanceOfHitting =  firstPart * .3;
    }
    public bool IsHit(){
        Random random = new Random();
        double randomNumber = random.NextDouble(); // Generates a random number between 0 and 1

        return randomNumber <= _chanceOfHitting; // if random number is less than the chance of hitting, it returns true, otherwise, false. 
    }
    public bool IsRoomDone(){
        if (_enemies.Count() == 0){
            return true;
        } return _player.ReturnDead();
    }
    public void EndFight(){

    }
    public bool EndRoom(){
        if (_player.ReturnDead() == true){
            Console.WriteLine("You've lost!");
            return false;
        } else{
            Console.WriteLine("You've won!");
            return true;
        }
    }
    public void CreateCharacter(){
        Console.Write("What name would you like to give your character? ");
        string name = Console.ReadLine().Trim();
        _player = new Character(name);
    }
    public void SetEnemies(int[] enemyCodes){
        foreach(int enemy in enemyCodes){
            if (enemy == 0){
                _enemies.Add(new Minion());
            }
            if (enemy == 1){
                _enemies.Add(new FootSoldier());
            }
        }
    }

}