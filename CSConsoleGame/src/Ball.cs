using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CSConsoleGame.utils;
using CSConsoleGame.math;

namespace CSConsoleGame
{
    class Ball : GameObject
    {
        Random rng = new Random();
        public int dirX = 1, dirY = 1;

        
        public Ball(Rectangle rectangle, string playerModel) : base(rectangle, playerModel)
        {
            dirX = rng.Next(0, 2) == 0 ? -1 : 1;
            dirY = rng.Next(-1, 2);
        }

        public bool isColliding(Rectangle other)
        {
            if (((Rectangle.X + Rectangle.Width > other.X) && (Rectangle.X < other.X + other.Width)) 
              && ((Rectangle.Y + Rectangle.Height > other.Y) && (Rectangle.Y < other.Y + other.Height))) 
                return true;

            return false;
        }

        public override void Update()
        {
            Rectangle.X += dirX;
            Rectangle.Y += dirY;

            base.Update();
        }

        public void NewRandomDirection() 
        {
            int nextX = rng.Next(0, 2) == 0 ? -2 : 2;
            int nextY = rng.Next(-1, 2);
            nextY = nextY == 0 ? -1 : nextY;

            dirX = nextX;
            dirY = nextY;
        }

        public void NewYDirection() 
        {
            dirY = -dirY;
        }
    }
}
