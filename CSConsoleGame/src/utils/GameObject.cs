using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CSConsoleGame.math;

namespace CSConsoleGame.utils
{
    class GameObject
    {
        public Rectangle Rectangle;

        public string PlayerModel;
        private string m_Temp;

        public GameObject(Rectangle rectangle, string playerModel)
        {
            Rectangle = rectangle;

            PlayerModel = playerModel;
            m_Temp = PlayerModel;
        }

        public virtual void Draw()
        {
            for (int h = 0; h < Rectangle.Height; h++)
                PlayerModel += "\n" + m_Temp;

            for (int w = 0; w < Rectangle.Width; w++)
                PlayerModel += m_Temp;

            char[] mesh = PlayerModel.ToCharArray();

            for (int i = 0; i < Rectangle.Height; i++)
            {
                for (int p = 0; p < Rectangle.Width; p++)
                {
                    Rectangle.X = TMath.Clamp(Rectangle.X, 0, Console.BufferWidth - Rectangle.Width);
                    Rectangle.Y = TMath.Clamp(Rectangle.Y, 0, Console.BufferHeight - Rectangle.Height);

                    Console.SetCursorPosition(Rectangle.X + p, Rectangle.Y + i);
                    Console.Write(mesh[0]);
                }
            }
        }

        public virtual void Update() { }
    }
}
