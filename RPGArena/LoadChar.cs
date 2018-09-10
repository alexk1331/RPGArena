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
    public partial class LoadChar : Form
    {
        public LoadChar()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadChar_Shown(object sender, EventArgs e)
        {
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
                a.Width = 515;
                a.Text = Path.GetFileNameWithoutExtension(save[i]) + "\n" + File.GetLastWriteTime(save[i]);

                panel1.Controls.Add(a);

                a.Click += new System.EventHandler(Loading); 
                


                
                //del butts
                Button d = new Button();
                d.Location = new Point(535, 10 + (60 * (save.Length - i - 1)));
                d.Height = 50;
                d.Width = 50;
                d.Text = "X";

                panel1.Controls.Add(d);

                d.Click += new System.EventHandler(Deleting);



                d.Name = Path.GetFileNameWithoutExtension(save[i]);
                a.Name = Path.GetFileNameWithoutExtension(save[i]);
                save[i] = Path.GetFileNameWithoutExtension(save[i]) + "\n" + File.GetLastWriteTime(save[i]);



            }
            panel1.Focus();
        }

        private void Deleting(object sender, EventArgs e)
        {
            Button d = sender as Button;
            DialogResult res = MessageBox.Show("Character "+d.Name+" will be deleted. Forever. Irreversible. Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (res == DialogResult.Yes)
            {
                string path = Directory.GetCurrentDirectory() + @"\Save" + @"\" + d.Name + ".json";
                if (File.Exists(path))
                {
                    File.Delete(path);
                    panel1.Controls.Clear();
                    LoadChar_Shown(this, e);
                    MessageBox.Show(d.Name + " was successfuly deleted");
                }
                else
                {
                    MessageBox.Show(d.Name + "Already not exists");
                }
               
                
            }
            if (res == DialogResult.No)
            {
                
            }
        }

        private void Loading(object sender, EventArgs e)
        {
            Button b = sender as Button;
            
            PlayerFighter currentplayer = PlayerFighter.load(b.Name);
            GameMain f1 = new GameMain();
            f1.Owner = this.Owner;
            f1.Show();
            f1.currplayer = currentplayer;
            this.Close();
            
        }

        private void LoadChar_Load(object sender, EventArgs e)
        {

        }
    }
}
