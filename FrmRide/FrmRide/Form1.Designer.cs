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
            this.pnlGame = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.tmrPlayer = new System.Windows.Forms.Timer(this.components);
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tmrRock = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // pnlGame
            // 
            this.pnlGame.BackColor = System.Drawing.Color.Silver;
            this.pnlGame.Location = new System.Drawing.Point(12, 73);
            this.pnlGame.Name = "pnlGame";
            this.pnlGame.Size = new System.Drawing.Size(538, 376);
            this.pnlGame.TabIndex = 0;
            this.pnlGame.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlGame_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Goudy Old Style", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(191, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Big Lenny\'s";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(221, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Wild Ride";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(557, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(557, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Score";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(561, 196);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(18, 21);
            this.lblScore.TabIndex = 8;
            this.lblScore.Text = "0";
            // 
            // tmrPlayer
            // 
            this.tmrPlayer.Enabled = true;
            this.tmrPlayer.Interval = 1;
            this.tmrPlayer.Tick += new System.EventHandler(this.tmrPlayer_Tick);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(561, 98);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 9;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(561, 371);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(127, 36);
            this.btnStart.TabIndex = 10;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(561, 413);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 36);
            this.button1.TabIndex = 11;
            this.button1.Text = "Stop";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tmrRock
            // 
            this.tmrRock.Enabled = true;
            this.tmrRock.Interval = 1;
            this.tmrRock.Tick += new System.EventHandler(this.tmrRock1_Tick);
            // 
            // frmRide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 461);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlGame);
            this.KeyPreview = true;
            this.Name = "frmRide";
            this.Text = "Big Lenny\'s Wild Ride";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmRide_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmRide_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlGame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Timer tmrPlayer;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer tmrRock;
    }
}

