using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPGArena
{
    public partial class GameMain : Form
    {
        public PlayerFighter currplayer;
        public GameMain()
        {
            InitializeComponent();
        }




        private Label[] stat = new Label[5];
        private void GameMain_Shown_1(object sender, EventArgs e)
        {
            this.Owner.Hide();
            redravform();
        }
        private void redravform()//pererisovka formy
        {
            int lvlupstatnum = currplayer.lvlupcheck();
            namelvl.Text = "Name: " + currplayer.Name + "     level " + currplayer.Level;
            exp.Text = "EXP: " + currplayer.Expcur + @"/" + currplayer.Expneed;
            str.Text = currplayer.Str.ToString();
            speed.Text = "" + currplayer.Speed;
            agil.Text = "" + currplayer.Agility;
            durab.Text = "" + currplayer.Durability;
            luck.Text = "" + currplayer.Luck;
            win.Text = currplayer.Win + "";
            lose.Text = currplayer.Lose + "";
            draw.Text = currplayer.Draw + "";

            //lvling up stuff            
            
            if(lvlupstatnum>0)
            {
                redravform();
                Button[] add = new Button[5];
                Button[] sub = new Button[5];
                for (int i = 0; i < stat.Length; i++)
                {
                    stattext.Visible = true;
                    statcount.Text = lvlupstatnum.ToString();
                    statcount.Visible = true;
                    conf.Visible = true;

                    stat[i] = new Label();
                    stat[i].Text = "0";
                    stat[i].Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
                    stat[i].Location = new Point(26, 13 + (40 * i));
                    stat[i].Width = 30;
                    panel1.Controls.Add(stat[i]);

                    add[i] = new Button();
                    add[i].Text = "+";
                    add[i].Font = new Font("Microsoft Sans Serif", 11, FontStyle.Regular);
                    add[i].Width = 20;
                    add[i].Height = 26;
                    add[i].Name = i.ToString();
                    add[i].Location = new Point(4, 10 + (40 * i));
                    panel1.Controls.Add(add[i]);
                    add[i].Click += new System.EventHandler(AddStat);

                    sub[i] = new Button();
                    sub[i].Text = "-";
                    sub[i].Font = new Font("Microsoft Sans Serif", 11, FontStyle.Regular);
                    sub[i].Width = 20;
                    sub[i].Height = 26;
                    sub[i].Name = i.ToString();
                    sub[i].Location = new Point(56, 10 + (40 * i));
                    panel1.Controls.Add(sub[i]);
                    sub[i].Click += new System.EventHandler(SubStat);
                }
                
            }
            
        }
        private void AddStat(object sender, EventArgs e)
        {
            
            if ((Int32.Parse(statcount.Text)>0))
            {
                Button b = sender as Button;
                int i = Int32.Parse(b.Name);
                stat[i].Text = (Int32.Parse(stat[i].Text) + 1).ToString();
                statcount.Text = (Int32.Parse(statcount.Text) - 1).ToString();
            }
            
            
        }

        private void SubStat(object sender, EventArgs e)
        {
            Button b = sender as Button;
            int i = Int32.Parse(b.Name);
            if (Int32.Parse(stat[i].Text)>0)
            {
                stat[i].Text = (Int32.Parse(stat[i].Text) - 1).ToString();
                statcount.Text = (Int32.Parse(statcount.Text) + 1).ToString();
            }
            

        }

        private void conf_Click(object sender, EventArgs e)
        {
            if(Int32.Parse(statcount.Text)==0)
            {
                currplayer.lvlup(Int32.Parse(stat[0].Text), Int32.Parse(stat[1].Text), Int32.Parse(stat[2].Text), Int32.Parse(stat[3].Text), Int32.Parse(stat[4].Text));
                currplayer.save(currplayer);
                panel1.Controls.Clear();
                stattext.Visible = false;
                statcount.Visible = false;
                conf.Visible = false;
                redravform();
                
            }
            else
            {
                MessageBox.Show("You haven`t used all stat points yet");
            }
        }

        private void FightStart_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(statcount.Text) == 0)
            {
                BattleForm bf = new BattleForm(currplayer);
                bf.Owner = this;

                this.Hide();
                bf.ShowDialog();

                this.Show();
                redravform();
            }
            else
            {
                MessageBox.Show("You haven`t used all stat points yet");
            }
        }

        private void menu_Click(object sender, EventArgs e)
        {
            menu.Visible = false;
            this.Owner.Show();
            this.Close();
        }

        private void GameMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(menu.Visible==false)
            {

            }
            else
            {
                Application.Exit();
            }
        }

        private void GameMain_Load(object sender, EventArgs e)
        {

        }
    }
}
