using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        Goals goals = new Goals();
        while(menu.ReturnQuit() != true){
            menu.DisplayMenu(goals);
            menu.GetInput();
            switch(menu.ReturnChoice()){
                case 1:
                    // Create new goal
                    goals.CreateGoal();
                    break;
                case 2:
                    // List goals
                    goals.ListGoals(goals.ReturnAllGoalsDict());
                    Console.WriteLine();
                    Console.Write("Press enter to continue");
                    Console.ReadLine();
                    break;
                case 3:
                    // Save goals
                    goals.Save();
                    break;
                case 4:
                    // load goals
                    goals.Load();
                    break;
                case 5:
                    // record event
                    goals.RecordEvent();
                    break;
                case 6:
                    // quit
                    menu.Quit();
                    break;
            }
        }
    }
}