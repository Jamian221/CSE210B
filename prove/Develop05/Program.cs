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
                    goals.ListGoals();
                    break;
                case 3:
                    // Save goals
                    break;
                case 4:
                    // load goals
                    break;
                case 5:
                    // record event
                    break;
                case 6:
                    // quit
                    menu.Quit();
                    break;
            }
        }
    }
}