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
        int score=0;
        Random position = new Random();
        Random rand = new Random();
        int imagechange;
        int CarSpeed = 0;
        int trafficspeed;
        int roadspeed;
        SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Downloads\cruiser.wav.wav");
        SoundPlayer fashalna = new SoundPlayer(@"C:\Users\HP\Downloads\fashalna.wav");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            player.Play();
            boom.Visible = false;
            gameover.Visible = false;
            hemedti.Visible = false;
 
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
        }

        //changing car images:
        private void carimage(PictureBox tempcar)
        {

            imagechange = rand.Next(1, 5);

            switch (imagechange)
            {
                case 1:
                    tempcar.Image = Properties.Resources.armycar;
                    break;

                case 2:
                    tempcar.Image = Properties.Resources.tank;
                    break;

                case 3:
                    tempcar.Image = Properties.Resources.greencar;
                    break;

                case 4:
                    tempcar.Image = Properties.Resources.redcar;
                    break;

                case 5:
                    tempcar.Image = Properties.Resources.bluecar;
                    break;
            }

        }

        //car appearing position:
        private void traffic1()
        {
            trafficspeed = roadspeed;
            greencar1.Top += trafficspeed;
            greencar2.Top += trafficspeed;
            int below = car.Top + 150;


            if (greencar1.Top > below && greencar1.Left<375 && greencar1.Top != greencar2.Top && greencar1.Top!=car.Bottom)
            {
                carimage(greencar1);
                greencar1.Top = 0;
                if(position.Next()<325)
                {
                    greencar1.Left = position.Next(35, 400);
                }
               
            }

            if (greencar2.Top > below && greencar2.Left < 375 && greencar2.Left != greencar1.Left)
            {
                carimage(greencar2);
                greencar2.Top = 0;
     
                    greencar1.Left = position.Next(15, 400);

                
            }
      
        }
            
        

        //what takes place after crash:
        private int crash()
        {
            if (car.Bounds.IntersectsWith(greencar1.Bounds) || car.Bounds.IntersectsWith(greencar2.Bounds))
            {
                timer1.Stop();
                timer2.Stop();
                boom.Visible = true;
                boom.Location = car.Location;
                gameover.Visible = true;
                hemedti.Visible = true;
                player.Stop();
                fashalna.Play();
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
                if (e.KeyCode == Keys.Up) { CarSpeed++; roadspeed++; greencar1.Top++;greencar2.Top++; }
                if (e.KeyCode == Keys.Down) { CarSpeed--; roadspeed--; }
                if (e.KeyCode == Keys.Right && car.Left < 295) car.Left += 15;
                if (e.KeyCode == Keys.Left && car.Left > 10) car.Left -= 15;

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
    }
}
