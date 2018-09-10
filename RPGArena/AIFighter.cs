using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGArena
{
    class AIFighter:Fighter
    {
        public AIFighter(int player_lvl)//sozdanie botov
        {
            name = "AIFighter";
            Random x = new Random();
            int lvl_range = x.Next(-1, 2);
            level = player_lvl+lvl_range;//lvl bota=lvl igroka+-1
            if (level < 1) { level = 1; }

            strenght=1;
            speed = 1;
            agility = 1;
            durability = 1;
            luck = 1;
            for(int i=1; i<=level*5-5;i++)//sluchainoe raspredelenie statov botam osnovivaya na lvl igroka
            {
                int statup = x.Next(1, 6);
                switch(statup)
                {
                    case 1:
                        strenght++;
                        break;
                    case 2:
                        speed++;
                        break;
                    case 3:
                        agility++;
                        break;
                    case 4:
                        durability++;
                        break;
                    case 5:
                        luck++;
                        break;
                }
            }
        }


    }
}
