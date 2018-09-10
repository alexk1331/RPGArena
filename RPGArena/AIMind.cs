using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGArena
{
    static class AIMind
    {
        public static string choseact(AIFighter f, int role)
        {
            string a= "Attack";

            if(role==0)
            {
                a = "Countrattack";
                int chance = f.Str + f.Agility + f.Agility+f.Str;
                Random x = new Random();
                int chose = x.Next(0, chance+1);
                if(chose>f.Str+f.Agility&&chose<= f.Str + f.Agility + f.Agility)
                {
                    a = "Dodge";
                }
                else if(chose> f.Str + f.Agility + f.Agility)
                {
                    a = "Block";
                }
                
            }

            return a;
        }

    }
}
