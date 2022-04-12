using System;

namespace TristanEtYseult
{
    class Program
    {
        
        
        static bool gameRunning = true;
        static bool gameStart = true;
        static void Main(string[] args)
        {
            
            while (gameRunning)
            {
                var weapon = 0;
                var armour = 0;
                gameStart = true;
                Console.WriteLine("Bienvenue, aventurier, dans l'histoire de Tristan et Yseult. " +
                        "Dans ce jeu, tu joueras le rôle de Tristan, et tu choisiras son destin dans cette histoire pleine de tragédie et de mort.");
                Console.WriteLine("Pour commencer, décidez de quoi équiper Tristan dans son combat contre le monde. (Choisissez en utilisant les chiffres)");
                Console.WriteLine("1. Une épée royale \n2.une épée courte et un ÉCU(1) \n3.une gourdin");
                while (weapon < 1 || weapon > 4)
                    weapon = int.Parse(Console.ReadLine().Trim().Substring(0, 1));

                Console.WriteLine("Choisissez maintenant l'armure que vous voulez porter (Choisissez en utilisant les chiffres) :");
                Console.WriteLine("1. Un HAUBERT(2) \n2.Un HEAUME(3) et l'armure complète");
                while (armour < 1 || armour > 3)
                    armour = int.Parse(Console.ReadLine().Trim().Substring(0, 1));
                Player player = new Player(weapon, armour);
                SceneController sc = new SceneController(player);
                var sceneNum = "1-1";
                while(gameStart)
                {
                    sc.loadScene(sceneNum);
                    sceneNum = sc.runScene(sceneNum);
                    if(sceneNum == "loss")
                    {
                        gameStart = false;
                        Console.WriteLine("Tristan est mort courageusement au combat.");
                    }
                    if(sceneNum == "bad")
                    {
                        gameStart = false;
                        Console.WriteLine("Tristan est mort à cause de ses péchés.");
                    }
                    if (sceneNum == "win")
                    {
                        gameStart = false;
                        Console.WriteLine("Tristan est encore en vie et l'histoire est terminée. ");
                    }
                }
                Console.WriteLine("Voulez vous jouer encore? (Enter Y/N) ");
                var again = Console.ReadLine().Trim().Substring(0).ToLower();
                if (again == "N")
                {
                    Console.WriteLine("\n \n \n");
                    gameRunning = false;
                }
            }
        }
    }
}
