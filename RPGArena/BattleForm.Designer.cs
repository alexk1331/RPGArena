namespace RPGArena
{
    partial class BattleForm
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
            this.namelvl = new System.Windows.Forms.Label();
            this.namlvlai = new System.Windows.Forms.Label();
            this.atcat = new System.Windows.Forms.Button();
            this.dodge = new System.Windows.Forms.Button();
            this.block = new System.Windows.Forms.Button();
            this.battlelog = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.plhp = new System.Windows.Forms.Label();
            this.aihplab = new System.Windows.Forms.Label();
            this.surr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // namelvl
            // 
            this.namelvl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.namelvl.Location = new System.Drawing.Point(12, 12);
            this.namelvl.Name = "namelvl";
            this.namelvl.Size = new System.Drawing.Size(182, 55);
            this.namelvl.TabIndex = 1;
            this.namelvl.Text = "1234567890123456";
            // 
            // namlvlai
            // 
            this.namlvlai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.namlvlai.Location = new System.Drawing.Point(706, 11);
            this.namlvlai.Name = "namlvlai";
            this.namlvlai.Size = new System.Drawing.Size(166, 55);
            this.namlvlai.TabIndex = 2;
            this.namlvlai.Text = "label1";
            // 
            // atcat
            // 
            this.atcat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.atcat.Location = new System.Drawing.Point(10, 320);
            this.atcat.Name = "atcat";
            this.atcat.Size = new System.Drawing.Size(160, 40);
            this.atcat.TabIndex = 3;
            this.atcat.Text = "Attack";
            this.atcat.UseVisualStyleBackColor = true;
            // 
            // dodge
            // 
            this.dodge.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dodge.Location = new System.Drawing.Point(10, 380);
            this.dodge.Name = "dodge";
            this.dodge.Size = new System.Drawing.Size(160, 40);
            this.dodge.TabIndex = 4;
            this.dodge.Text = "Dodge";
            this.dodge.UseVisualStyleBackColor = true;
            // 
            // block
            // 
            this.block.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.block.Location = new System.Drawing.Point(10, 440);
            this.block.Name = "block";
            this.block.Size = new System.Drawing.Size(160, 40);
            this.block.TabIndex = 5;
            this.block.Text = "Block";
            this.block.UseVisualStyleBackColor = true;
            // 
            // battlelog
            // 
            this.battlelog.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.battlelog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.battlelog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.battlelog.Location = new System.Drawing.Point(200, 12);
            this.battlelog.Multiline = true;
            this.battlelog.Name = "battlelog";
            this.battlelog.ReadOnly = true;
            this.battlelog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.battlelog.Size = new System.Drawing.Size(500, 537);
            this.battlelog.TabIndex = 0;
            // 
            // plhp
            // 
            this.plhp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plhp.Location = new System.Drawing.Point(12, 68);
            this.plhp.Name = "plhp";
            this.plhp.Size = new System.Drawing.Size(182, 55);
            this.plhp.TabIndex = 6;
            this.plhp.Text = "x";
            // 
            // aihplab
            // 
            this.aihplab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aihplab.Location = new System.Drawing.Point(706, 68);
            this.aihplab.Name = "aihplab";
            this.aihplab.Size = new System.Drawing.Size(166, 55);
            this.aihplab.TabIndex = 7;
            this.aihplab.Text = "1234567890123456";
            // 
            // surr
            // 
            this.surr.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surr.Location = new System.Drawing.Point(10, 167);
            this.surr.Name = "surr";
            this.surr.Size = new System.Drawing.Size(160, 40);
            this.surr.TabIndex = 8;
            this.surr.Text = "Surrender";
            this.surr.UseVisualStyleBackColor = true;
            this.surr.Click += new System.EventHandler(this.surr_Click);
            // 
            // BattleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.surr);
            this.Controls.Add(this.aihplab);
            this.Controls.Add(this.plhp);
            this.Controls.Add(this.block);
            this.Controls.Add(this.dodge);
            this.Controls.Add(this.atcat);
            this.Controls.Add(this.namlvlai);
            this.Controls.Add(this.namelvl);
            this.Controls.Add(this.battlelog);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "BattleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RPGArena";
            this.Load += new System.EventHandler(this.BattleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label namelvl;
        private System.Windows.Forms.Label namlvlai;
        private System.Windows.Forms.Button atcat;
        private System.Windows.Forms.Button dodge;
        private System.Windows.Forms.Button block;
        private System.Windows.Forms.TextBox battlelog;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label plhp;
        private System.Windows.Forms.Label aihplab;
        private System.Windows.Forms.Button surr;
    }
}