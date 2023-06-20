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

namespace _2DAnimatedGameSummitive
{
    public partial class MenuScreen : UserControl
    {
        SoundPlayer gameOver = new SoundPlayer(Properties.Resources.gameOver);
        public MenuScreen()
        {
            InitializeComponent();
            gameOver.Stop();
        }

        private void easyButton_Click(object sender, EventArgs e)
        {
            GameScreen.difficulty = 1;
            GameScreen.difficultySafety = 5;
            GameScreen.lives = 5;
            Form1.ChangeScreen(this, new GameScreen());
        }

        private void mediumButton_Click(object sender, EventArgs e)
        {
            GameScreen.difficulty = 2;
            GameScreen.difficultySafety = 4;
            GameScreen.lives = 4;
            Form1.ChangeScreen(this, new GameScreen());
        }
        private void hardButton_Click(object sender, EventArgs e)
        {
            GameScreen.difficulty = 4;
            GameScreen.difficultySafety = 3;
            GameScreen.lives = 3;
            Form1.ChangeScreen(this, new GameScreen());
        }

        private void highScoreButton_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new HighScoreScreen());
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
