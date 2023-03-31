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
    public partial class WinScreen : UserControl
    {
        public WinScreen()
        {
            InitializeComponent();

            if (GameScreen.difficulty == 2)
            {
                BackColor = Color.Green;
                againButton.BackColor = Color.Green;
                exitButton.BackColor = Color.Green;
            }
            if (GameScreen.difficulty == 4)
            {
                BackColor = Color.LightBlue;
                againButton.BackColor = Color.LightBlue;
                exitButton.BackColor = Color.LightBlue;
            }
            if (GameScreen.difficulty == 8)
            {
                BackColor = Color.DarkMagenta;
                againButton.BackColor = Color.DarkMagenta;
                exitButton.BackColor = Color.DarkMagenta;
            }
        }
        private void againButton_Click(object sender, EventArgs e)
        {
            ChangeScreen(this, new MenuScreen());
        }
        private void exitButton_Click_1(object sender, EventArgs e)
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
