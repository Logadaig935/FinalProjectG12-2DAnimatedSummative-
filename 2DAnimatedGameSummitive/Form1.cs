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
    public partial class Form1 : Form
    {
        public static int hS1;
        public static int hS2;
        public static int highScore;
        public static int highScoreEasy;
        public static int highScoreMedium;
        public static int highScoreHard;
        // keeps track of each fastest time while keeping track of the current players time

        public Form1()
        {
            InitializeComponent();

            XmlReader reader = XmlReader.Create("Resources/highScoreTime.xml");

            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Text)
                {
                    Form1.highScoreHard = Convert.ToInt32(reader.ReadString());

                    reader.ReadToNextSibling("silver");
                    Form1.highScoreMedium = Convert.ToInt32(reader.ReadString());

                    reader.ReadToNextSibling("bronze");
                    Form1.highScoreEasy = Convert.ToInt32(reader.ReadString());
                }
            }

            reader.Close();

            //open menu screen when the program starts
            ChangeScreen(this, new MenuScreen());
        }

        /// <summary>
        /// Opens a new screen and closes previous screen if one exists
        /// </summary>
        /// <param name="sender">Either the form or a UserControl: (this)</param>
        /// <param name="next">The UserControl to open: new UserControl()</param>
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

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            XmlWriter writer = XmlWriter.Create("Resources/HighScoreTime.xml", null);

            writer.WriteStartElement("HighScores");

            writer.WriteStartElement("score");

            writer.WriteElementString("gold", Form1.highScoreHard.ToString());
            writer.WriteElementString("silver", Form1.highScoreMedium.ToString());
            writer.WriteElementString("bronze", Form1.highScoreEasy.ToString());

            writer.WriteEndElement();

            writer.WriteEndElement();

            writer.Close();
        }
    }
}