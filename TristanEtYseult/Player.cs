using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TristanEtYseult
{
    class Player
    {
        public int hp { get; set; }
        public int weaponDamage { get; set; }
        public int speed { get; set; }
        public int armourStat { get; set; }

        public Player(string weapon, string armour)
        {
            hp = 10;
            armourStat = 0;
            //weapons
            switch (weapon)
            {
                case "greatsword":
                    weaponDamage = 7;
                    speed = 1;
                    break;
                case "short sword and shield":
                    weaponDamage = 3;
                    armourStat += 2;
                    speed = 4;
                    break;
                case "mace":
                    weaponDamage = 5;
                    speed = 3;
                    break;
            }


            //armour
            if(armour == "chainmail")
            {
                armourStat += 2;
                speed += 2;
            }
            else
            {
                armourStat += 4;
                speed -= 1;
            }

        }


        //attack

        //0 light, 2med, 3 heavy
        public void attack(Enemy enemy, int input)
        {

            //slash
            if(input == 1)
            {
                if (enemy.armourStat == 0)
                    enemy.hp -= (weaponDamage - enemy.armourStat) + 1;
                else if (enemy.armourStat == 1)
                    enemy.hp -= (weaponDamage - enemy.armourStat);
                else
                    enemy.hp -= (weaponDamage - enemy.armourStat) - 1;
            }


            //pierce
            else if(input == 2)
            {
                if (enemy.armourStat == 0)
                    enemy.hp -= (weaponDamage - enemy.armourStat);
                else if (enemy.armourStat == 1)
                    enemy.hp -= (weaponDamage - enemy.armourStat) + 1;
                else
                    enemy.hp -= (weaponDamage - enemy.armourStat);
            }

            //bash
                
            else
            {
                if (enemy.armourStat == 0)
                    enemy.hp -= (weaponDamage - enemy.armourStat) - 1;
                else if (enemy.armourStat == 1)
                    enemy.hp -= (weaponDamage - enemy.armourStat);
                else
                    enemy.hp -= (weaponDamage - enemy.armourStat) + 1;
            }
        }

        //defence issues due to substracting negative numbers, which add to hp... 

        public void defend(Enemy enemy, int input)
        {
            //block
            if (input == 1)
            {
                if (enemy.armourStat == 1)
                    hp -= (enemy.weaponDamage - armourStat);
                else
                    hp -= (enemy.weaponDamage - armourStat) - 1;
            }


            //parry
            else if (input == 2)
            {
                if (enemy.armourStat == 0)
                    hp -= (enemy.weaponDamage - armourStat);
                else if (enemy.armourStat == 1)
                    hp -= (enemy.weaponDamage - armourStat) + 1;
                else
                    hp -= (enemy.weaponDamage - armourStat);
            }

            //dodge

            else
            {
                if (enemy.armourStat == 0)
                    hp -= (enemy.weaponDamage - armourStat) - 1;
                else if (enemy.armourStat == 1)
                    hp -= (enemy.weaponDamage - armourStat);
                else
                    hp -= (enemy.weaponDamage - armourStat) + 1;
            }
        }

    }
}
