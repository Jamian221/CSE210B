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
            room.SetRoom();
            if (room.IsRoomDone()) break;
            do{
                room.PlayerFight();
                if (room.IsRoomDone()) break;
                Thread.Sleep(1000);
                room.EnemyFight();
            }while (room.IsRoomDone() == false);
            bool isWon = room.EndRoom();
            if (isWon == false){
                break;
            }
        }
        Console.WriteLine("Game Over");
    }
}