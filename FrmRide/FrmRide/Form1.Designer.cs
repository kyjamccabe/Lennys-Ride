namespace FrmRide
{
    partial class frmRide
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRide));
            this.pnlGame = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.tmrPlayer = new System.Windows.Forms.Timer(this.components);
            this.txtName = new System.Windows.Forms.TextBox();
            this.tmrRock = new System.Windows.Forms.Timer(this.components);
            this.tmrReset = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuStart = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStop = new System.Windows.Forms.ToolStripMenuItem();
            this.label5 = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.lblRestart = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblHighscore = new System.Windows.Forms.Label();
            this.pnlGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlGame
            // 
            this.pnlGame.BackColor = System.Drawing.Color.Silver;
            this.pnlGame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlGame.BackgroundImage")));
            this.pnlGame.Controls.Add(this.lblRestart);
            this.pnlGame.Controls.Add(this.pictureBox1);
            this.pnlGame.Location = new System.Drawing.Point(12, 73);
            this.pnlGame.Name = "pnlGame";
            this.pnlGame.Size = new System.Drawing.Size(538, 376);
            this.pnlGame.TabIndex = 0;
            this.pnlGame.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlGame_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 354);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(538, 22);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Goudy Old Style", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(549, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Big Lenny\'s";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(585, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Wild Ride";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(551, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(568, 269);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(18, 21);
            this.lblScore.TabIndex = 8;
            this.lblScore.Text = "0";
            // 
            // tmrPlayer
            // 
            this.tmrPlayer.Interval = 1;
            this.tmrPlayer.Tick += new System.EventHandler(this.tmrPlayer_Tick);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(555, 185);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 9;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // tmrRock
            // 
            this.tmrRock.Interval = 1;
            this.tmrRock.Tick += new System.EventHandler(this.tmrRock_Tick);
            // 
            // tmrReset
            // 
            this.tmrReset.Interval = 1;
            this.tmrReset.Tick += new System.EventHandler(this.tmrReset_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkGray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuStart,
            this.mnuStop});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(700, 29);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuStart
            // 
            this.mnuStart.BackColor = System.Drawing.Color.Transparent;
            this.mnuStart.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuStart.Name = "mnuStart";
            this.mnuStart.Size = new System.Drawing.Size(53, 25);
            this.mnuStart.Text = "Start";
            this.mnuStart.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // mnuStop
            // 
            this.mnuStop.BackColor = System.Drawing.Color.Transparent;
            this.mnuStop.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuStop.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.mnuStop.Name = "mnuStop";
            this.mnuStop.Size = new System.Drawing.Size(51, 25);
            this.mnuStop.Text = "Stop";
            this.mnuStop.Click += new System.EventHandler(this.mnuStop_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(556, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Score";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(557, 208);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 20);
            this.lblError.TabIndex = 13;
            // 
            // lblRestart
            // 
            this.lblRestart.AutoSize = true;
            this.lblRestart.Font = new System.Drawing.Font("Goudy Old Style", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestart.Location = new System.Drawing.Point(146, 17);
            this.lblRestart.Name = "lblRestart";
            this.lblRestart.Size = new System.Drawing.Size(237, 36);
            this.lblRestart.TabIndex = 14;
            this.lblRestart.Text = "Press R to restart.";
            this.lblRestart.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(556, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 21);
            this.label4.TabIndex = 14;
            this.label4.Text = "HighScore";
            // 
            // lblHighscore
            // 
            this.lblHighscore.AutoSize = true;
            this.lblHighscore.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighscore.Location = new System.Drawing.Point(556, 356);
            this.lblHighscore.Name = "lblHighscore";
            this.lblHighscore.Size = new System.Drawing.Size(0, 21);
            this.lblHighscore.TabIndex = 15;
            // 
            // frmRide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(700, 461);
            this.Controls.Add(this.lblHighscore);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlGame);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmRide";
            this.Text = "Big Lenny\'s Wild Ride";
            this.Load += new System.EventHandler(this.frmRide_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmRide_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmRide_KeyUp);
            this.pnlGame.ResumeLayout(false);
            this.pnlGame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlGame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Timer tmrPlayer;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Timer tmrRock;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer tmrReset;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuStart;
        private System.Windows.Forms.ToolStripMenuItem mnuStop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblRestart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblHighscore;
    }
}

