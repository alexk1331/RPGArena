using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RPGArena
{
    class BattlePvE
    {
        public PlayerFighter fP;
        AIFighter fAI;
        int speeddif;
        int prevturn;
        int durp;
        int durai;
        bool battleend;
        string message;


        public BattlePvE(PlayerFighter p, AIFighter a)
            {
            fP = new PlayerFighter(p);
            fAI = a;
            speeddif = 0;
            prevturn = 0;
            durp = fP.Durability;
            durai = fAI.Durability;
            battleend = false;
            message = DateTime.Now.ToString("HH:mm:ss") + ": Battle starts: " +fP.Name+" vs AIFighter" + Environment.NewLine;
            }
        public bool Endf
        {
            get
            {
                return battleend;
            }

            protected set
            {
                battleend = value;
            }
        }

        public int hpp
        {
            get
            {
                return fP.Durability;
            }

        }

        public int aihp
        {
            get
            {
                return fAI.Durability;
            }

        }

        public int Pt
        {
            get
            {
                return prevturn;
            }

            protected set
            {
                prevturn = value;
            }
        }

        public string Message
        {
            get
            {
                return message;
            }

            protected set
            {
                message = value;
            }
        }



        public int BattleStart()
        {
            int sppl = fP.Speed;
            int spai = fAI.Speed;
            if(sppl>spai)
            {
                prevturn = 2;
            }
            else if(sppl<spai)
            {
                prevturn = 1;
            }
            else
            {
                Random x = new Random();
                prevturn = x.Next(1, 3);
            }
            return prevturn;
        }

        public void EndMove(string actp1, string actp2, Fighter f1, Fighter f2)
        {
            if(actp1=="Attack"&&actp2 == "Countrattack")
            {
                Attack_CountrAttack(f1, f2);
            }
            else if(actp1 == "Attack" && actp2 == "Dodge")
            {
                Attack_Dodge(f1, f2);
            }
            else if(actp1 == "Attack" && actp2 == "Block")
            {
                Attack_Block(f1, f2);
            }

            if(fP.Durability<=0||fAI.Durability<=0)//konec boya
            {
                if(fP.Durability<0)
                {
                    fP.Durability = 0;
                }
                if(fAI.Durability<0)
                {
                    fAI.Durability = 0;
                }
                battleend = true;
                
            } 

            if(speeddif>Math.Min(fP.Speed, fAI.Speed))//smena hoda
            {
                speeddif = speeddif - Math.Min(fP.Speed, fAI.Speed);
            }
            else
            {
                if(prevturn==1)
                {
                    prevturn = 2;
                }
                else
                {
                    prevturn = 1;
                }
            }
            speeddif = speeddif + Math.Abs(fP.Speed - fAI.Speed);
            
        }
            

        public int BattleEnd(PlayerFighter player)
        {
            message = DateTime.Now.ToString("HH:mm:ss") + "BattleEnded\n" + Environment.NewLine;
            bool win = true;
            if (fP.Durability <= 0)
            {
                win = false;                
            }

            int win2 = 1;
            if (fP.Durability <= 0)
            {
                
                win2 = 2;
                if (fAI.Durability <= 0)
                {
                    message = message + DateTime.Now.ToString("HH:mm:ss") +": It`s a draw!" + Environment.NewLine;
                    win2 = 3;
                }
                else
                {
                    message = message + DateTime.Now.ToString("HH:mm:ss") + ": Winner is " + fAI.Name + Environment.NewLine;
                }
            }
            else
            {
                message = message + DateTime.Now.ToString("HH:mm:ss") + ": Winner is " + fP.Name + Environment.NewLine;
            }

            int z=player.expgot(win, fAI.Level, durai - fAI.Durability, durp - fP.Durability);
            player.statist_change(win2);
            return z;
        }

        public void Attack_CountrAttack(Fighter f1, Fighter f2)
        {
            int agmodf1 = f1.Agility - f2.Agility;
            int agmodf2 = f2.Agility - f1.Agility;
            Random x = new Random();
            int missf1 = x.Next(0, 100)+agmodf1+10;
            int missf2 = x.Next(0, 100) + agmodf2-10;
            message = DateTime.Now.ToString("HH:mm:ss") + (": "+f1.Name+" is attacking \n"+Environment.NewLine);
            if(missf1>=50)
            {
                f2.Durability = f2.Durability - f1.attack();
                message = message + DateTime.Now.ToString("HH:mm:ss") + ": "+f1.Name+" dealed "+f1.attack()+" damage \n" + Environment.NewLine;
            }
            else
            {
                message = message + DateTime.Now.ToString("HH:mm:ss") +": "+ f1.Name + " missed \n" + Environment.NewLine;
            }
            message = message+(DateTime.Now.ToString("HH:mm:ss") + ": "+f2.Name + " counterattack \n") + Environment.NewLine;
            if (missf2 >= 50)
            {
                f1.Durability = f1.Durability - f2.attack();
                message = message + DateTime.Now.ToString("HH:mm:ss") + ": "+f2.Name + " dealed " + f2.attack() + " damage \n" + Environment.NewLine;
            }
            else
            {
                message = message + DateTime.Now.ToString("HH:mm:ss") + ": "+f2.Name + " missed \n" + Environment.NewLine;
            }
        }

        public void Attack_Dodge(Fighter f1, Fighter f2)
        {
            int agmod = f1.Agility - f2.Agility;
            Random x = new Random();
            int miss = x.Next(0, 100) + agmod;
            message = (DateTime.Now.ToString("HH:mm:ss") + ": "+f1.Name + " is attacking \n" + Environment.NewLine + DateTime.Now.ToString("HH:mm:ss") + ": " + f2.Name+" trying to dodge \n" + Environment.NewLine);
            if (miss >= 50)
            {
                f2.Durability = f2.Durability - f1.attack();
                message = message+ DateTime.Now.ToString("HH:mm:ss") + ": "+"Dodge failed \n" + Environment.NewLine + DateTime.Now.ToString("HH:mm:ss") + ": " + f1.Name + " dealed " + f1.attack() + " damage \n" + Environment.NewLine;
            }
            else
            {
                message = message + DateTime.Now.ToString("HH:mm:ss") + ": "+f2.Name + " successfully dodged. No damage taken \n" + Environment.NewLine;
            }

        }

        public void Attack_Block(Fighter f1, Fighter f2)
        {
            message = (DateTime.Now.ToString("HH:mm:ss") + ": "+f1.Name + " is attacking \n" + Environment.NewLine + DateTime.Now.ToString("HH:mm:ss") + ": " + f2.Name + " blocking \n" + Environment.NewLine);
            int dmg = f2.block() - f1.attack();
            if(dmg>=0)
            {
                dmg = 0;
                message = message + DateTime.Now.ToString("HH:mm:ss") + ": " + "All damage blocked" + Environment.NewLine;
            }
            else
            {
                dmg = Math.Abs(dmg);
                message=message+ DateTime.Now.ToString("HH:mm:ss") + ": " + f2.Name+" blocked "+f2.block()+" damage\n" + Environment.NewLine + DateTime.Now.ToString("HH:mm:ss") + ": " + f1.Name+" dealed "+ dmg+" damage" + Environment.NewLine;
            }
            f2.Durability = f2.Durability - dmg;
        }

    }
}
