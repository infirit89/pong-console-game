using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSConsoleGame.input
{
    class Keyboard : KeyboardInput
    {

        public static bool isKeyPressed(int key) => m_KeysPressed[key];
        public static bool isKeyPressed(Keys key) => isKeyPressed((int)key);


        public static bool isKeyHeld(int key) => m_KeysHeld[key];
        public static bool isKeyHeld(Keys key) => isKeyHeld((int)key);


        public static bool isKeyReleased(int key) => m_KeysReleased[key];
        public static bool isKeyReleased(Keys key) => isKeyReleased((int)key);
    }
}
