using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReedRun
{
    public static class DarkMode
    {
       public static bool darkMode = true;
        public static void SetDarkMode(bool b)
        {
            darkMode = !b;
        }
    }
}
