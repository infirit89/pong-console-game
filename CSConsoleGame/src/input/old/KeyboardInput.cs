using System;
using System.Collections.Generic;
using System.Text;

namespace CSConsoleGame.input.old
{
    public class KeyboardInput
    {

       protected static ConsoleKey m_Key;

        public void Update() 
        {
            do
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                m_Key = keyInfo.Key;

            } while (Console.KeyAvailable);
        }
    }
}
