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


namespace CarGame
{

    public partial class CarGame : Form

    {
        SoundPlayer player = new SoundPlayer(Properties.Resources.game_music);
        double score = 0;
        Random position = new Random();
        Random rand = new Random();
        int imagechange;
        int trafficspeed=3;
        int roadspeed=3;
        int movement = 15;
        public CarGame()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            traffic.Stop();
            road.Stop();
            Speed.Stop();
            scoretimer.Stop();
        }

        //road moving:
        private void MoveLine()
        {
            if (line1.Top > 559) line1.Top = -5;
            else line1.Top += roadspeed;

            if (line2.Top > 559) line2.Top = -5;
            else line2.Top += roadspeed;

            if (line3.Top > 559) line3.Top = -5;
            else line3.Top += roadspeed;

            if (line4.Top > 559) line4.Top = -5;
            else line4.Top += roadspeed;

            if (line5.Top > 559) line5.Top = -5;
            else line5.Top += roadspeed;

            if (line6.Top > 559) line6.Top = -5;
            else line6.Top += roadspeed;

            if (line7.Top > 559) line7.Top = -5;
            else line7.Top += roadspeed;

            if (line8.Top > 559) line8.Top = -5;
            else line8.Top += roadspeed;
        }

        //changing car images:
        private void carimage(PictureBox tempcar)
        {
            imagechange = rand.Next(1, 3);

            switch (imagechange)
            {
                case 1:
                    tempcar.Image = Properties.Resources.YellowCar;
                    break;

                case 2:
                    tempcar.Image = Properties.Resources.F2;
                    break;
            }

            tempcar.Top = position.Next(100, 500)*-1;

            if((string)tempcar.Tag== "CarLeft")
            {
                tempcar.Left = position.Next(21, 290);
            }

            if ((string)tempcar.Tag == "CarRight")
            {
                tempcar.Left = position.Next(320, 610);
            }
        }

        //car appearing position:
        private void traffic1()
        {
            if (!car1.Bounds.IntersectsWith(car2.Bounds)&& !Maincar.Bounds.IntersectsWith(car2.Bounds) && !Maincar.Bounds.IntersectsWith(car2.Bounds))
            {
                trafficspeed = roadspeed-2;
                car1.Top += trafficspeed +1;
                car2.Top += trafficspeed + 2;

                if (car1.Top > 559)
                {
                    car1.Top = -395;
                    carimage(car1);
                }

                if (car2.Top > 559)
                {
                    car2.Top = -395;
                    carimage(car2);
                }
            }
        }
        private int crash()
        {
            if (Maincar.Bounds.IntersectsWith(car1.Bounds) || Maincar.Bounds.IntersectsWith(car2.Bounds))
            {
                road.Stop();
                traffic.Stop();
                scoretimer.Stop();
                Speed.Stop();
                player.Stop();
                Form2 f2 = new Form2();
                f2.Score.Text += score;
                f2.Score.UseCompatibleTextRendering = true;
                f2.Show();
                this.Hide();
                return 0;
            }
            return 1;   
        }

        //keys used:
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (crash() == 1)
            {
                if (e.KeyCode == Keys.Enter)
                { player.PlayLooping(); Speed.Start(); traffic.Start(); road.Start(); scoretimer.Start(); start.Visible=false; }
                if (e.KeyCode == Keys.Right)
                    { if (!Maincar.Bounds.IntersectsWith(yellow2.Bounds)) { Maincar.Left += movement;} }
                if (e.KeyCode == Keys.Left)
                    { if (!Maincar.Bounds.IntersectsWith(yellow1.Bounds)) { Maincar.Left -= movement;} }
            }
        }

        //controls the road speed, car speed and the calculation of the score:
        private void road_Tick(object sender, EventArgs e)
        {
            MoveLine();
            crash();
        }

        //controls the appearance of other cars:
        private void traffic_Tick(object sender, EventArgs e)
        {
                traffic1();
        }

        private void scoretimer_Tick(object sender, EventArgs e)
        {
            score++;
            Score_label.Text = "Score: " + Convert.ToString(score);
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
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Speed_Tick(object sender, EventArgs e)
        {
            if (roadspeed <= 150 && trafficspeed <= 150)
            {
                trafficspeed++;
                roadspeed++;
            }
            else { roadspeed = 150; roadspeed = 150; }
            if(movement<=30)
            {
                movement++;
            }
        }
    }
}
