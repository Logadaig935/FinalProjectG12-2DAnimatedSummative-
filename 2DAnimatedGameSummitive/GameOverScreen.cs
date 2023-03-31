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
    public partial class GameOverScreen : UserControl
    {
        SoundPlayer gameOver = new SoundPlayer(Properties.Resources.gameOver);
        public GameOverScreen()
        {
            InitializeComponent();
            gameOver.Play();
        }

        private void retryButton_Click(object sender, EventArgs e)
        {
            ChangeScreen(this, new MenuScreen());
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
