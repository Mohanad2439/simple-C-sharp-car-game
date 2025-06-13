
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.car1 = new System.Windows.Forms.PictureBox();
            this.car2 = new System.Windows.Forms.PictureBox();
            this.Maincar = new System.Windows.Forms.PictureBox();
            this.yellow2 = new System.Windows.Forms.PictureBox();
            this.yellow1 = new System.Windows.Forms.PictureBox();
            this.line2 = new System.Windows.Forms.PictureBox();
            this.line4 = new System.Windows.Forms.PictureBox();
            this.line3 = new System.Windows.Forms.PictureBox();
            this.line1 = new System.Windows.Forms.PictureBox();
            this.line6 = new System.Windows.Forms.PictureBox();
            this.line8 = new System.Windows.Forms.PictureBox();
            this.line7 = new System.Windows.Forms.PictureBox();
            this.line5 = new System.Windows.Forms.PictureBox();
            this.Score_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.car1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maincar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellow2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellow1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.line2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.line4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.line3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.line1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.line6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.line8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.line7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.line5)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 60;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // car1
            // 
            this.car1.BackColor = System.Drawing.Color.Transparent;
            this.car1.Image = global::WindowsFormsApp10.Properties.Resources.YellowCar;
            this.car1.Location = new System.Drawing.Point(190, 60);
            this.car1.Name = "car1";
            this.car1.Size = new System.Drawing.Size(55, 94);
            this.car1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.car1.TabIndex = 8;
            this.car1.TabStop = false;
            this.car1.Click += new System.EventHandler(this.greencar1_Click);
            // 
            // car2
            // 
            this.car2.Image = global::WindowsFormsApp10.Properties.Resources.F2;
            this.car2.Location = new System.Drawing.Point(627, 12);
            this.car2.Name = "car2";
            this.car2.Size = new System.Drawing.Size(51, 92);
            this.car2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.car2.TabIndex = 7;
            this.car2.TabStop = false;
            // 
            // Maincar
            // 
            this.Maincar.Image = global::WindowsFormsApp10.Properties.Resources.F1;
            this.Maincar.Location = new System.Drawing.Point(395, 331);
            this.Maincar.Name = "Maincar";
            this.Maincar.Size = new System.Drawing.Size(56, 118);
            this.Maincar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Maincar.TabIndex = 6;
            this.Maincar.TabStop = false;
            this.Maincar.Click += new System.EventHandler(this.car_Click);
            // 
            // yellow2
            // 
            this.yellow2.BackColor = System.Drawing.Color.Yellow;
            this.yellow2.Location = new System.Drawing.Point(787, -2);
            this.yellow2.Name = "yellow2";
            this.yellow2.Size = new System.Drawing.Size(10, 479);
            this.yellow2.TabIndex = 5;
            this.yellow2.TabStop = false;
            // 
            // yellow1
            // 
            this.yellow1.BackColor = System.Drawing.Color.Yellow;
            this.yellow1.Location = new System.Drawing.Point(87, -2);
            this.yellow1.Name = "yellow1";
            this.yellow1.Size = new System.Drawing.Size(10, 481);
            this.yellow1.TabIndex = 4;
            this.yellow1.TabStop = false;
            // 
            // line2
            // 
            this.line2.BackColor = System.Drawing.SystemColors.Control;
            this.line2.Location = new System.Drawing.Point(277, 129);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(15, 74);
            this.line2.TabIndex = 3;
            this.line2.TabStop = false;
            this.line2.Click += new System.EventHandler(this.line2_Click);
            // 
            // line4
            // 
            this.line4.BackColor = System.Drawing.SystemColors.Control;
            this.line4.Location = new System.Drawing.Point(277, 375);
            this.line4.Name = "line4";
            this.line4.Size = new System.Drawing.Size(15, 74);
            this.line4.TabIndex = 2;
            this.line4.TabStop = false;
            // 
            // line3
            // 
            this.line3.BackColor = System.Drawing.SystemColors.Control;
            this.line3.Location = new System.Drawing.Point(277, 251);
            this.line3.Name = "line3";
            this.line3.Size = new System.Drawing.Size(15, 74);
            this.line3.TabIndex = 1;
            this.line3.TabStop = false;
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.SystemColors.Control;
            this.line1.Location = new System.Drawing.Point(277, 12);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(15, 74);
            this.line1.TabIndex = 0;
            this.line1.TabStop = false;
            // 
            // line6
            // 
            this.line6.BackColor = System.Drawing.SystemColors.Control;
            this.line6.Location = new System.Drawing.Point(570, 129);
            this.line6.Name = "line6";
            this.line6.Size = new System.Drawing.Size(15, 74);
            this.line6.TabIndex = 12;
            this.line6.TabStop = false;
            this.line6.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // line8
            // 
            this.line8.BackColor = System.Drawing.SystemColors.Control;
            this.line8.Location = new System.Drawing.Point(570, 375);
            this.line8.Name = "line8";
            this.line8.Size = new System.Drawing.Size(15, 74);
            this.line8.TabIndex = 11;
            this.line8.TabStop = false;
            // 
            // line7
            // 
            this.line7.BackColor = System.Drawing.SystemColors.Control;
            this.line7.Location = new System.Drawing.Point(570, 251);
            this.line7.Name = "line7";
            this.line7.Size = new System.Drawing.Size(15, 74);
            this.line7.TabIndex = 10;
            this.line7.TabStop = false;
            // 
            // line5
            // 
            this.line5.BackColor = System.Drawing.SystemColors.Control;
            this.line5.Location = new System.Drawing.Point(570, 12);
            this.line5.Name = "line5";
            this.line5.Size = new System.Drawing.Size(15, 74);
            this.line5.TabIndex = 9;
            this.line5.TabStop = false;
            // 
            // Score_label
            // 
            this.Score_label.AutoSize = true;
            this.Score_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Score_label.Cursor = System.Windows.Forms.Cursors.No;
            this.Score_label.Enabled = false;
            this.Score_label.Font = new System.Drawing.Font("Andalus", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score_label.ForeColor = System.Drawing.Color.Snow;
            this.Score_label.Location = new System.Drawing.Point(3, -2);
            this.Score_label.Name = "Score_label";
            this.Score_label.Size = new System.Drawing.Size(97, 44);
            this.Score_label.TabIndex = 13;
            this.Score_label.Text = "Score: ";
            this.Score_label.Click += new System.EventHandler(this.Score_label_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(911, 481);
            this.Controls.Add(this.Score_label);
            this.Controls.Add(this.yellow2);
            this.Controls.Add(this.yellow1);
            this.Controls.Add(this.Maincar);
            this.Controls.Add(this.car2);
            this.Controls.Add(this.car1);
            this.Controls.Add(this.line6);
            this.Controls.Add(this.line8);
            this.Controls.Add(this.line7);
            this.Controls.Add(this.line5);
            this.Controls.Add(this.line2);
            this.Controls.Add(this.line4);
            this.Controls.Add(this.line3);
            this.Controls.Add(this.line1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.car1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maincar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellow2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellow1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.line2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.line4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.line3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.line1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.line6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.line8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.line7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.line5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox line1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox line3;
        private System.Windows.Forms.PictureBox line4;
        private System.Windows.Forms.PictureBox line2;
        private System.Windows.Forms.PictureBox yellow1;
        private System.Windows.Forms.PictureBox yellow2;
        private System.Windows.Forms.PictureBox Maincar;
        private System.Windows.Forms.PictureBox car2;
        private System.Windows.Forms.PictureBox car1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox line6;
        private System.Windows.Forms.PictureBox line8;
        private System.Windows.Forms.PictureBox line7;
        private System.Windows.Forms.PictureBox line5;
        private System.Windows.Forms.Label Score_label;
    }
}

