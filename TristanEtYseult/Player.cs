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

        public Player(int weapon, int armour)
        {
            hp = 10;
            armourStat = 0;
            //weapons
            switch (weapon)
            {
                case 1:
                    weaponDamage = 5;
                    speed = 1;
                    break;
                case 2:
                    weaponDamage = 2;
                    armourStat += 1;
                    speed = 4;
                    break;
                case 3:
                    weaponDamage = 3;
                    speed = 3;
                    break;
            }


            //armour
            if(armour == 1)
            {
                armourStat += 1;
                speed += 2;
            }
            else
            {
                armourStat += 2;
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

   

        public void defend(Enemy enemy, int input)
        {
            //block
            if (input == 1)
            {
                if ((enemy.weaponDamage - armourStat) > 0)
                {
                    if (enemy.armourStat == 1)
                        hp -= (enemy.weaponDamage - armourStat);
                    else if (enemy.armourStat == 3)
                        hp -= (enemy.weaponDamage - armourStat) + 1;
                    else
                        hp -= (enemy.weaponDamage - armourStat) - 1;
                }
                else
                    Console.WriteLine("Vous l'avez bloqué en utilisant votre armure, et n'avez subi aucun dommage.");
            }


            //parry
            else if (input == 2)
            {
                if ((enemy.weaponDamage - armourStat) > 0)
                {
                    if (enemy.armourStat == 0)
                        hp -= (enemy.weaponDamage - armourStat);
                    else if (enemy.armourStat == 1)
                        hp -= (enemy.weaponDamage - armourStat) + 1;
                    else
                        hp -= (enemy.weaponDamage - armourStat) ;
                }
                else
                    Console.WriteLine("Vous l'avez bloqué en utilisant votre armure, et n'avez subi aucun dommage.");
            }

            //dodge

            else
            {
                if ((enemy.weaponDamage - armourStat) > 0)
                {
                    if (enemy.armourStat == 0)
                        hp -= (enemy.weaponDamage - armourStat) - 1;
                    else if (enemy.armourStat == 1)
                        hp -= (enemy.weaponDamage - armourStat);
                    else
                        hp -= (enemy.weaponDamage - armourStat) + 1;
                }
                else
                    Console.WriteLine("Vous l'avez bloqué en utilisant votre armure, et n'avez subi aucun dommage.");
            }
        }

    }
}
