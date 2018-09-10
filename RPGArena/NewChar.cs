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
    public partial class NewChar : Form
    {
        public NewChar()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox1.Text.Length < 16||e.KeyChar== Convert.ToChar(8))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            PlayerFighter currentplayer = new PlayerFighter(textBox1.Text, 0, 1, 1, 1, 1, 1, 1, 0, 0, 0);
            string path = Directory.GetCurrentDirectory() + @"\Save\"+textBox1.Text+".json";
            if(!File.Exists(path))
            {
                currentplayer.save(currentplayer);
                GameMain f1 = new GameMain();
                f1.Owner = this.Owner;
                f1.Show();
                f1.currplayer = currentplayer;
                this.Close();
            }
            else
            {
                MessageBox.Show("This name is already taken. Choose a different one, or delete existing character throught Load menu");
            }
            

        }
    }
}
