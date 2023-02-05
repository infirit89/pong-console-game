using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSConsoleGame.math
{
    class TMath
    {
        public static int Clamp(int value, int min, int max) 
        {
            if (value > max)
                return max;
            else if (value < min)
                return min;

            return value;
        }
    }
}
