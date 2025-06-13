using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;


namespace WindowsFormsApp10
{

    public partial class Form1 : Form

    {
        SoundPlayer player = new SoundPlayer(Properties.Resources.game_music);
        int score = 0;
        Random position = new Random();
        Random rand = new Random();
        int imagechange;
        int CarSpeed = 0;
        int trafficspeed;
        int roadspeed;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            player.Play();
            Score_label.Text += Convert.ToString(score);
        }

        //road moving:
        private void MoveLine()
        {
            if (line1.Top > 500) line1.Top = 0;
            else line1.Top += roadspeed;

            if (line2.Top > 500) line2.Top = 0;
            else line2.Top += roadspeed;

            if (line3.Top > 500) line3.Top = 0;
            else line3.Top += roadspeed;

            if (line4.Top > 500) line4.Top = 0;
            else line4.Top += roadspeed;

            if (line5.Top > 500) line5.Top = 0;
            else line5.Top += roadspeed;

            if (line6.Top > 500) line6.Top = 0;
            else line6.Top += roadspeed;

            if (line7.Top > 500) line7.Top = 0;
            else line7.Top += roadspeed;

            if (line8.Top > 500) line8.Top = 0;
            else line8.Top += roadspeed;
        }

        //changing car images:
        private void carimage(PictureBox tempcar)
        {
            imagechange = rand.Next(1, 3);

            switch (imagechange)
            {
                case 1:
                    tempcar.Image = Properties.Resources.F1;
                    break;

                case 2:
                    tempcar.Image = Properties.Resources.YellowCar;
                    break;

                case 3:
                    tempcar.Image = Properties.Resources.F2;
                    break;
            }

        }

        //car appearing position:
        private void traffic1()
        {
            int below=new int();
            if (car1.Top != car2.Top)
            {
                trafficspeed = roadspeed-2;
                car1.Top += trafficspeed;
                car2.Top += trafficspeed + 1;
                below = Maincar.Top + 13;

                if (car1.Top > below && car1.Left < 375 && car1.Top != Maincar.Bottom)
                {
                    carimage(car1);
                    car1.Top = 0;
                    if (position.Next() < 325)
                    {
                        car1.Left = position.Next(35, 400);
                    }
                }

                if (car2.Top > below && !car2.Bounds.IntersectsWith(yellow1.Bounds) && !car2.Bounds.IntersectsWith(car1.Bounds))
                {
                    carimage(car2);
                    car2.Top = 0;

                    car1.Left = position.Next(15, 400);
                }

            }
        }
            
        

        //what takes place after crash:
        private int crash()
        {
            if (Maincar.Bounds.IntersectsWith(car1.Bounds) || Maincar.Bounds.IntersectsWith(car2.Bounds))
            {
                timer1.Stop();
                timer2.Stop();
                player.Stop();
                MessageBox.Show("Score:" + score,"Your Score");
                return 0;
            }
            return 1;   
        }

        //keys used:
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (crash() == 1)
            {
                if (e.KeyCode == Keys.Up) { CarSpeed++; roadspeed++; }
                if (e.KeyCode == Keys.Down) { CarSpeed--; roadspeed--; }
                if (e.KeyCode == Keys.Right && !Maincar.Bounds.IntersectsWith(yellow1.Bounds)) Maincar.Left += 15;
                if (e.KeyCode == Keys.Left && !Maincar.Bounds.IntersectsWith(yellow1.Bounds)) Maincar.Left -= 15;
                player.Stop();
            }
        }

        //controls the road speed, car speed and the calculation of the score:
        private void timer1_Tick(object sender, EventArgs e)
        {
            MoveLine();
            crash();
            score ++;
        }

        //controls the appearance of other cars:
        private void timer2_Tick(object sender, EventArgs e)
        {
                traffic1();
            
        }

        private void car_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Score_label_Click(object sender, EventArgs e)
        {

        }

        private void greencar1_Click(object sender, EventArgs e)
        {

        }

        private void line2_Click(object sender, EventArgs e)
        {

        }
    }
}
