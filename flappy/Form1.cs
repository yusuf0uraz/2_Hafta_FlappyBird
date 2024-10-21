using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flappy
{
    public partial class flappyBird : Form
    {
        int boruhizi = 8;
        int grav = 15;
        int score = 0;
        public flappyBird()
        {
            InitializeComponent();
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            kus.Top += grav;
            borualt.Left -= boruhizi;
            boruust.Left -= boruhizi;
            scoreText.Text = "Score; " + score;
            if (borualt.Left <= -150)
            {
                borualt.Left = 800;
                score++;

            }
            if (boruust.Left <= -180)
            {
                boruust.Left = 950;
                score++;
            }
            if (kus.Bounds.IntersectsWith(borualt.Bounds) || kus.Bounds.IntersectsWith(boruust.Bounds)||kus.Bounds.IntersectsWith(zemin.Bounds))
            {
                endGame();
            }


        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) grav = -10;
          

        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) grav = 10;
        }
        private void endGame()
        {
            gameTimer.Stop();
            scoreText.Text = "Game Over";
        }
    }
}
