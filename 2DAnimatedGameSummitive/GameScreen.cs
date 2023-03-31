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
    public partial class GameScreen : UserControl
    {
        Gem gemRec = new Gem(10, 10, 10, 10);
        List<Laser> laserList = new List<Laser>();
        List<Safety> safetyList = new List<Safety>();

        Player robber;
        Boolean leftArrowDown, rightArrowDown, upArrowDown, downArrowDown;

        public static int difficulty;
        public static int difficultySafety;
        public static int score = 0;
        public static int lives = 3;

        public static bool point = false;

        SolidBrush whiteBrush = new SolidBrush(Color.White);
        SolidBrush blueBrush = new SolidBrush(Color.DarkBlue);
        SolidBrush limeBrush = new SolidBrush(Color.LimeGreen);
        SolidBrush lightBlueBrush = new SolidBrush(Color.SkyBlue);
        SolidBrush purpleBrush = new SolidBrush(Color.DarkMagenta);
        SolidBrush redBrush = new SolidBrush(Color.Red);

        Random randGen = new Random();
        Random randGen2 = new Random();
        public GameScreen()
        {
            InitializeComponent();
            InitializeGame();
        }

        public void InitializeGame()
        {
            difficultySafety--;
            robber = new Player(50, 140);
            gemRec = new Gem(600, 200, 10, 10);

            livesLabel.Text = $"Lives: {lives}";

            for (int i = 0; i < difficulty; i++)
            {
                NewLaser();
            }
            for (int i = 0; i < difficultySafety; i++)
            {
                NewSafetyBox();
            }
            foreach (Safety s in safetyList)
            {
                robber.x = s.safetyX + 30;
                robber.y = s.safetyY + 30;
            }
        }

        private void gameEngine_Tick(object sender, EventArgs e)
        {
            if (upArrowDown && robber.y > 0)
            {
                robber.Move("up");
            }
            if (downArrowDown && robber.y < this.Height - robber.height)
            {
                robber.Move("down");
            }
            if (leftArrowDown && robber.x > 0)
            {
                robber.Move("left");
            }
            if (rightArrowDown && robber.x < this.Width - robber.width)
            {
                robber.Move("right");
            }

            foreach (Laser l in laserList)
            {
                l.Move(this.Width);
            }

            if (gemRec.Collision(robber))
            {
                score++;
                foreach (Safety s in safetyList)
                {
                    robber.x = s.safetyX + 30;
                    robber.y = s.safetyY + 30;
                }
                scoreOutputLabel.Text = $"Score: {score}";
            }
            foreach (Laser l in laserList)
            {
                if (l.Collision(robber))
                {
                    lives--;
                    livesLabel.Text = $"Lives: {lives}";
                }
            }

            foreach (Laser l in laserList)
            {
                bool noCollision = true;
                foreach (Safety s in safetyList)
                {
                    if (l.Collision(s))
                    {
                        l.laserHeight = s.safetyY - 1;
                        noCollision = false;
                        break;
                    }
                    if (noCollision)
                    {
                        l.laserHeight = 300;
                    }
                }
            }
            if (lives <= 0)
            {
                score = 0;
                gameEngine.Stop();
                ChangeScreen(this, new GameOverScreen());
            }
            if (score >= 5)
            {
                score = 0;
                gameEngine.Stop();
                ChangeScreen(this, new WinScreen());
            }
            Refresh();
        }

        public void NewLaser()
        {
            int x = randGen.Next(10, this.Width - 10);
            Laser newLaser = new Laser(x);
            laserList.Add(newLaser);
        }
        public void NewSafetyBox()
        {
            int X = randGen2.Next(10, this.Width - 80);
            int Y = randGen2.Next(10, this.Height - 80);
            Safety newSafetyBox = new Safety(X, Y, 80, 80);
            safetyList.Add(newSafetyBox);
        }
        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {

            foreach (Safety s in safetyList)
            {
                e.Graphics.FillRectangle(blueBrush, s.safetyX, s.safetyY, s.safetyWidth, s.safetyHeight);
            }
            if (difficulty == 2)
            {
                e.Graphics.FillEllipse(limeBrush, 600, 200, 50, 50);
            }
            if (difficulty == 4)
            {
                e.Graphics.FillEllipse(lightBlueBrush, 600, 200, 50, 50);
            }
            if (difficulty == 8)
            {
                e.Graphics.FillEllipse(purpleBrush, 600, 200, 50, 50);
            }
            foreach (Laser l in laserList)
            {
                e.Graphics.FillRectangle(redBrush, l.laserX, l.laserY, l.laserWidth, l.laserHeight);
            }

            e.Graphics.FillRectangle(whiteBrush, robber.x, robber.y, robber.width, robber.height);
        }

        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = true;
                    break;
                case Keys.Right:
                    rightArrowDown = true;
                    break;
                case Keys.Up:
                    upArrowDown = true;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    break;
            }
        }

        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = false;
                    break;
                case Keys.Right:
                    rightArrowDown = false;
                    break;
                case Keys.Up:
                    upArrowDown = false;
                    break;
                case Keys.Down:
                    downArrowDown = false;
                    break;
            }
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
