using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSConsoleGame.input
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
