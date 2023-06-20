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
    public partial class WinScreen : UserControl
    {
        SoundPlayer winTrack = new SoundPlayer(Properties.Resources.winSound);
        public WinScreen()
        {
            InitializeComponent();
            timeLabel.Text = $"Your Time: {Form1.highScore}";

            if (GameScreen.difficulty == 1)
            {
                BackColor = Color.Green;
                againButton.BackColor = Color.Green;
                exitButton.BackColor = Color.Green;
                winTrack.Play();
            }
            if (GameScreen.difficulty == 2)
            {
                BackColor = Color.LightBlue;
                againButton.BackColor = Color.LightBlue;
                exitButton.BackColor = Color.LightBlue;
                winTrack.Play();
            }
            if (GameScreen.difficulty == 4)
            {
                BackColor = Color.DarkMagenta;
                againButton.BackColor = Color.DarkMagenta;
                exitButton.BackColor = Color.DarkMagenta;
                winTrack.Play();
            }
            // ^ changes the win screen based on what difficulty was picked on the menu
        }
        private void againButton_Click(object sender, EventArgs e)  // lets the player play the game again if they wish to 
        {
            ChangeScreen(this, new MenuScreen());
        }
        private void exitButton_Click_1(object sender, EventArgs e)
        {
            Application.Exit(); //closes the program entirely
        }
        public static void ChangeScreen(object sender, UserControl next)
        {
            Form f; // will either be the sender or parent of sender

            if (sender is Form)
            {
                f = (Form)sender;                          //f is sender
            }
            else
            {
                UserControl current = (UserControl)sender;  //create UserControl from sender
                f = current.FindForm();                     //find Form UserControl is on
                f.Controls.Remove(current);                 //remove current UserControl
            }

            // add the new UserControl to the middle of the screen and focus on it
            next.Location = new Point((f.ClientSize.Width - next.Width) / 2,
                (f.ClientSize.Height - next.Height) / 2);
            f.Controls.Add(next);
            next.Focus();
        }

    }
}
