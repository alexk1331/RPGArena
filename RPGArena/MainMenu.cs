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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewChar f2 = new NewChar();
            this.Hide();
            f2.Owner = this;
            f2.ShowDialog();
            this.Show();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadChar f2 = new LoadChar();
            this.Hide();
            f2.Owner = this;
            f2.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PvPPrep nf = new PvPPrep();
            nf.Owner = this;
            this.Hide();
            nf.Show();
            
        }
    }
}
