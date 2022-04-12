using System;
using System.Linq;

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
                    Console.WriteLine("Première scène : Combattez le dragon !");
                    Console.WriteLine("Le dragon a une peau épaisse, mais vous voyez une zone où le dragon a été endommagé, indiquant un point faible. ");
                    Console.WriteLine("Les ennemis reçoivent des points de dommage en fonction de deux facteurs : leur type d'armure et votre type d'attaque. \n (lacérer une armure faible, percer un haubert, frapper l'armure complète).");

                    Console.WriteLine("Vous subissez des dommages en fonction du type d'arme de l'ennemi et du mouvement de défense que vous décidez d'utiliser. \n(bloquer les armes légères, parer les armes moyennes, éviter les armes lourdes).");
                    //path 1, 2                                                //  
                    break;
                case "1-2":
                    Console.WriteLine("Deuxième scène : Aidez Ysuelt! \n ");
                    Console.WriteLine("Votre roi, le roi Marc, voulez que vous ramènes le cadeau du roi d'Irlande après avoir tué le dragon. Le cadeau est une jolie femme, que votre roi va épouser, elle s'appelle Yseult. Vous avez besoin de prendre un NAVIRE(4) pour la ramener.");
                    Console.WriteLine("Elle a le mal de mer, que vas-tu faire ? \n");
                    Console.WriteLine("Option A: L'ignorer complètement!");//path 2, 1
                    Console.WriteLine("Option B: Réconfortez(5)-elle en lui offrant du vin super cher."); //path 1, 3
                    break;
                case "1-3":
                    Console.WriteLine("Troisième scène: Succombez-vous à vos tentations ? \n");
                    Console.WriteLine("Vous tombez follement amoureux d'une femme après avoir bu le vin, qui était vraiment un PHILTRE(6) d'amour. Succombez-vous à vos tentations? \n");
                    Console.WriteLine("Option A: Oui! "); //path 3 , 1
                    Console.WriteLine("Option B: Non, je suis un chevalier respectable !"); //path 1, 4
                    break;
                case "1-4":
                    Console.WriteLine("Quatrième scène: Le roi que vous êtes mort ! \n");
                    Console.WriteLine("Yseult et le roi Marc se marient, mais vous êtes toujours amoureux d'Yseult. Vous décidez que le mieux est de vous exiler vous-même, afin de ne pas commettre de PÉCHÉS.(7)");
                    Console.WriteLine("La rumeur court que vous et Yseult avez une affaire et le roi que vous êtes mort ! \n");
                    Console.WriteLine("Option A: Parlez au roi et convainquez-il que cette personne ment et qu'il  se passe rien !"); // game win!
                    Console.WriteLine("Option B: S'enfuir avec Yseult"); // path 1, 5
                    Console.WriteLine("Option C: Combattez le roi !!!"); //path fight scene  --> path 6 1
                    break;
                case "1-5":
                    Console.WriteLine("Cinquième scène : Dans la cabane depuis des années \n ");
                    Console.WriteLine("Yseult et vous êtes cachés dans une cabane pendant des années, de peur que le roi vous trouve. Qu'allez-vous faire ? \n"); 
                    Console.WriteLine("Option A: Soyez un bon chevalier !"); //path 1, 6
                    Console.WriteLine("Option B: Pécher tous les jours !"); //path dead
                    Console.WriteLine("Option C: Tuer Ysuelt"); //path 4, 1
                    break;
                case "1-6":
                    Console.WriteLine(" \n Le roi vous avez trouvé une nuit et vous a vu dormir avec Yseult dans le même lit. Cependant, il remarque votre épée nue posée entre vous. Il échange votre épée avec la sienne, et échange la bague d'Yseult, vous pardonnant tous les deux.  \n \n");

                    Console.WriteLine("Sixième scène: Bataille numéro deux! \n");
                    //loadFightScene!
                    //win -> win!
                    //poisinneded -> path 1, 7
                    //lose - lose!
                    break;
                case "1-7":

                    Console.WriteLine("Seventh Scene: Allez chercher Yseult ! !!\n");
                    Console.WriteLine("Vous avez été empoisonné lors de votre dernière bataille, mais vous vous souvenez que Yseult vous a aidé à guérir un poison lorsque vous étiez dans les bois avec elle pendant plusieurs années. ");
                    Console.WriteLine("Vous dites à votre femme, qui s'appelle aussi Yseult, qu'elle doit demander à l'autre Yseult de l'aider. Kaherdin prend la mer avec votre galion, vous lui dites : 'Si elle est avec toi, HISSE(8) une voile blanche, sinon, hisse une voile noire '. ");
                    Console.WriteLine("Et tu dis à ta femme de regarder le MÀT(9) quand la NEF(10) reviendra, et de te dire de quelle couleur il est. ");

                    Console.WriteLine("\n Après avoir attendu pendant ce qui semble être des années, votre femme vous dit qu'elle voit un drapeau noir.Qu'allez-vous faire ? ");
                    Console.WriteLine("Option A: Vous mourrez parce que votre femme est une menteuse"); //normal ending
                    Console.WriteLine("Option B: Tuez votre femme parce qu'elle est ennuyeuse et menteuse."); //canibal ending
                    Console.WriteLine("Option C: Soyez forts !"); //strong knight ending!
                    break;

                     
                //Oops didn't help Yseult.
                case "2-1":
                    Console.WriteLine("Troisième scène, fin alternative : N'a pas aidé Yseult  \n");
                    Console.WriteLine("Option A: Mentir au roi"); // fight the king
                    Console.WriteLine("Option B: Présentez vos excuses!"); //imprisioned 
                    break;
                //Sinner's path
                case "3-1":
                    Console.WriteLine("Quatrième scène Fin alternative 2 : Pécheur(11). \n");
                    Console.WriteLine("Option A: Tuez le roi !"); // path 3, 2
                    Console.WriteLine("Option B: Présentez vos excuses!"); //killed by the king;\
                    break;
                case "3-2":
                    Console.WriteLine("Tuez le roi !");
                    //win loss
                    break;

                //Scardy Cat Win
                case "4-1":
                    Console.WriteLine("Vous avez enfui, bon travail.");
                    break;

                //Cannibal Loss.
                case "5-1":
                    Console.WriteLine("Vous avez tué votre femme et maintenant Kaherdin veut vous tuer, Combattez Kaherdin ! (mais vous êtes empoisonné et extrêmement faible donc vous mourrez)");
                    break;

                //Fight the king and take the kingdom.
                case "6-1":
                    Console.WriteLine("nous gagnons ceux..");
                    break;
                case "win":
                    Console.WriteLine("vous avez gagné le jeu !");
                    break;
                case "loss":
                    Console.WriteLine("vous avez perdu la partie");
                    Console.ReadLine();
                    break;


            }
        }


        public string runScene(string sceneNum)
        {
            string nextScene = "";
            char input = ']';
            Tristan.hp = 10;
            string[] fightScenes = new string[] { "1-1", "6-1", "3-2", "1-6" };
            if(!fightScenes.Contains(sceneNum))
            {
                Console.WriteLine("Choisissez:");
                input = Console.ReadLine().Trim().ToLower().ElementAt(0);
                while (!checkInput(sceneNum, input))
                {
                    Console.WriteLine("Choisissez:");
                    input = Console.ReadLine().Trim().ToLower().ElementAt(0);
                }
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
                    }
                    break;


                case "1-5":
                    if (input == 'a')
                    {
                        nextScene = "1-6";
                    }
                    else if (input == 'b')
                        nextScene = "bad";
                    else
                        nextScene = "4-1";
                    break;


                case "1-7":
                    if (input == 'a')
                        nextScene = "loss";
                    else if (input == 'b')
                        nextScene = "bad";
                    else
                        nextScene = "win";
                    break;
                case "2-1":
                    nextScene = "bad";
                    break;


                case "3-1":
                    if (input == 'a')
                        nextScene = "3-2";
                    else
                        nextScene = "bad";
                    break;


                case "4-1":
                    nextScene = "win";
                    break;

            }

            //FIGHT SCENES!!!!
            if (sceneNum == "1-1")
            {
                Enemy dragon = new Enemy("dragon");
                Console.WriteLine("-----Tristan-----");
                Console.WriteLine("Les points de vie de Tristan: " + Tristan.hp);
                Console.WriteLine("La puissance d'attaque de Tristan: " + Tristan.weaponDamage + "\n ");
                Console.WriteLine("--------Dragon-----------");
                Console.WriteLine("Les points de vie du dragon: " + dragon.hp);
                Console.WriteLine("La puissance d'attaque du dragon:" + dragon.weaponDamage);
                if (fight(Tristan, dragon))
                    nextScene = "1-2";
                else
                    nextScene = "loss";

            }
            if (nextScene == "6-1")
            {
                Console.WriteLine("Le roi désarme son épée, et vous charge en armure complète.");
                Enemy king = new Enemy("king");
                Console.WriteLine("-----Tristan-----");
                Console.WriteLine("Les points de vie de Tristan: " + Tristan.hp);
                Console.WriteLine("La puissance d'attaque de Tristan:  " + Tristan.weaponDamage + "\n ");
                Console.WriteLine("--------Roi-----------");
                Console.WriteLine("Les points de vie du Roi: " + king.hp);
                Console.WriteLine("La puissance d'attaque du Roi: " + king.weaponDamage);
                if (fight(Tristan, king))
                    nextScene = "win";
                else
                    nextScene = "bad";
            }
            if (nextScene == "3-2")
            {
                Console.WriteLine("Le roi désarme son épée, et vous charge en armure complète.");
                Enemy king = new Enemy("king");
                Console.WriteLine("-----Tristan-----");
                Console.WriteLine("Les points de vie de Tristan: " + Tristan.hp);
                Console.WriteLine("La puissance d'attaque de Tristan: " + Tristan.weaponDamage + "\n ");
                Console.WriteLine("--------Roi-----------");
                Console.WriteLine("Les points de vie du Roi: " + king.hp);
                Console.WriteLine("La puissance d'attaque du Roi: " + king.weaponDamage);
                if (fight(Tristan, king))
                    nextScene = "win";
                else
                    nextScene = "bad";
            }

            if (nextScene == "1-6")
            {
                loadScene("1-6");
                Enemy light = new Enemy("light");
                Enemy medium = new Enemy("medium");
                Enemy heavy = new Enemy("heavy");


                Console.WriteLine("Un combattant vous charge avec peu ou pas d'armure et une petite épée.");
                Console.WriteLine("-----Tristan-----");
                Console.WriteLine("Les points de vie de Tristan: " + Tristan.hp);
                Console.WriteLine("La puissance d'attaque de Tristan: " + Tristan.weaponDamage + "\n");
                Console.WriteLine("--------Enemys-----------");
                Console.WriteLine("Les points de vie du combatant:" + light.hp);
                Console.WriteLine("La puissance d'attaque du combatant" + light.weaponDamage);
                if (fight(Tristan, light))
                {
                    Console.WriteLine("Un combattant vous charge avec une énorme épée et une armure complète !");
                    Console.WriteLine("-----Tristan-----");
                    Console.WriteLine("Les points de vie de Tristan: " + Tristan.hp);
                    Console.WriteLine("La puissance d'attaque de Tristan" + Tristan.weaponDamage + "\n ");
                    Console.WriteLine("--------Enemy's stats-----------");
                    Console.WriteLine("Les points de vie de combatant:" + heavy.hp);
                    Console.WriteLine("La puissance d'attaque du combatant: " + heavy.weaponDamage);
                    if (fight(Tristan, heavy))
                    {
                        Console.WriteLine("Un combattant vous charge avec une épée et un haubert !");
                        Console.WriteLine("-----Tristan-----");
                        Console.WriteLine("Les points de vie de Tristan: " + Tristan.hp);
                        Console.WriteLine("La puissance d'attaque de Tristan" + Tristan.weaponDamage + "\n ");
                        Console.WriteLine("--------Enemy's stats-----------");
                        Console.WriteLine("Les points de vie de combatant:" + medium.hp);
                        Console.WriteLine("La puissance d'attaque du combatant: " + medium.weaponDamage);
                        if(fight(Tristan, medium))
                        {
                            nextScene = "win";
                        }
                    }
                    else
                        nextScene = "1-7";
                }
                else
                    nextScene = "loss";
            }


            if (nextScene == "win")
                return "win";
            else if (nextScene == "loss")
                return "loss";
            else
                return nextScene;
        }

        public bool fight(Player player, Enemy enemy)
        {
            var type = enemy.name;
            var fighting = true;
            while(fighting)
            {
                var inp = 0;
                Console.WriteLine("Choisissez une attaque:");
                Console.WriteLine("1: Lacérer \n 2.Percer \n 3.Cogner");
                while (inp<=0 || inp >4)
                    inp = Int32.Parse(Console.ReadLine().Trim().ToLower().Substring(0, 1));
                Tristan.attack(enemy, inp);
                Tristan.attack(enemy, inp);

                Console.WriteLine("--------" + type +"-----------");
                Console.WriteLine("Les points de vie de "+ type + ":"+ enemy.hp);
                Console.WriteLine("Choisissez une défense:");
                Console.WriteLine("1: Bloquer \n 2.Parer \n 3.Éviter");
                inp = 0;
                while (inp <= 0 || inp > 4)
                    inp = Int32.Parse(Console.ReadLine().Trim().ToLower().Substring(0,1));
                player.defend(enemy, inp);
                Console.WriteLine("-----Tristan-----");
                Console.WriteLine("Les points de vie de Tristan: " + Tristan.hp);
                Console.WriteLine("La puissance d'attaque de Tristan: " + Tristan.weaponDamage );
                if (enemy.hp <= 0 || player.hp <= 0)
                    fighting = false;
            }
            if (enemy.hp <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
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


