using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _2DAnimatedGameSummitive
{
    internal class Laser
    {
        public int laserX, laserY, xSpeed = 8;
        public int laserWidth = 10;
        public int laserHeight = 300;

        public Laser(int _laserX)
        {
            laserX = _laserX;
        }

        public void Move(int width)
        {
            laserX += xSpeed;


            if (laserX > width - laserWidth || laserX < 0)
            {
                xSpeed *= -1;
            }
        }

        public bool Collision(Safety s)
        {
            Rectangle laserRec = new Rectangle(laserX, laserY, laserWidth, laserHeight);
            Rectangle safetyRec = new Rectangle(s.safetyX, s.safetyY, s.safetyWidth, s.safetyHeight);

            if (laserRec.IntersectsWith(safetyRec))
            {
                return true;
            }

            if (laserX - s.safetyX < laserWidth + s.safetyWidth && laserX - s.safetyX > 0)
            {
                return true;
            }
            return false;
        }

        //public void Collision(Safety s)
        //{
        //    Rectangle laserRec = new Rectangle(laserX, laserY, laserWidth, laserHeight);
        //    Rectangle safetyRec = new Rectangle(s.safetyX, s.safetyY, s.safetyWidth, s.safetyHeight);

        //    if (laserRec.IntersectsWith(safetyRec))
        //    {
        //        laserHeight = s.safetyY - 1;
        //    }
        //    if (!laserRec.IntersectsWith(safetyRec))
        //    {
        //        laserHeight = 300;
        //    }
        //}


        public bool Collision(Player p)
        {
            Rectangle laserRec = new Rectangle(laserX, laserY, laserWidth, laserHeight);
            Rectangle playerRec = new Rectangle(p.x, p.y, p.width, p.height);

            if (laserRec.IntersectsWith(playerRec))
            {
                if (xSpeed > 0)
                {
                    laserX = p.x - laserWidth;
                }
                xSpeed *= -1;
                return true;
            }
            return false;
        }
    }
}