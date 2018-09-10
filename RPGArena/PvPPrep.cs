using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RPGArena
{
    public partial class PvPPrep : Form
    {

        PlayerFighter p1;
        PlayerFighter p2;
        public PvPPrep()
        {
            InitializeComponent();
        }

        private void PvPPrep_Load(object sender, EventArgs e)
        {

        }

        private void p1check_Click(object sender, EventArgs e)
        {
            if(p1check.Text=="X")
            {
                p1check.ForeColor = System.Drawing.Color.Green;
                p1check.Text = ("\u2714");
            }
            else
            {
                p1check.ForeColor = System.Drawing.Color.Red;
                p1check.Text = ("X");
            }
            
        }

        private void p2check_Click(object sender, EventArgs e)
        {
            if (p2check.Text == "X")
            {
                p2check.ForeColor = System.Drawing.Color.Green;
                p2check.Text = ("\u2714");
            }
            else
            {
                p2check.ForeColor = System.Drawing.Color.Red;
                p2check.Text = ("X");
            }
        }

        private void lcp1_Click(object sender, EventArgs e)
        {
            load_butt_click(panel1);
        }

        private void load_butt_click(Panel panel1)
        {
            panel1.Controls.Clear();
            string path = Directory.GetCurrentDirectory() + @"\Save";
            var saves = Directory.GetFiles(path, "*.json");
            var sortsaves = saves.OrderBy(f => File.GetLastWriteTime(f));
            string[] save = sortsaves.ToArray();
            for (int i = save.Length - 1; i >= 0; i--)
            {
                //laod butts
                Button a = new Button();
                a.Location = new Point(10, 10 + (60 * (save.Length - i - 1)));
                a.Height = 50;
                a.Width = 400;
                a.Text = Path.GetFileNameWithoutExtension(save[i]) + "\n" + File.GetLastWriteTime(save[i]);

                panel1.Controls.Add(a);

                a.Click += new System.EventHandler(Select);

                a.Name = Path.GetFileNameWithoutExtension(save[i]);
                save[i] = Path.GetFileNameWithoutExtension(save[i]) + "\n" + File.GetLastWriteTime(save[i]);
            }
        }
        private void Select(object sender, EventArgs e)
        {
            Button b = sender as Button;
            if(b.Parent.Name=="panel1")
            {
                p1 = PlayerFighter.load(b.Name);
                selectp(panel1, p1);
            }
            else
            {
                p2 = PlayerFighter.load(b.Name);
                selectp(panel2, p2);
            }
        }

        private void lcp2_Click(object sender, EventArgs e)
        {
            load_butt_click(panel2);
        }

        private void selectp(Panel p, PlayerFighter cp)
        {
            p.Controls.Clear();
            Label namelvl = new Label();
            namelvl.AutoSize = true;
            namelvl.Font = new Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            namelvl.Location = new Point(20, 10);
            namelvl.Text = "Name: " + cp.Name + "     level " + cp.Level;
            p.Controls.Add(namelvl);
            Label str = new Label();
            str.AutoSize = true;
            str.Font = new Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            str.Location = new Point(20, 60);
            str.Text = "Strenght: "+cp.Str;
            p.Controls.Add(str);
            Label speed = new Label();
            speed.AutoSize = true;
            speed.Font = new Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            speed.Location = new Point(20, 100);
            speed.Text = "Speed: " + cp.Speed;
            p.Controls.Add(speed);
            Label agil = new Label();
            agil.AutoSize = true;
            agil.Font = new Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            agil.Location = new Point(20, 140);
            agil.Text = "Agility: " + cp.Agility;
            p.Controls.Add(agil);
            Label durab = new Label();
            durab.AutoSize = true;
            durab.Font = new Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            durab.Location = new Point(20, 180);
            durab.Text = "Durability: " + cp.Durability;
            p.Controls.Add(durab);
            Label luck = new Label();
            luck.AutoSize = true;
            luck.Font = new Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            luck.Location = new Point(20, 220);
            luck.Text = "Luck: " + cp.Luck;
            p.Controls.Add(luck);
        }

        private void start_Click(object sender, EventArgs e)
        {
            if(p1check.Text== "\u2714"&&p2check.Text== "\u2714"&&p1!=null&&p2!=null)
            {
                BattleFormPvP n = new BattleFormPvP(p1, p2);
                n.Owner = Owner;
                n.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Not all players are ready");
            }
        }

        private void ccp1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not implemented");
        }


    }
}
