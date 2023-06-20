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
using System.Xml;
using System.Diagnostics;

namespace _2DAnimatedGameSummitive
{
    public partial class GameScreen : UserControl
    {
        Gem gemRec = new Gem(10, 10, 10, 10);
        List<Laser> laserList = new List<Laser>();
        List<Enemy> enemyList = new List<Enemy>();
        List<Safety> safetyList = new List<Safety>();

        Player robber;
        Boolean leftArrowDown, rightArrowDown, upArrowDown, downArrowDown;

        public static int difficulty;
        public static int difficultySafety;
        public static int score = 0;
        public static int lives;

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

        public GameScreen()
        {
            watchHS.Start();
            InitializeComponent();
            InitializeGame();
            HighScore();
        }

        public void HighScore() // keeps track of how fast the player beat the level
        {
            if (gameEngine.Enabled == false)
            {
                Form1.hS1 = (int)watchHS.ElapsedMilliseconds;
            }
        }

        public void InitializeGame()
        {
            difficultySafety--;
            robber = new Player(50, 140);
            gemRec = new Gem(600, 200, 10, 10);

            livesLabel.Text = $"Lives: {lives}";

            for (int i = 0; i < difficulty; i++) // spawns enemies
            {
                NewLaser();
                NewEnemy();
            }
            for (int i = 0; i < difficultySafety; i++) // spawns safe areas
            {
                NewSafetyBox();
            }
            foreach (Safety s in safetyList) // spawns the player in a safe area
            {
                robber.x = s.safetyX + 30;
                robber.y = s.safetyY + 30;
            }
        }

        private void gameEngine_Tick(object sender, EventArgs e) 
        {
            // lets the player move 
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

            foreach (Laser l in laserList) // lets the lasers move
            {
                l.Move(this.Width);
            }
            foreach (Enemy en in enemyList) // lets the enemies track the robber
            {
                en.Move(robber);
            }
            if (gemRec.Collision(robber))
            {
                score++; // adds a point for the player
                gemPickUp.Play();
                foreach (Safety s in safetyList) // places the player back at the starting point after the gem is grabbed
                {
                    robber.x = s.safetyX + 30;
                    robber.y = s.safetyY + 30;
                }
                scoreOutputLabel.Text = $"Score: {score}";
            }
            foreach (Laser l in laserList)
            {
                if (l.Collision(robber)) // checks if the player has been hit by the lasers
                {
                    lives--;
                    laserHit.Play();
                    livesLabel.Text = $"Lives: {lives}";
                }
            }

            foreach (Enemy en in enemyList) // checks if the trackers have caught up to the player
            {
                if (en.Collision(robber))
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
                    if (l.Collision(s)) // checks for laser collision with safety box and changes height accordingly
                    {
                        l.laserHeight = s.safetyY - 1;
                        noCollision = false;
                        break;
                    }
                    if (noCollision) // if there is no collision height will stay the same
                    {
                        l.laserHeight = 800;
                    }
                }
            }
            if (lives <= 0) // ends the program if lives hit zero
            {
                score = 0;
                gameEngine.Stop();
                watchHS.Stop();
                ChangeScreen(this, new GameOverScreen());
            }
            if (score >= 5) // send the player to the next level if they collect the gem 5 times
            {
                gameEngine.Stop();
                watchHS.Stop();
                HighScore();
                lives = 5;
                Form1.ChangeScreen(this, new Level2());
            }
            Refresh();
        }

        public void NewLaser() //spawns the lasers at the start of the program
        {
            int laserX = randGen.Next(10, this.Width - 10);
            Laser newLaser = new Laser(laserX);
            laserList.Add(newLaser);
        }
        public void NewEnemy() //spawns the trackers at the start of the program
        {
            int enemyX = randGen.Next(100, this.Width - 10);
            int enemyY = randGen.Next(10, this.Height - 10);
            Enemy newEnemy = new Enemy(enemyX, enemyY);
            enemyList.Add(newEnemy);
        }
        public void NewSafetyBox() //spawns the safety boxes at the start of the program
        {
            int safetyX = randGen2.Next(10, this.Width - 100);
            int safetyY = randGen2.Next(10, this.Height - 100);
            Safety newSafetyBox = new Safety(safetyX, safetyY, 80, 80);
            safetyList.Add(newSafetyBox);
        }
        private void GameScreen_Paint(object sender, PaintEventArgs e) // paints the player, enemies, safetyboxes, and gem on the screen
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
        // ^ lets the player move 
        private void GameScreen_KeyUp(object sender, KeyEventArgs e)            // lets the player move 
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
