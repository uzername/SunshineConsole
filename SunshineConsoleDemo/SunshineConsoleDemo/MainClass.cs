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
            int maxrow = 25;
            int maxcol = 80;
            int row = 0; /*maxrow / 2;*/ // These 2 ints are the player's position.
            int col = 0; /*maxcol / 2;*/
            ConsoleWindow console = new ConsoleWindow(maxrow, maxcol, "Sunshine Console Demo - ESC to exit");
            System.Drawing.Rectangle savedBounds = console.Bounds;
            console.WindowBorder = OpenTK.WindowBorder.Fixed;
            console.Bounds = savedBounds;
            while (console.WindowUpdate())
            {
                for (int i = 0; i < maxrow; ++i)
                {
                    console.Write(i, 0, "".PadRight(maxcol, '#'), Color4.DimGray); // Let's make our black screen look more like a dungeon.
                }
                console.Write(row, col, '@', Color4.White); // And of course, our player character.
                switch (console.GetKey())
                { // If KeyPressed is false, GetKey() will return Key.Unknown.
                    case Key.Up:
                        row = Math.Max(0, row - 1); // In our basic example, we only check for arrow keys.
                        break;
                    case Key.Down:
                        row = Math.Min(row + 1, maxrow-1); // We make sure that row & col don't go beyond the edges of the map.
                        break;
                    case Key.Left:
                        col = Math.Max(0, col - 1);
                        break;
                    case Key.Right:
                        col = Math.Min(col + 1, maxcol-1);
                        break;
                }
            }
        }
    }
}
