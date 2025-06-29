
namespace CarGame
{
    partial class Form2
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Score = new System.Windows.Forms.Label();
            this.playagain = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CarGame.Properties.Resources.gameover;
            this.pictureBox1.Location = new System.Drawing.Point(177, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(364, 211);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Font = new System.Drawing.Font("Andalus", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.ForeColor = System.Drawing.Color.Orange;
            this.Score.Location = new System.Drawing.Point(202, 357);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(197, 73);
            this.Score.TabIndex = 3;
            this.Score.Text = "SCORE: ";
            this.Score.Click += new System.EventHandler(this.Score_Click);
            // 
            // playagain
            // 
            this.playagain.AutoSize = true;
            this.playagain.Font = new System.Drawing.Font("Andalus", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playagain.ForeColor = System.Drawing.Color.Orange;
            this.playagain.Location = new System.Drawing.Point(202, 236);
            this.playagain.Name = "playagain";
            this.playagain.Size = new System.Drawing.Size(295, 73);
            this.playagain.TabIndex = 4;
            this.playagain.Text = "PLAY AGAIN";
            this.playagain.Click += new System.EventHandler(this.playagain_Click);
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Font = new System.Drawing.Font("Andalus", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.Orange;
            this.exit.Location = new System.Drawing.Point(202, 298);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(128, 73);
            this.exit.TabIndex = 5;
            this.exit.Text = "EXIT";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(734, 462);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.playagain);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label Score;
        public System.Windows.Forms.Label playagain;
        public System.Windows.Forms.Label exit;
    }
}