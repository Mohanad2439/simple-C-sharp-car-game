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
    
    public partial class Form2 : Form
    {
        SoundPlayer p2 = new SoundPlayer(Properties.Resources.lost);
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            p2.PlayLooping();
        }

        private void Score_Click(object sender, EventArgs e)
        {

        }

        private void playagain_Click(object sender, EventArgs e)
        {
            p2.Stop();
            Application.Restart();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            p2.Stop();
            Application.Exit();
        }
    }
}
