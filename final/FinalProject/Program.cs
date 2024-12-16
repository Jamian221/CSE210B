using System;

class Program
{
    static void Main(string[] args)
    {
        // program startup
        Room room = new Room();
        room.CreateCharacter();
        while (true){

            // room setup 
            room.SetRoom([0, 0, 0]);
            do{
                room.PlayerFight();
                if (room.IsRoomDone()) break;
                room.EnemyFight();
            }while (room.IsRoomDone() == false);
            bool isWon = room.EndRoom();
            if (isWon == false){
                Console.WriteLine("Game Over!");
                break;
            }
        }
    }
}