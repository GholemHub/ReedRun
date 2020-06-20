using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReedRun
{
    public static class DarkMode
    {
        public static int speed = 300;

        public static bool darkMode = true;
        public static Color color;
        public static void SetDarkMode(bool b)
        {
            darkMode = !b;
        }
    }
}
