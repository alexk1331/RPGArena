namespace RPGArena
{
    partial class PvPPrep
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lcp1 = new System.Windows.Forms.Button();
            this.ccp1 = new System.Windows.Forms.Button();
            this.lcp2 = new System.Windows.Forms.Button();
            this.ccp2 = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.p1check = new System.Windows.Forms.Button();
            this.p2check = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(3, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(440, 467);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(440, 91);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(443, 467);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Player 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(795, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Player 2";
            // 
            // lcp1
            // 
            this.lcp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lcp1.Location = new System.Drawing.Point(12, 45);
            this.lcp1.Name = "lcp1";
            this.lcp1.Size = new System.Drawing.Size(139, 30);
            this.lcp1.TabIndex = 4;
            this.lcp1.Text = "Load character";
            this.lcp1.UseVisualStyleBackColor = true;
            this.lcp1.Click += new System.EventHandler(this.lcp1_Click);
            // 
            // ccp1
            // 
            this.ccp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ccp1.Location = new System.Drawing.Point(157, 45);
            this.ccp1.Name = "ccp1";
            this.ccp1.Size = new System.Drawing.Size(139, 30);
            this.ccp1.TabIndex = 5;
            this.ccp1.Text = "Create custom";
            this.ccp1.UseVisualStyleBackColor = true;
            this.ccp1.Click += new System.EventHandler(this.ccp1_Click);
            // 
            // lcp2
            // 
            this.lcp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lcp2.Location = new System.Drawing.Point(733, 45);
            this.lcp2.Name = "lcp2";
            this.lcp2.Size = new System.Drawing.Size(139, 30);
            this.lcp2.TabIndex = 6;
            this.lcp2.Text = "Load character";
            this.lcp2.UseVisualStyleBackColor = true;
            this.lcp2.Click += new System.EventHandler(this.lcp2_Click);
            // 
            // ccp2
            // 
            this.ccp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ccp2.Location = new System.Drawing.Point(588, 45);
            this.ccp2.Name = "ccp2";
            this.ccp2.Size = new System.Drawing.Size(139, 30);
            this.ccp2.TabIndex = 7;
            this.ccp2.Text = "Create custom";
            this.ccp2.UseVisualStyleBackColor = true;
            // 
            // start
            // 
            this.start.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.start.Location = new System.Drawing.Point(400, 15);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(80, 60);
            this.start.TabIndex = 8;
            this.start.Text = "Fight";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // p1check
            // 
            this.p1check.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.p1check.ForeColor = System.Drawing.Color.Red;
            this.p1check.Location = new System.Drawing.Point(332, 45);
            this.p1check.Name = "p1check";
            this.p1check.Size = new System.Drawing.Size(30, 30);
            this.p1check.TabIndex = 9;
            this.p1check.Text = "X";
            this.p1check.UseVisualStyleBackColor = true;
            this.p1check.Click += new System.EventHandler(this.p1check_Click);
            // 
            // p2check
            // 
            this.p2check.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.p2check.ForeColor = System.Drawing.Color.Red;
            this.p2check.Location = new System.Drawing.Point(522, 44);
            this.p2check.Name = "p2check";
            this.p2check.Size = new System.Drawing.Size(30, 30);
            this.p2check.TabIndex = 10;
            this.p2check.Text = "X";
            this.p2check.UseVisualStyleBackColor = true;
            this.p2check.Click += new System.EventHandler(this.p2check_Click);
            // 
            // PvPPrep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.p2check);
            this.Controls.Add(this.p1check);
            this.Controls.Add(this.start);
            this.Controls.Add(this.ccp2);
            this.Controls.Add(this.lcp2);
            this.Controls.Add(this.ccp1);
            this.Controls.Add(this.lcp1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "PvPPrep";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.PvPPrep_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button lcp1;
        private System.Windows.Forms.Button ccp1;
        private System.Windows.Forms.Button lcp2;
        private System.Windows.Forms.Button ccp2;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button p1check;
        private System.Windows.Forms.Button p2check;
    }
}