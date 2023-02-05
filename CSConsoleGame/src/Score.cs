using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CSConsoleGame.utils;
using CSConsoleGame.math;

namespace CSConsoleGame
{
    class Score : GameObject
    {
        public Score(Rectangle rectangle, string playerModel) : base(rectangle, playerModel)
        {
        }

        public override void Draw()
        {
            Console.SetCursorPosition(Rectangle.X, Rectangle.Y);
            Console.Write(PlayerModel);
        }

    }
}
