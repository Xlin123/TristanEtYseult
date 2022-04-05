using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TristanEtYseult
{
    class SceneController
    {
        Player Tristan;
        public SceneController(Player player)
        {
            Tristan = player;
        }
        
        public void loadScene(string sceneNum)
        {
            Console.WriteLine("\n \n \n"); //SCENE BUFFER
            switch (sceneNum)
            {
                case "1-1":                  
                    Console.WriteLine("First Scene: Fight the Dragon"); //path 1, 2                   
                    break;
                case "1-2":
                    Console.WriteLine("Second Scene: Help Ysuelt \n ");
                    Console.WriteLine("Option A: Don't Help");//path 2, 1
                    Console.WriteLine("Option B: Help her!"); //path 1, 3
                    break;
                case "1-3":
                    Console.WriteLine("Third Scene: Do you give into your temptations? \n");
                    Console.WriteLine("Option A: Yes!"); //path 3 , 1
                    Console.WriteLine("Option B: No, I am a good knight!"); //path 1, 4
                    break;
                case "1-4":
                    Console.WriteLine("Fourth Scene: Tristan tries to exile, but rumors go around and the king is hunting him! \n");
                    Console.WriteLine("Option A: Talk to the king and convince him that the person is lying and nothing is going on!"); // game win!
                    Console.WriteLine("Option B: Run away with Yseult"); // path 1, 5
                    Console.WriteLine("Option C: Fight the king!!!"); //path fight scene  --> path 6 1
                    break;
                case "1-5":
                    Console.WriteLine("Fifth Scene: In the cabin for years \n ");
                    Console.WriteLine("Option A: Be a good knight!"); //path 1, 6
                    Console.WriteLine("Option B: Sin everyday!"); //path dead
                    Console.WriteLine("Option C: Kill Ysuelt"); //path 4, 1
                    break;
                case "1-6":
                    Console.WriteLine("Sixth Scene: Fight Number 2! \n");
                    //loadFightScene!
                    //win -> win!
                    //poisinneded -> path 1, 7
                    //lose - lose!
                    break;
                case "1-7":
                    Console.WriteLine("Seventh Scene: Yseult is called \n");
                    Console.WriteLine("Option A: You die because your wife is a liar"); //normal ending
                    Console.WriteLine("Option B: Kill your wife and eat her"); //canibal ending
                    Console.WriteLine("Option C: Be a strong knight!"); //strong knight ending!
                    break;


                //Oops didn't help Yseult.
                case "2-1":
                    Console.WriteLine("Third Scene, Alternate ending: Didn't help Yseult \n");
                    Console.WriteLine("Option A: Lie to the king"); // fight ireland w or loss.... path 2, 2
                    Console.WriteLine("Option B: Apologize!"); //imprisioned 
                    break;
                case "2-2":
                    Console.WriteLine("Fight Ireland!\n");
                    //fight
                    break;

                //Sinner's path
                case "3-1":
                    Console.WriteLine("Fourth Scene Alternate ending 2: Sinner. \n");
                    Console.WriteLine("Option A: Kill the king!"); // path 3, 2
                    Console.WriteLine("Option B: Apologize."); //killed by the king;\
                    break;
                case "3-2":
                    Console.WriteLine("FIGHT THE KING!");
                    //win loss
                    break;

                //Scardy Cat Win
                case "4-1":
                    Console.WriteLine("You ran away, good job");
                    break;

                //Cannibal Loss.
                case "5-1":
                    Console.WriteLine("Eat everyone and fight!");
                    break;

                //Fight the king and take the kingdom.
                case "6-1":
                    Console.WriteLine("we win those..");
                    break;
            }
        }


        public string runScene(string sceneNum, bool fightScene)
        {
            string nextScene = "";
            bool nextFight = false;
            if (!fightScene)
            {
                char input = ']';
                while (!checkInput(sceneNum, input))
                {
                    Console.WriteLine("Enter your option:");
                    input = Console.ReadLine().Trim().ToLower().ElementAt(0);
                }

                //returns 
                switch (sceneNum)
                {
                        
                    case "1-2":
                        if (input == 'a')
                            nextScene = "2-1";
                        else
                            nextScene = "1-3";
                        break;


                    case "1-3":
                        if (input == 'a')
                            nextScene = "3-1";
                        else
                            nextScene = "1-4";
                        break;


                    case "1-4":
                        if (input == 'a')
                            nextScene = "win";
                        else if (input == 'b')
                            nextScene = "1-5";
                        else
                        {
                            nextScene = "6-1";
                            nextFight = true;
                        }
                        break;


                    case "1-5":
                        if (input == 'a')
                        {
                            nextScene = "1-6";
                            nextFight = true;
                        }
                        else if (input == 'b')
                            nextScene = "loss";
                        else
                            nextScene = "4-1";
                        break;


                    case "1-7":
                        if (input == 'a')
                            nextScene = "loss";
                        if (input == 'b')
                            nextScene = "loss";
                        else
                            nextScene = "win";
                        break;
                    case "2-1":
                        if (input == 'a')
                            nextScene = "2-2";
                        else
                            nextScene = "loss";
                        break;


                    case "3-1":
                        if (input == 'a')
                            nextScene = "3-2";
                        else
                            nextScene = "loss";
                        break;


                    case "4-1":
                        nextScene = "win";
                        break;

                }
            }
            //FIGHT SCENE!!!!
            else
            {
                var battleLoop = true;
                if(sceneNum == "1-1")
                {
                    var input = 0;
                    Enemy dragon = new Enemy("dragon");
                    Console.WriteLine("-----Tristan-----");
                    Console.WriteLine("Tristan's health: " + Tristan.hp);
                    Console.WriteLine("Tristan's attack: " + Tristan.weaponDamage + "\n \n");
                    Console.WriteLine("--------Dragon stats-----------");
                    Console.WriteLine("Dragon's health:" + dragon.hp);
                    Console.WriteLine("Dragon's attack damage:" + dragon.weaponDamage);
                    while (battleLoop)
                    {
                       
                        Console.WriteLine("Choose an attack:");
                        Console.WriteLine("1: Slash \n 2.Pierce \n 3.Bash");
                        while (input != 1 || input != 2 || input != 3)
                            input = Int32.Parse(Console.ReadLine());
                        Tristan.attack(dragon, input);
                        Tristan.attack(dragon, input);

                        Console.WriteLine("--------Dragon stats-----------");
                        Console.WriteLine("Dragon's health:" + dragon.hp);
                        Console.WriteLine("Choose a defence:");
                        Console.WriteLine("1: Block \n 2.Parry \n 3.Dodge");
                        while (input != 1 || input != 2 || input != 3)
                            input = Int32.Parse(Console.ReadLine());
                        Tristan.defend(dragon, input);

                        if (dragon.hp < 0)
                            battleLoop = false;
                    }
                }
            }

            if (nextScene == "win")
                return "win";
            else if (nextScene == "loss")
                return "loss";
            else
                return nextScene;
        }

        public bool checkInput(string sceneNum, char input)
        {
            char[] validInputs = null;
            switch (sceneNum)
            {
                case "1-2":
                    validInputs = new char[] { 'a', 'b' };
                    break;
                case "1-3":
                    validInputs = new char[] { 'a', 'b' };
                    break;
                case "1-4":
                    validInputs = new char[] { 'a', 'b', 'c' };
                    break;
                case "1-5":
                    validInputs = new char[] { 'a', 'b', 'c' };
                    break;
                case "1-7":
                    validInputs = new char[] { 'a', 'b', 'c' };
                    break;
                case "2-1":
                    validInputs = new char[] { 'a', 'b' };
                    break;
                case "3-1":
                    validInputs = new char[] { 'a', 'b' };
                    break;
            }

            if (validInputs.Contains(input))
                return true;
            else
                return false;
        }

    }
}


