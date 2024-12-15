using System;

class Program
{
    static void Main(string[] args)
    {
        // program startup
        Room room = new Room();
        room.CreateCharacter();

        // room setup 
        room.SetRoom([0, 0, 0]);
        room.PlayerFight();
        room.PlayerFight();
        room.PlayerFight();
        room.PlayerFight();
        room.PlayerFight();
        room.ListEnemies();


    }
}