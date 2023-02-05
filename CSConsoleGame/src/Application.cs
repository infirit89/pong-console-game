using System;

using System.Threading;

using CSConsoleGame.math;
using CSConsoleGame.input;

namespace CSConsoleGame
{
    class Application
    {
        bool m_Running = true;

        Input input = new Input();

        Ball ball;

        Player player;
        SecondPlayer player2;

        ScoreUI scoreUI;


        Window window;


        public Application() 
        {
            window = Window.CreateWindow(120, 40, "Make-belive Pong");

            Console.CursorVisible = false;
            
        }

        public void Run() 
        {
            Start();

            while (m_Running)
            {
                DrawFrame();

                Update();

                Thread.Sleep(50);
            }
        }

        private void DrawFrame() 
        {
            Console.Clear();

            player.Draw();
            player2.Draw();

            ball.Draw();

            scoreUI.Draw();

        }

        private void Update() 
        {
            input.Update();

            player.Update();
            player2.Update();
            ball.Update();

            scoreUI.Update();

            if (ball.isColliding(player.Rectangle))
            {
                ball.Rectangle.X++;

                ball.NewRandomDirection();

            }
            else if (ball.isColliding(player2.Rectangle))
            {
                ball.Rectangle.X--;

                ball.NewRandomDirection();
            }

            if (ball.Rectangle.X <= 0)
            {
                scoreUI.p2Score++;
                Reset();
            }
            else if (ball.Rectangle.X + ball.Rectangle.Width >= window.GetWidth())
            {
                scoreUI.p1Score++;
                Reset();
            }

            if (ball.Rectangle.Y + ball.Rectangle.Height >= window.GetHeight())
                ball.NewYDirection();
            else if (ball.Rectangle.Y <= 3)
                ball.NewYDirection();

            if (Keyboard.isKeyHeld(Keys.Escape))
                m_Running = false;
        }

        private void Start() 
        {
            ball = new Ball(new Rectangle(window.GetWidth() / 2, window.GetHeight() / 2, 2, 2), "O");

            player = new Player(new Rectangle(4, 3, 1, 6), "█");
            player2 = new SecondPlayer(new Rectangle(window.GetWidth() - 4, 10, 1, 6), "█");

            scoreUI = new ScoreUI(new Rectangle(0, 2, window.GetWidth(), 1), "-", window);

        }

        private void Reset() 
        {
            ball.Rectangle.X = window.GetWidth() / 2;
            ball.Rectangle.Y = window.GetHeight() / 2;

            ball.NewRandomDirection();
        }
    }
}
