using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CSConsoleGame.math;
using CSConsoleGame.utils;

namespace CSConsoleGame
{
    class ScoreUI : GameObject
    {
        private Score p1ScoreObj, p2ScroreObj;

        public int p1Score = 0, p2Score = 0;

        public ScoreUI(Rectangle rectangle, string playerModel, Window window) : base(rectangle, playerModel)
        {
            p1ScoreObj = new Score(new Rectangle(2, 1, 1, 1), $"Score: {p1Score}");
            p2ScroreObj = new Score(new Rectangle(window.GetWidth() - 10, 1, 1, 1), $"Score: {p2Score}");
        }

        public override void Draw()
        {
            p1ScoreObj.Draw();
            p2ScroreObj.Draw();

            base.Draw();
        }

        public override void Update()
        {
            p1ScoreObj.PlayerModel = $"Score: {p1Score}";
            p2ScroreObj.PlayerModel = $"Score: {p2Score}";

            base.Update();
        }

    }
}
