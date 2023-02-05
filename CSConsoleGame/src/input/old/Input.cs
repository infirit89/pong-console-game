using System;
using System.Collections.Generic;
using System.Text;

namespace CSConsoleGame.input.old
{
    class Input
    {
        KeyboardInput keyboardInput = new KeyboardInput();
        public void Update() 
        {
            keyboardInput.Update();
        }
    }
}
