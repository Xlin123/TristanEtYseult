using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TristanEtYseult
{
    class Enemy
    {
        public string name { get; set; }
        public int hp { get; set; }
        public int weaponDamage { get; set; }
        public int speed { get; set; }
        public int armourStat { get; set; }

        public Enemy(string type)
        {
            name = type;
            switch (type)
            {
                case "dragon":
                    hp = 20;
                    weaponDamage = 1;
                    speed = 0;
                    armourStat = 0;
                    break;
                case "light":
                    hp = 5;
                    weaponDamage = 1;
                    speed = 6;
                    armourStat = 0;
                    break;
                case "medium":
                    hp = 6;
                    weaponDamage = 3;
                    speed = 3;
                    armourStat = 2;
                    break;
                case "heavy":
                    hp = 8;
                    weaponDamage = 6;
                    speed = 1;
                    armourStat = 3;
                    break;
                case "king":
                    hp = 8;
                    weaponDamage = 5;
                    speed = 2;
                    armourStat = 4;
                    break;
            }

        }

    }
}
