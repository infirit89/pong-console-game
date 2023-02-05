using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSConsoleGame.src
{
    class TestWorld
    {

        private string[,] m_Grid;
        private int rows, colms;

        public TestWorld(string[,] grid) 
        {
            m_Grid = grid;
            rows = m_Grid.GetLength(0);
            colms = m_Grid.GetLength(1);
        }

        public void Draw() 
        {
            for (int y = 0; y < rows; y++)
            {
                for (int x = 0; x < colms; x++)
                {
                    string element = m_Grid[y, x];
                    Console.SetCursorPosition(x, y);
                    Console.Write(element);
                }
            }
        }

        public bool isPosWalkable(int x, int y) 
        {
            return m_Grid[y, x] == " ";
        }
    }
}
