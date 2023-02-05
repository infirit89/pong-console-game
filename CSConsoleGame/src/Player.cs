using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CSConsoleGame.utils;
using CSConsoleGame.math;

using CSConsoleGame.input;

namespace CSConsoleGame
{
    class Player : GameObject
    {
        public Player(Rectangle rectangle, string playerModel) : base(rectangle, playerModel)
        {
        }

        public override void Update()
        {
            if (Keyboard.isKeyHeld(Keys.W))
            {
                if (Rectangle.Y >= 4)
                    Rectangle.Y--;
            }
            else if (Keyboard.isKeyHeld(Keys.S))
                Rectangle.Y++;

            base.Update();
        }
    }
}
