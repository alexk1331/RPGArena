using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace RPGArena
{
    [DataContract]
    public abstract class Fighter
    {
        [DataMember]
        protected string name;
        [DataMember]
        protected int level;
        [DataMember]
        protected int strenght;
        [DataMember]
        protected int speed;
        [DataMember]
        protected int agility;
        [DataMember]
        protected int durability;
        [DataMember]
        protected int luck;

        public string Name//svoistvo nnuzhno v BattlePvE
        {
            get
            {
                return name;
            }

            protected set
            {
                name = value;
            }
        }
        public int Luck//svoistvo nnuzhno v BattlePvE
        {
            get
            {
                return luck;
            }

            set
            {
                luck = value;
            }
        }

        public int Level//svoistvo nnuzhno v BattlePvE
        {
            get
            {
                return level;
            }

            set
            {
                level = value;
            }
        }
        public int Durability//svoistvo nnuzhno v BattlePvE
        {
            get
            {
                return durability;
            }

            set
            {
                durability = value;
            }
        }

        public int Agility//svoistvo nnuzhno v BattlePvE
        {
            get
            {
                return agility;
            }

            set
            {
                agility = value;
            }
        }
        public int Speed//svoistvo nnuzhno v BattlePvE
        {
            get
            {
                return speed;
            }

            set
            {
                speed = value;
            }
        }
        public int Str//svoistvo nnuzhno v BattlePvE
        {
            get
            {
                return strenght;
            }

            set
            {
                strenght = value;
            }
        }

        public int attack()
        {
            Random x = new Random();
            int dice = x.Next(0, 100);//brosok kubika na krit
            dice = dice + luck;//plus udacha
            int damage = strenght;
            if (dice>=100)
            {
                damage = damage * 2;//esli krit proknul - dmg udvaivaetsa
            }
            return damage;
        }

        public int block()
        {
            Random x = new Random();
            int dice = x.Next(0, 100);//brosok kubika na krit
            dice = dice + luck;//plus udacha
            int blocked = strenght;
            if (dice >= 100)
            {
                blocked = blocked * 2;//esli krit proknul - block ochen udachniy
            }
            return blocked;
        }

        public int dodge()
        {
            int dodged = agility;
            return dodged;
        }
    }
}
