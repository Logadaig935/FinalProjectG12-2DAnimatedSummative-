using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2DAnimatedGameSummitive
{
    public partial class MenuScreen : UserControl
    {
        public MenuScreen()
        {
            InitializeComponent();
        }

        private void easyButton_Click(object sender, EventArgs e)
        {
            GameScreen.difficulty = 2;
            GameScreen.difficultySafety = 5;
            GameScreen.lives = 4;
            Form1.ChangeScreen(this, new GameScreen());
        }

        private void mediumButton_Click(object sender, EventArgs e)
        {
            GameScreen.difficulty = 4;
            GameScreen.difficultySafety = 4;
            GameScreen.lives = 3;
            Form1.ChangeScreen(this, new GameScreen());
        }

        private void hardButton_Click(object sender, EventArgs e)
        {
            GameScreen.difficulty = 8;
            GameScreen.difficultySafety = 3;
            GameScreen.lives = 2;
            Form1.ChangeScreen(this, new GameScreen());
        }
    }
}
