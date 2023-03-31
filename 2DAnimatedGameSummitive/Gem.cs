using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _2DAnimatedGameSummitive
{
    internal class Gem
    {
        public int x, y, xSpeed, ySpeed;
        public int size = 30;

        public Gem(int _x, int _y, int _xSpeed, int _ySpeed)
        {
            x = _x;
            y = _y;
            xSpeed = _xSpeed;
            ySpeed = _ySpeed;
        }
        public bool Collision(Player p)
        {
            Rectangle playerRec = new Rectangle(p.x, p.y, p.width, p.height);
            Rectangle gemRec = new Rectangle(x, y, size, size);

            if (playerRec.IntersectsWith(gemRec))
            {

                return true;
            }
            return false;
        }
    }
}
