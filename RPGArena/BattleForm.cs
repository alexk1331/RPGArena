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
    public partial class BattleForm : Form
    {
        PlayerFighter currplayer1;
        AIFighter aif;
        Battle currbattle;

        string php;
        string aihp;

        int pturn;
        public BattleForm(PlayerFighter c)
        {
            InitializeComponent();

            currplayer1 = c;
            aif = new AIFighter(currplayer1.Level);

            currbattle = new Battle(currplayer1, aif);

            atcat.Click += action;
            dodge.Click += action;
            block.Click += action;

            

            namlvlai.Text = aif.Name + "\nLevel " + aif.Level;
            namelvl.Text = currplayer1.Name + "\nLevel " + currplayer1.Level;

            pturn = currbattle.BattleStart();
            changeturn(pturn);
            string fm="`s speed allows him to attack first!";
            if(pturn==2)
            {
                fm = currplayer1.Name + fm;
            }
            else
            {
                fm = aif.Name + fm;
            }
            battlelog.Text = currbattle.Message;
            battlelog.Text += DateTime.Now.ToString("HH:mm:ss") +": "+ fm + Environment.NewLine;
            battlelog.TextChanged += tb_scrldwn;
        }

        private void tb_scrldwn(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.SelectionStart = tb.Text.Length;
            tb.ScrollToCaret();

        }


        private void changeturn(int pt)
        {
            if(plhp.Text=="x")
            {
                php = @"/" + currbattle.Fphp;
                aihp = @"/" + currbattle.Sphp;
            }
            plhp.Text ="HP: "+ currbattle.Fphp + php;
            aihplab.Text ="HP: "+ currbattle.Sphp + aihp;

            if (pt == 2)
            {
                atcat.Text = "Attack";
                dodge.Visible = false;
                block.Visible = false;
            }
            else
            {
                dodge.Visible = true;
                block.Visible = true;
                atcat.Text = "Countrattack";
            }
        }

        private void action(object sender, EventArgs e)
        {
            Button butt = (Button)sender;
            if (currbattle.Pt == 2)
            {
                
                currbattle.EndMove(butt.Text, AIMind.choseact(aif, 0), currbattle.fp, aif);

            }
            else
            {
               
                currbattle.EndMove(AIMind.choseact(aif, 1), butt.Text,  aif, currbattle.fp);

            }
            pturn = currbattle.Pt;
            battlelog.Text += "--------------------------------------------------------------" + Environment.NewLine+currbattle.Message;
            changeturn(pturn);

            if(currbattle.Endf)
            {
                int z =currbattle.BattleEnd(currplayer1);
                battlelog.Text += "--------------------------------------------------------------" + Environment.NewLine + currbattle.Message;
                MessageBox.Show("Exp recieved: "+z);
                battlelog.Text += "--------------------------------------------------------------" + Environment.NewLine + "Exp recieved: "+z;
                atcat.Text = "Finish";
                dodge.Enabled = false;
                block.Enabled = false;
                surr.Enabled = false;
                atcat.Click -= action;
                atcat.Click += finish;
            }

        }

        private void finish(object sender, EventArgs e)
        {
            currplayer1.save(currplayer1);
            this.Close();
        }

        private void surr_Click(object sender, EventArgs e)
        {
            currplayer1.statist_change(2);
            currplayer1.save(currplayer1);
            this.Close();
        }

        private void BattleForm_Load(object sender, EventArgs e)
        {

        }
    }
}
