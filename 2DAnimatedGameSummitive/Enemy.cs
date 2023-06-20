using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _2DAnimatedGameSummitive
{
    internal class Enemy
    {
        public int enemyX, enemyY;
        public int enemyWidth = 8;
        public int enemyHeight = 8;
        public int enemySpeed = 1;
        public Enemy(int _enemyX, int _enemyY)
        {
            enemyX = _enemyX;
            enemyY = _enemyY;
        }

        public void Move(Player p)
        {
            if (enemyX > p.x)
            {
                enemyX -= enemySpeed;
            }
            else 
            {
                enemyX += enemySpeed;
            }
            if (enemyY > p.y)
            {
                enemyY -= enemySpeed;
            }
            else
            {
                enemyY += enemySpeed;
            }
        }

        public bool Collision(Player p)
        {
            Rectangle playerRec = new Rectangle(p.x, p.y, p.width, p.height);
            Rectangle enemyRec = new Rectangle(enemyX, enemyY, enemyWidth, enemyHeight);

            if (playerRec.IntersectsWith(enemyRec))
            {
                if (enemyX >= p.x)
                {
                    enemyX = 5;
                }
                if (enemyY >= p.y)
                {
                    enemyY = 5;
                }
                if (enemyY <= p.y)
                {
                    enemyY = 5;
                }
                if (enemyX >= p.x)
                {
                    enemyX = 800;
                }
                return true;
            }
            return false;
        }
        //public bool Collision (Safety s)
        //{
        //    Rectangle enemyRec = new Rectangle(enemyX, enemyY, enemyWidth, enemyHeight);
        //    Rectangle safetyRec = new Rectangle(s.safetyX, s.safetyY, s.safetyWidth, s.safetyHeight);

        //    if (enemyRec.IntersectsWith(safetyRec))
        //    {
        //        if (enemyX >= s.safetyX)
        //        {
        //            enemyX++;
        //        }
        //        if (enemyY >= s.safetyY)
        //        {
        //            enemyY++;
        //        }
        //        if (enemyX <= s.safetyX)
        //        {
        //            enemyX--;
        //        }
        //        if (enemyY <= s.safetyY)
        //        {
        //            enemyY--;
        //        }
        //        return true;
        //    }
        //    return false;
        //}
    }
}
