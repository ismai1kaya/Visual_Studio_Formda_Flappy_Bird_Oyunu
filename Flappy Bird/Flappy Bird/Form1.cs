using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_Bird
{
    public partial class Form1 : Form
    {

        int kolonHizi = 8;
        int gravity = 10;
        int score = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            flappyBird.Top += gravity;
            kolonAlt.Left -= kolonHizi;
            kolonUst.Left -= kolonHizi;
            scoreText.Text = "Score: " + score;

            if (kolonAlt.Left < -150) {
                kolonAlt.Left = 800;
                score++;
            }
            if (kolonUst.Left < -180) {
                kolonUst.Left = 950;
                score++;
            }
            if (flappyBird.Bounds.IntersectsWith(kolonAlt.Bounds) || flappyBird.Bounds.IntersectsWith(kolonUst.Bounds) || flappyBird.Bounds.IntersectsWith(zemin.Bounds)){
                endGame();           
            }
            if (score == 5  ) {
                kolonHizi = 10;
            }
            if (score == 10) {
                kolonHizi = 12;
            }
            if(flappyBird.Top < -28 )
            {
                endGame();
            }
        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) {
                gravity = -10 ;
            }
        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 10;
            }
        }
        private void endGame() {
            gameTimer.Stop();
            scoreText.Text = "Game Over";
        
        }

        private void kolonAlt_Click(object sender, EventArgs e)
        {

        }
    }
}
