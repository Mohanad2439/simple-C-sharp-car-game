
namespace CarGame
{
    partial class CarGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarGame));
            this.road = new System.Windows.Forms.Timer(this.components);
            this.traffic = new System.Windows.Forms.Timer(this.components);
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
            this.scoretimer = new System.Windows.Forms.Timer(this.components);
            this.Speed = new System.Windows.Forms.Timer(this.components);
            this.start = new System.Windows.Forms.PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.start)).BeginInit();
            this.SuspendLayout();
            // 
            // road
            // 
            this.road.Enabled = true;
            this.road.Interval = 10;
            this.road.Tick += new System.EventHandler(this.road_Tick);
            // 
            // traffic
            // 
            this.traffic.Enabled = true;
            this.traffic.Interval = 60;
            this.traffic.Tick += new System.EventHandler(this.traffic_Tick);
            // 
            // car1
            // 
            this.car1.BackColor = System.Drawing.Color.Transparent;
            this.car1.Image = global::CarGame.Properties.Resources.YellowCar;
            resources.ApplyResources(this.car1, "car1");
            this.car1.Name = "car1";
            this.car1.TabStop = false;
            this.car1.Tag = "CarLeft";
            this.car1.Click += new System.EventHandler(this.greencar1_Click);
            // 
            // car2
            // 
            this.car2.Image = global::CarGame.Properties.Resources.F2;
            resources.ApplyResources(this.car2, "car2");
            this.car2.Name = "car2";
            this.car2.TabStop = false;
            this.car2.Tag = "CarRight";
            // 
            // Maincar
            // 
            this.Maincar.Image = global::CarGame.Properties.Resources.F1;
            resources.ApplyResources(this.Maincar, "Maincar");
            this.Maincar.Name = "Maincar";
            this.Maincar.TabStop = false;
            this.Maincar.Click += new System.EventHandler(this.car_Click);
            // 
            // yellow2
            // 
            this.yellow2.BackColor = System.Drawing.Color.Yellow;
            this.yellow2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.yellow2, "yellow2");
            this.yellow2.Name = "yellow2";
            this.yellow2.TabStop = false;
            // 
            // yellow1
            // 
            this.yellow1.BackColor = System.Drawing.Color.Yellow;
            this.yellow1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.yellow1, "yellow1");
            this.yellow1.Name = "yellow1";
            this.yellow1.TabStop = false;
            // 
            // line2
            // 
            this.line2.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.line2, "line2");
            this.line2.Name = "line2";
            this.line2.TabStop = false;
            this.line2.Click += new System.EventHandler(this.line2_Click);
            // 
            // line4
            // 
            this.line4.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.line4, "line4");
            this.line4.Name = "line4";
            this.line4.TabStop = false;
            // 
            // line3
            // 
            this.line3.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.line3, "line3");
            this.line3.Name = "line3";
            this.line3.TabStop = false;
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.line1, "line1");
            this.line1.Name = "line1";
            this.line1.TabStop = false;
            // 
            // line6
            // 
            this.line6.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.line6, "line6");
            this.line6.Name = "line6";
            this.line6.TabStop = false;
            this.line6.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // line8
            // 
            this.line8.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.line8, "line8");
            this.line8.Name = "line8";
            this.line8.TabStop = false;
            // 
            // line7
            // 
            this.line7.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.line7, "line7");
            this.line7.Name = "line7";
            this.line7.TabStop = false;
            // 
            // line5
            // 
            this.line5.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.line5, "line5");
            this.line5.Name = "line5";
            this.line5.TabStop = false;
            // 
            // Score_label
            // 
            resources.ApplyResources(this.Score_label, "Score_label");
            this.Score_label.BackColor = System.Drawing.Color.Black;
            this.Score_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Score_label.Cursor = System.Windows.Forms.Cursors.No;
            this.Score_label.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Score_label.ForeColor = System.Drawing.Color.White;
            this.Score_label.Name = "Score_label";
            this.Score_label.Click += new System.EventHandler(this.Score_label_Click);
            // 
            // scoretimer
            // 
            this.scoretimer.Enabled = true;
            this.scoretimer.Tick += new System.EventHandler(this.scoretimer_Tick);
            // 
            // Speed
            // 
            this.Speed.Enabled = true;
            this.Speed.Interval = 2000;
            this.Speed.Tick += new System.EventHandler(this.Speed_Tick);
            // 
            // start
            // 
            this.start.Image = global::CarGame.Properties.Resources.start;
            resources.ApplyResources(this.start, "start");
            this.start.Name = "start";
            this.start.TabStop = false;
            // 
            // CarGame
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.start);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CarGame";
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
            ((System.ComponentModel.ISupportInitialize)(this.start)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox line1;
        private System.Windows.Forms.Timer road;
        private System.Windows.Forms.PictureBox line3;
        private System.Windows.Forms.PictureBox line4;
        private System.Windows.Forms.PictureBox line2;
        private System.Windows.Forms.PictureBox yellow1;
        private System.Windows.Forms.PictureBox yellow2;
        private System.Windows.Forms.PictureBox Maincar;
        private System.Windows.Forms.PictureBox car2;
        private System.Windows.Forms.PictureBox car1;
        private System.Windows.Forms.Timer traffic;
        private System.Windows.Forms.PictureBox line6;
        private System.Windows.Forms.PictureBox line8;
        private System.Windows.Forms.PictureBox line7;
        private System.Windows.Forms.PictureBox line5;
        private System.Windows.Forms.Timer scoretimer;
        private System.Windows.Forms.Timer Speed;
        private System.Windows.Forms.PictureBox start;
        public System.Windows.Forms.Label Score_label;
    }
}

