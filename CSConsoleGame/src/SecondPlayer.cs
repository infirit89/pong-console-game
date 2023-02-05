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
    class SecondPlayer : GameObject
    {
        public SecondPlayer(Rectangle rectangle, string playerModel) : base(rectangle, playerModel)
        {
        }

        public override void Update()
        {
            if (Keyboard.isKeyHeld(Keys.UpArrow))
            {
                if (Rectangle.Y >= 4)
                    Rectangle.Y--;
            }
            else if (Keyboard.isKeyHeld(Keys.DownArrow))
                Rectangle.Y++;

            base.Update();
        }
    }
}
