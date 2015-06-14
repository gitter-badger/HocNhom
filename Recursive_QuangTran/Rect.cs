using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursive_QuangTran
{
    class Rect
    {
        int count = 0;
        public void drawRect(int x, int y, int width, int height)
        {
            count++;
            if (count % 2 == 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.SetCursorPosition(x, y);
            for (int i = 0; i < height; i++)
            {
                //Console.SetCursorPosition(x, y + i);
                for (int j = 0; j < width; j++)
                {
                    if (i == 0 || i == height - 1 || j == 0 || j == width - 1)
                    {
                        Console.SetCursorPosition(x + j, y + i);
                        if (j == width - 1)
                        {
                            Console.WriteLine("x");
                        }
                        else
                        {
                            Console.Write("x");
                        }
                    }
                }
            }
            if (width < 2 || height < 2)
                return;

            drawRect(x + 2, y + 2, width - 4, height - 4);
          
        }
    }
}
