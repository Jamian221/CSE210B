class Character :Creature{
    private Item _equippedWeapon;
    private Item _equippedArmor;
    private List<Item> _allWeapons = new List<Item>{
        new Weapon("Sword", "basic sword", 20, 30),
        new Weapon("Knives", "Fast, but low damage", 15, 60)
    };
    private List<Item> _allArmor = new List<Item>{
        new Armor("Basic armor", "Well rounded armor", 100, 30),
        new Armor("Light armor", "Fast, but not much health", 70, 60),
        new Armor("Heavy Armor", "lots of health, but slows you down", 200, 20)
    };
    private List<Item> _allConsumables = new List<Item>{
        new Consumable("None", "Does nothing", uses: 1000000),
        new Consumable("Health potion", "gives 50 health", healthBonus: 50),
        new Consumable("Rage potion", "increases damage by 30", damageBonus: 25),
        new Consumable("Speed potion", "makes you faster by 20", speedBonus: 20)
    };
    private List<Item> _armorInInventory = new List<Item>{};
    private List<Item> _weaponsInInventory = new List<Item>{};
    private List<Item> _consumablesInInventory = new List<Item>{};
    private int _bonusDamage = 0;
    private int _bonusSpeed = 0;
    private int _bonusHealth = 0;
    
    public Character(string name) :base(name){
        _armorInInventory.Add(_allArmor[0]);
        _weaponsInInventory.Add(_allWeapons[0]);
        _consumablesInInventory.Add(_allConsumables[0]);
        _consumablesInInventory.Add(_allConsumables[1]);

    }
    public string CheckWeaponEquipped(){
        return _equippedWeapon.ReturnString();
    }
    public string CheckArmorEquipped(){
        return _equippedArmor.ReturnString();
    }
    public void UseConsumable(){
        WriteList(_consumablesInInventory);
        Console.Write("Which one would you like to use? (press 0 if none) ");
        int selection = int.Parse(Console.ReadLine()) - 1;
        if (selection == -1){
        }else{
            _consumablesInInventory[selection].Use();
            _bonusDamage = _consumablesInInventory[selection].ReturnDamageBonus();
            _bonusHealth = _consumablesInInventory[selection].ReturnHealthBonus();
            _bonusSpeed = _consumablesInInventory[selection].ReturnSpeedBonus();
        }
    }
    public void EquipArmor(){
        WriteList(_armorInInventory);
        Console.Write("Which one would you like to equip? ");
        int selection = int.Parse(Console.ReadLine()) - 1;
        _equippedArmor = _armorInInventory[selection];
        Console.WriteLine($"You have equipped {_equippedArmor.ReturnName()}");
        Console.Write("Press 'enter' to continue");
        Console.ReadLine();
    }
    public void EquipWeapon(){
        WriteList(_weaponsInInventory);
        Console.Write("Which one would you like to equip? ");
        int selection = int.Parse(Console.ReadLine()) - 1;
        _equippedWeapon = _weaponsInInventory[selection];
        Console.WriteLine($"You have equipped {_equippedWeapon.ReturnString()}");
        Console.Write("Press 'enter' to continue");
        Console.ReadLine();
    }
    public void ReceiveRewards(List<int[]> itemList){
        foreach (int item in itemList[0]){
            _consumablesInInventory.Add(_allConsumables[item]);
        }
        foreach (int item in itemList[1]){
            _weaponsInInventory.Add(_allWeapons[item]);
        }
        foreach (int item in itemList[2]){
            _armorInInventory.Add(_allArmor[item]);
        }
    }
    public void WriteList(List<Item> list){
        int timesIterated = 1;
        foreach (Item item in list){
            Console.WriteLine($"[{timesIterated}] {item.ReturnString()}");
            timesIterated++;
        }
    }
    public void CalculateStats(){
        _damage = _bonusDamage + _equippedWeapon.ReturnDamage();
        _speed = _equippedWeapon.ReturnSpeed() + _equippedArmor.ReturnSpeed() + _bonusSpeed;
        _health = _equippedArmor.ReturnHealth() + _bonusHealth;
    }
    public string ReturnStats(){
        return $"Damage: {_damage} | Speed: {_speed} | Health: {_health}";
    }
}