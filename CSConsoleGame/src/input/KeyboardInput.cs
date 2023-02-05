using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.InteropServices;

namespace CSConsoleGame.input
{

    class KeyboardInput
    {
        [DllImport("user32")]
        static extern short GetAsyncKeyState(Int32 key);

        long[] m_CurrKeyState = new long[256], m_LastKeyState = new long[256];

        protected static bool[] m_KeysPressed = new bool[256], m_KeysReleased = new bool[256], m_KeysHeld = new bool[256];

        protected static byte[] m_Keys = new byte[256];

        public void Update() 
        {
            for (int i = 0; i < 256; i++)
            {
                m_LastKeyState[i] = m_CurrKeyState[i];
                m_CurrKeyState[i] = GetAsyncKeyState(i);

                m_KeysPressed[i] = false;
                m_KeysReleased[i] = false;


                // if the current key state isnt equal to the last time we checked the same key state
                if (m_CurrKeyState[i] != m_LastKeyState[i])
                {
                    // if the key is down
                    if (0 != (m_CurrKeyState[i] & 0x8000))
                    {
                        m_KeysPressed[i] = !m_KeysHeld[i];
                        m_KeysHeld[i] = true;

                    }
                    else
                    {
                        m_KeysReleased[i] = true;
                        m_KeysHeld[i] = false;
                    }
                }
            }
        }
    }

}
