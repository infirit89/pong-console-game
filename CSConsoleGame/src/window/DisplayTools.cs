using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows;
using System.Drawing;

using System.Runtime.InteropServices;

namespace CSConsoleGame.src.window
{
    static class DisplayTools
    {
        [DllImport("gdi32.dll")]
        static extern int GetDeviceCaps(IntPtr hdc, int nIndex);

        private enum DeviceCap 
        {
            DesktopVertRes = 117,
            DesktopHorRes = 118
        }

        public static Size GetScreenSize() 
        {
            Graphics g = Graphics.FromHwnd(IntPtr.Zero);
            IntPtr desktop = g.GetHdc();

            int screenWidth = GetDeviceCaps(desktop, (int)DeviceCap.DesktopVertRes);
            int screenHeight = GetDeviceCaps(desktop, (int)DeviceCap.DesktopHorRes);

            return new Size(screenWidth, screenHeight);
        }
    }
}
