class Character :Creature{
    private Item _equippedWeapon = new Weapon("Sword", "basic sword", 10, 25);
    private Item _equippedArmor = new Armor("Standard Armor", "basic armor, gets the job done", 50, 25);
    private List<Item> _allWeapons = new List<Item>{
        new Weapon("Sword", "basic sword", 10, 25),
        new Weapon("Knives", "Fast, but low damage", 5, 75)
    };
    private List<Item> _allArmor = new List<Item>{
        new Armor("Basic armor", "fast enough, has enough heatlh", 100, 25),
        new Armor("Light armor", "Fast, but not much health", 70, 75),
        new Armor("Heavy Armor", "lots of health, but slows you down", 200, 15)
    };
    private List<Item> _allConsumables = new List<Item>{
        new Consumable("Health potion", "gives 50 health", healthBonus: 50),
        new Consumable("Rage potion", "increases damage by 30", damageBonus: 25),
        new Consumable("Speed potion", "makes you faster by 20", speedBonus: 20)
    };
    private List<Item> _armorInInventory = new List<Item>{};
    private List<Item> _weaponsInInventory = new List<Item>{};
    private List<Item> _consumablesInInventory = new List<Item>{};
    
    public Character(string name) :base(name){
        int maxHealth = 100;
        _health = maxHealth;
        _maxHealth = maxHealth;
        _armorInInventory.Add(_allArmor[0]);
        _weaponsInInventory.Add(_allWeapons[0]);
        _consumablesInInventory.Add(_allConsumables[0]);

    }
    public string CheckWeaponEquipped(){
        return _equippedWeapon.ReturnString();
    }
    public string CheckArmorEquipped(){
        return _equippedArmor.ReturnString();
    }
    public void EquipArmor(){
        ListList(_armorInInventory);
        Console.Write("Which one would you like to equip? ");
        int selection = int.Parse(Console.ReadLine()) - 1;
        _equippedArmor = _armorInInventory[selection];
    }
    public void ListList(List<Item> list){
        int timesIterated = 1;
        foreach (Item item in list){
            Console.WriteLine($"[{timesIterated}] {item.ReturnString()}");
            timesIterated++;
        }
    }
    public Item SelectItemFromList(List<Item> list){
        int selection = int.Parse(Console.ReadLine()) - 1;
        return list[selection];
    }
}