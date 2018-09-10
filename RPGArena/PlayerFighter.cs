using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace RPGArena
{
    [DataContract]
    public class PlayerFighter:Fighter
    {
        [DataMember]
        int expcur;
        [DataMember]
        int explvlup;
        [DataMember]
        public int stat_win;
        [DataMember]
        public int stat_lose;
        [DataMember]
        public int stat_draw;
        public PlayerFighter(string nm, int ec, int lvl, int str, int sp, int ag, int dur, int luc, int win, int lose, int draw)//peredacha infy persa pri sozdanii/zagruzke
        {
            expcur = ec;
            name = nm;
            level = lvl;
            strenght = str;
            speed = sp;
            agility = ag;
            durability = dur;
            luck = luc;
            explvlup = (int)Math.Pow(2, lvl);
            stat_win = win;
            stat_lose = lose;
            stat_draw = draw;
        }

        public PlayerFighter(PlayerFighter other)
        {
            this.expcur = other.expcur;
            this.name = other.name;
            this.level = other.level;
            this.strenght = other.strenght;
            this.speed = other.speed;
            this.agility = other.agility;
            this.durability = other.durability;
            this.luck = other.luck;
            this.explvlup = other.explvlup;
        }


        public int Win
        {
            get
            {
                return stat_win;
            }

            set
            {
                stat_win = value;
            }
        }
        public int Lose
        {
            get
            {
                return stat_lose;
            }

            set
            {
                stat_lose = value;
            }
        }
        public int Draw
        {
            get
            {
                return stat_draw;
            }

            set
            {
                stat_draw = value;
            }
        }
        public int Expcur//svoistvo nnuzhno v BattlePvE
        {
            get
            {
                return expcur;
            }

            set
            {
                expcur = value;
            }
        }

        public int Expneed//svoistvo nnuzhno v BattlePvE
        {
            get
            {
                return explvlup;
            }

            protected set
            {
                explvlup = value;
            }
        }
        public void save(PlayerFighter pers)//sohranenie
        {
            string path=Directory.GetCurrentDirectory()+@"\Save";
            if(!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
                DataContractJsonSerializer saver = new DataContractJsonSerializer(typeof(PlayerFighter));
                using (FileStream fs = new FileStream((path+@"\"+pers.Name+".json"), FileMode.Create))
                {
                    saver.WriteObject(fs, pers);
                }
            
            
        }

        static public PlayerFighter load(string nam)//zagruzka
        {
            string path = Directory.GetCurrentDirectory() + @"\Save";
            DataContractJsonSerializer loader = new DataContractJsonSerializer(typeof(PlayerFighter));
            using (FileStream fs = new FileStream((path + @"\" + nam + ".json"), FileMode.Open))
            {
                PlayerFighter loaded = (PlayerFighter)loader.ReadObject(fs);
                return loaded;
            }
            
        }

        static public void delete(string nam)//udalenie personazha
        {
            string path = Directory.GetCurrentDirectory() + @"\Save\"+nam+".json";
            File.Delete(path);
        }

        public void statist_change(int type)
        {
            switch(type)
            {
                case 1:
                    stat_win++;
                break;
                case 2:
                    stat_lose++;
                    break;
                case 3:
                    stat_draw++;
                    break;
            }
        }
        public int lvlupcheck()
        {
            int freestat=0;
            while(expcur >= explvlup)
            {
                level++;
                expcur = expcur - explvlup;
                freestat = freestat + 5;
                explvlup = (int)Math.Pow(2, level);
            }
            return freestat;
        }

        public void lvlup( int strad, int spad, int agad, int durad, int lucad)//izmenenie statov pri lvlupe
        {
            
            strenght = strenght+strad;
            speed = speed+spad;
            agility =agility+ agad;
            durability =durability+ durad;
            luck = luck+lucad;
        }

        public int expgot(bool win, int enemy_lvl, int dmgdeal, int dmggot)//podschet poluchenoi expi v konce boya
        {
            int recexp = 0;
            if(win)
            {
                recexp = enemy_lvl + ((dmgdeal + dmggot) / 10);
            }
            else { recexp= (dmgdeal + dmggot) / 10; }
            expcur = expcur + recexp;
            return recexp;
        }

    }
}
