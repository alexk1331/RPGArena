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
    public partial class BattleFormPvP : Form
    {
        PlayerFighter pf1;
        PlayerFighter pf2;
        BattlePvP currbattle;

        string php;
        string aihp;

        int pturn;
        public BattleFormPvP(PlayerFighter p1, PlayerFighter p2)
        {
            InitializeComponent();

            pf1 = p1;
            pf2 = p2;

            currbattle = new BattlePvP(p1, p2);
            atcat.Click += action;
            dodge.Click += action;
            block.Click += action;
            atcat2.Click += action;
            dodge2.Click += action;
            block2.Click += action;
            namlvlai.Text = pf2.Name + "\nLevel " + pf2.Level;
            namelvl.Text = pf1.Name + "\nLevel " + pf1.Level;

            pturn = currbattle.BattleStart();
            changeturn(pturn);
            string fm="`s speed allows him to attack first!";
            if(pturn==2)
            {
                fm = pf1.Name + fm;
            }
            else
            {
                fm = pf2.Name + fm;
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
                atcat.Enabled = false;
                dodge.Visible = false;
                block.Visible = false;
                dodge2.Visible = true;
                block2.Visible = true;
                atcat2.Text = "Countrattack";
                atcat2.Enabled = true;
            }
            else
            {
                dodge.Visible = true;
                block.Visible = true;
                atcat.Text = "Countrattack";
                atcat.Enabled = true;
                atcat2.Text = "Attack";
                atcat2.Enabled = false;
                dodge2.Visible = false;
                block2.Visible = false;
            }
        }

        private void action(object sender, EventArgs e)
        {
            Button butt = (Button)sender;
            if (currbattle.Pt == 2)
                {
                    currbattle.EndMove("Attack", butt.Text,  currbattle.fp, currbattle.sp);
                }
            else
                {
                    currbattle.EndMove(butt.Text,"Attack",   currbattle.sp, currbattle.fp);
                }
                pturn = currbattle.Pt;
                battlelog.Text += "--------------------------------------------------------------" + Environment.NewLine + currbattle.Message;
                changeturn(pturn);

                if (currbattle.Endf)
                {
                    currbattle.BattleEnd();
                    battlelog.Text += "--------------------------------------------------------------" + Environment.NewLine + currbattle.Message;
                    atcat.Text = "Finish";
                    dodge.Enabled = false;
                    block.Enabled = false;
                    surr.Enabled = false;
                    dodge2.Enabled = false;
                    block2.Enabled = false;
                    atcat2.Enabled = false;
                    atcat.Enabled = true;
                    atcat.Click -= action;
                    atcat.Click += finish;
                }
            
        }

        private void finish(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void surr_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void BattleForm_Load(object sender, EventArgs e)
        {

        }


    }
}
