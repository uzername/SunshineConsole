using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SunshineConsole;
using OpenTK.Graphics;
using OpenTK.Input;

namespace SunshineConsoleDemo
{
    public class MainClass
    {
        public static void Main()
        {
            ConsoleWindow console = new ConsoleWindow(16, 40, "Sunshine Console");
            console.Write(6, 14, "Sunshine Console", Color4.White);
            while (!console.KeyPressed && console.WindowUpdate())
            {

            }
        }
    }
}
