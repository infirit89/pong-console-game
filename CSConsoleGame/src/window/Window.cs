using System;
using System.Collections.Generic;
using System.Text;

using CSConsoleGame.src.window;

using System.Runtime.InteropServices;

namespace CSConsoleGame
{
    class Window
    {

        const int SWP_NOZORDER = 0x4;
        const int SWP_NOACTIVE = 0x10;

        [DllImport("kernel32")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32")]
        static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int x, int y, int cx, int cy, int flags);

        private static int m_Width, m_Height;

        public static Window CreateWindow(int width, int height, string title) 
        {
            m_Width = width;
            m_Height = height;

            Console.Title = title;

            int screenWidth = DisplayTools.GetScreenSize().Width;
            int screenHeight = DisplayTools.GetScreenSize().Height;

            //SetWindowPosition(0, 0, m_Width, m_Height);
            Console.SetWindowSize(m_Width, m_Height);
            Console.SetBufferSize(m_Width, m_Height);

            //Console.SetWindowPosition(Console.WindowLeft, Console.WindowTop + 1);

            return new Window();
        }

        public void RescaleWindow(int width, int height) 
        {
            m_Width = width;
            m_Height = height;
            Console.SetWindowSize(m_Width, m_Height);
        }

        public int GetWidth() => m_Width;
        public int GetHeight() => m_Height;

        public static void SetWindowPosition(int x, int y, int width, int height) 
        {
            SetWindowPos(Handle, IntPtr.Zero, x, y, width, height, SWP_NOZORDER | SWP_NOACTIVE);
        }

        private static IntPtr Handle 
        {
            get 
            {
                return GetConsoleWindow();
            }
        }
    }
}
