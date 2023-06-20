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
using System.Timers;
using System.Xml;
using System.Diagnostics;

namespace _2DAnimatedGameSummitive
{
    public partial class Level2 : UserControl
    {
        Gem gemRec = new Gem(10, 10, 10, 10);
        List<Laser> laserList = new List<Laser>();
        List<Enemy> enemyList = new List<Enemy>();
        List<Safety> safetyList = new List<Safety>();

        Player robber;
        Boolean leftArrowDown, rightArrowDown, upArrowDown, downArrowDown;

        public static int difficulty = GameScreen.difficulty;
        public static int difficultySafety = GameScreen.difficultySafety;
        public static int score = 0;
        public static int lives = GameScreen.lives;

        public static bool point = false;

        SolidBrush whiteBrush = new SolidBrush(Color.White);
        SolidBrush blueBrush = new SolidBrush(Color.DarkBlue);
        SolidBrush limeBrush = new SolidBrush(Color.LimeGreen);
        SolidBrush lightBlueBrush = new SolidBrush(Color.SkyBlue);
        SolidBrush purpleBrush = new SolidBrush(Color.DarkMagenta);
        SolidBrush redBrush = new SolidBrush(Color.Red);

        SoundPlayer gemPickUp = new SoundPlayer(Properties.Resources.gemPickUp);
        SoundPlayer laserHit = new SoundPlayer(Properties.Resources.LaserHit);
        SoundPlayer enemyHit = new SoundPlayer(Properties.Resources.enemyHit);

        Random randGen = new Random();
        Random randGen2 = new Random();

        public Stopwatch watchHS = new Stopwatch();

        public Level2()
        {
            watchHS.Start();
            InitializeComponent();
            InitializeGame();
        }
        public void HighScore()
        {
            Form1.hS2 = (int)watchHS.ElapsedMilliseconds;
            Form1.highScore = Form1.hS1 + Form1.hS2;
            // keeps track of each fastest times for each level
            if (Form1.highScoreEasy >= Form1.highScore)
            {
                if (difficulty == 1)
                {
                    Form1.highScoreEasy = Form1.highScore;
                }
            }
            if (Form1.highScoreMedium >= Form1.highScore)
            {
                if (difficulty == 2)
                {
                    Form1.highScoreMedium = Form1.highScore;
                }
            }
            if (Form1.highScoreHard >= Form1.highScore)
            {
                if (difficulty == 4)
                {
                    Form1.highScoreHard = Form1.highScore;
                }
            }
            watchHS.Reset();

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
                NewEnemy();

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
            foreach (Enemy en in enemyList)
            {
                en.Move(robber);
            }
            if (gemRec.Collision(robber))
            {
                score++;                // adds a point to progression through level
                gemPickUp.Play();       // plays a sound when gem is touched
                foreach (Safety s in safetyList)    // puts the robber back in starting safe area
                {
                    robber.x = s.safetyX + 30;
                    robber.y = s.safetyY + 30;
                }
                scoreOutputLabel.Text = $"Score: {score}";
            }
            foreach (Laser l in laserList)
            {
                if (l.Collision(robber))    //Checks for collision with the player and lasers
                {
                    lives--;
                    laserHit.Play();
                    livesLabel.Text = $"Lives: {lives}";
                }
            }

            foreach (Enemy en in enemyList)
            {
                if (en.Collision(robber))   // checks for collision with the player to the tracking enemies
                {
                    lives--;
                    enemyHit.Play();
                    livesLabel.Text = $"Lives: {lives}";
                }
            }
            foreach (Laser l in laserList)
            {
                bool noCollision = true;
                foreach (Safety s in safetyList)
                {
                    if (l.Collision(s))         // makes the lasers change height whenever colliding with the safetybox
                    {
                        l.laserHeight = s.safetyY - 1;
                        noCollision = false;
                        break;
                    }
                    if (noCollision)            // if it doesnt collide with a safety box it will keep the height the same
                    {
                        l.laserHeight = 800;
                    }
                }
            }
            if (lives <= 0)         //Declares when the game ends
            {
                score = 0;
                gameEngine.Stop();

                ChangeScreen(this, new GameOverScreen());
            }
            if (score >= 5)         // Declares if the player won the level
            {
                score = 0;
                gameEngine.Stop();
                HighScore();
                ChangeScreen(this, new WinScreen());    // Sends the player to the win screen
            }
            Refresh();
        }

        public void NewLaser()   // spawns the lasers at the start of the program
        {
            int laserX = randGen.Next(10, this.Width - 10);
            Laser newLaser = new Laser(laserX);
            laserList.Add(newLaser);
        }
        public void NewEnemy()  // spawns the Cops at the start of the program
        {
            int enemyX = randGen.Next(100, this.Width - 10);
            int enemyY = randGen.Next(10, this.Height - 10);
            Enemy newEnemy = new Enemy(enemyX, enemyY);
            enemyList.Add(newEnemy);
        }
        public void NewSafetyBox()      // spawns the safety boxes at the start of the level
        {
            int safetyX = randGen2.Next(5, this.Width - 80);
            int safetyY = randGen2.Next(5, this.Height - 80);
            Safety newSafetyBox = new Safety(safetyX, safetyY, 80, 80);
            safetyList.Add(newSafetyBox);
        }
        private void Level2_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
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
        // ^ lets the player move 

        private void Level2_KeyUp(object sender, KeyEventArgs e)    // lets the player move 
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
        private void Level2_Paint(object sender, PaintEventArgs e) // paints the player, enemies, safetyboxes, and gem on the screen
        {

            foreach (Safety s in safetyList)
            {
                e.Graphics.FillRectangle(blueBrush, s.safetyX, s.safetyY, s.safetyWidth, s.safetyHeight);
            }
            foreach (Enemy en in enemyList)
            {
                e.Graphics.FillRectangle(redBrush, en.enemyX, en.enemyY, en.enemyWidth, en.enemyHeight);
            }
            if (difficulty == 1)
            {
                e.Graphics.FillEllipse(limeBrush, 600, 200, 50, 50);
            }
            if (difficulty == 2)
            {
                e.Graphics.FillEllipse(lightBlueBrush, 600, 200, 50, 50);
            }
            if (difficulty == 4)
            {
                e.Graphics.FillEllipse(purpleBrush, 600, 200, 50, 50);
            }
            foreach (Laser l in laserList)
            {
                e.Graphics.FillRectangle(redBrush, l.laserX, l.laserY, l.laserWidth, l.laserHeight);
            }

            e.Graphics.FillRectangle(whiteBrush, robber.x, robber.y, robber.width, robber.height);
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
