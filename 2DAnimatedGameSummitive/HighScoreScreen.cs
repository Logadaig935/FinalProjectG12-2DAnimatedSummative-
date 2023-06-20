using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace _2DAnimatedGameSummitive
{
    public partial class HighScoreScreen : UserControl
    {
        public string gold, silver, bronze;
        List<HighScore> highScoreHS = new List<HighScore>();

        public HighScoreScreen()
        {
            InitializeComponent();
            SetLabels();
        }
        private void SetLabels()
        { //displays highscores and Dev Time (My personal fastest)
            devLabel.Text = "Dev Time: 30 sec";
            goldLabel.Text = $"Gold Time: {Form1.highScoreHard} sec";
            silverLabel.Text = $"Silver Time: {Form1.highScoreMedium} sec";
            bronzeLabel.Text = $"Bronze Time: {Form1.highScoreEasy} sec";
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new MenuScreen());
        }
    }
}
