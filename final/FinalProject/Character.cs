class Character :Creature{
    private Weapon _equippedWeapon = new Weapon("Sword", "basic sword", 10, 25);
    private Armor _equippedArmor = new Armor("Standard Armor", "basic armor, gets the job done", 50, 25);
    private Dictionary<string, Item> _inventory = new Dictionary<string, Item>();
    private Dictionary<string, Weapon> _weaponInventory = new Dictionary<string, Weapon>();
    private Dictionary<string, Armor> _armorInventory = new Dictionary<string, Armor>();
    private Dictionary<string, Consumable> _consumableInventory = new Dictionary<string, Consumable>();
    public Character(string name, int maxHealth) :base(name){
        _health = maxHealth;
        _maxHealth = maxHealth;
    }
}