
namespace WindowsFormsApp10
{
    partial class Form1
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.hemedti = new System.Windows.Forms.PictureBox();
            this.gameover = new System.Windows.Forms.PictureBox();
            this.boom = new System.Windows.Forms.PictureBox();
            this.greencar1 = new System.Windows.Forms.PictureBox();
            this.greencar2 = new System.Windows.Forms.PictureBox();
            this.car = new System.Windows.Forms.PictureBox();
            this.yellow2 = new System.Windows.Forms.PictureBox();
            this.yellow1 = new System.Windows.Forms.PictureBox();
            this.line2 = new System.Windows.Forms.PictureBox();
            this.line4 = new System.Windows.Forms.PictureBox();
            this.line3 = new System.Windows.Forms.PictureBox();
            this.line1 = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.hemedti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greencar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greencar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellow2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellow1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.line2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.line4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.line3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.line1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // hemedti
            // 
            this.hemedti.Image = global::WindowsFormsApp10.Properties.Resources.hemedti;
            this.hemedti.Location = new System.Drawing.Point(96, 20);
            this.hemedti.Name = "hemedti";
            this.hemedti.Size = new System.Drawing.Size(188, 145);
            this.hemedti.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hemedti.TabIndex = 11;
            this.hemedti.TabStop = false;
            // 
            // gameover
            // 
            this.gameover.Image = global::WindowsFormsApp10.Properties.Resources.gameover;
            this.gameover.Location = new System.Drawing.Point(95, 149);
            this.gameover.Name = "gameover";
            this.gameover.Size = new System.Drawing.Size(191, 137);
            this.gameover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gameover.TabIndex = 10;
            this.gameover.TabStop = false;
            // 
            // boom
            // 
            this.boom.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.boom.Image = global::WindowsFormsApp10.Properties.Resources.boom;
            this.boom.Location = new System.Drawing.Point(207, 292);
            this.boom.Name = "boom";
            this.boom.Size = new System.Drawing.Size(139, 141);
            this.boom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boom.TabIndex = 9;
            this.boom.TabStop = false;
            // 
            // greencar1
            // 
            this.greencar1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.greencar1.Image = global::WindowsFormsApp10.Properties.Resources.tank;
            this.greencar1.Location = new System.Drawing.Point(15, -2);
            this.greencar1.Name = "greencar1";
            this.greencar1.Size = new System.Drawing.Size(55, 94);
            this.greencar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.greencar1.TabIndex = 8;
            this.greencar1.TabStop = false;
            // 
            // greencar2
            // 
            this.greencar2.Image = global::WindowsFormsApp10.Properties.Resources.armycar;
            this.greencar2.Location = new System.Drawing.Point(321, 0);
            this.greencar2.Name = "greencar2";
            this.greencar2.Size = new System.Drawing.Size(51, 92);
            this.greencar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.greencar2.TabIndex = 7;
            this.greencar2.TabStop = false;
            // 
            // car
            // 
            this.car.Image = global::WindowsFormsApp10.Properties.Resources.da3ama;
            this.car.Location = new System.Drawing.Point(124, 331);
            this.car.Name = "car";
            this.car.Size = new System.Drawing.Size(56, 118);
            this.car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.car.TabIndex = 6;
            this.car.TabStop = false;
            // 
            // yellow2
            // 
            this.yellow2.BackColor = System.Drawing.Color.Yellow;
            this.yellow2.Location = new System.Drawing.Point(381, -2);
            this.yellow2.Name = "yellow2";
            this.yellow2.Size = new System.Drawing.Size(10, 463);
            this.yellow2.TabIndex = 5;
            this.yellow2.TabStop = false;
            // 
            // yellow1
            // 
            this.yellow1.BackColor = System.Drawing.Color.Yellow;
            this.yellow1.Location = new System.Drawing.Point(-1, -2);
            this.yellow1.Name = "yellow1";
            this.yellow1.Size = new System.Drawing.Size(10, 463);
            this.yellow1.TabIndex = 4;
            this.yellow1.TabStop = false;
            // 
            // line2
            // 
            this.line2.BackColor = System.Drawing.SystemColors.Control;
            this.line2.Location = new System.Drawing.Point(186, 129);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(15, 74);
            this.line2.TabIndex = 3;
            this.line2.TabStop = false;
            // 
            // line4
            // 
            this.line4.BackColor = System.Drawing.SystemColors.Control;
            this.line4.Location = new System.Drawing.Point(186, 375);
            this.line4.Name = "line4";
            this.line4.Size = new System.Drawing.Size(15, 74);
            this.line4.TabIndex = 2;
            this.line4.TabStop = false;
            // 
            // line3
            // 
            this.line3.BackColor = System.Drawing.SystemColors.Control;
            this.line3.Location = new System.Drawing.Point(186, 255);
            this.line3.Name = "line3";
            this.line3.Size = new System.Drawing.Size(15, 74);
            this.line3.TabIndex = 1;
            this.line3.TabStop = false;
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.SystemColors.Control;
            this.line1.Location = new System.Drawing.Point(186, 12);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(15, 74);
            this.line1.TabIndex = 0;
            this.line1.TabStop = false;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 60;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(389, 461);
            this.Controls.Add(this.hemedti);
            this.Controls.Add(this.gameover);
            this.Controls.Add(this.boom);
            this.Controls.Add(this.greencar1);
            this.Controls.Add(this.greencar2);
            this.Controls.Add(this.car);
            this.Controls.Add(this.yellow2);
            this.Controls.Add(this.yellow1);
            this.Controls.Add(this.line2);
            this.Controls.Add(this.line4);
            this.Controls.Add(this.line3);
            this.Controls.Add(this.line1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.hemedti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greencar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greencar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellow2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellow1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.line2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.line4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.line3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.line1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox line1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox line3;
        private System.Windows.Forms.PictureBox line4;
        private System.Windows.Forms.PictureBox line2;
        private System.Windows.Forms.PictureBox yellow1;
        private System.Windows.Forms.PictureBox yellow2;
        private System.Windows.Forms.PictureBox car;
        private System.Windows.Forms.PictureBox greencar2;
        private System.Windows.Forms.PictureBox greencar1;
        private System.Windows.Forms.PictureBox boom;
        private System.Windows.Forms.PictureBox gameover;
        private System.Windows.Forms.PictureBox hemedti;
        private System.Windows.Forms.Timer timer2;
    }
}

