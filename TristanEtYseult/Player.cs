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
                    weaponDamage = 5;
                    speed = 1;
                    break;
                case "short sword and shield":
                    weaponDamage = 1;
                    armourStat += 2;
                    speed = 4;
                    break;
                case "mace":
                    weaponDamage = 3;
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
    
        //defend

    }
}
