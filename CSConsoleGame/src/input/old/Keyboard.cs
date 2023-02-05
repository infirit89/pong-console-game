using System;
using System.Collections.Generic;
using System.Text;

namespace CSConsoleGame.input.old
{
    public class Keyboard : KeyboardInput
    {
        public static bool isKeyPressed(ConsoleKey key) 
        {
            if (m_Key == key) 
            {
                m_Key = 0;
                return true;
            }

            return false;
        }

        public static bool isKeyHeld(ConsoleKey key) => m_Key == key;

    }
}
