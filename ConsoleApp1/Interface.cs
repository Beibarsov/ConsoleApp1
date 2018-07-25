using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Interface
    
    {
        int width;
        int height;
        string copyWrite;

        public Interface()
        {
            width = Console.WindowWidth;
            height = Console.WindowHeight;
            Console.SetBufferSize(width, height);
            copyWrite = "2018 (c) Vitaliy";
            
            //Console.WriteLine(width);
        }

        public void PaintInterface()
        {
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            int x = 0;
            while (x < width)
            {
                Console.Write("*");
                x++;
            }
            x = 0;
            Console.SetCursorPosition(0, height - 2);
            Console.Write("Для справки нажмите F1");
            Console.SetCursorPosition(width-copyWrite.Length-1, height-2);
            Console.WriteLine(copyWrite);
            while (x < width - 1)
            {
                Console.Write("*");
                x++;
            }
            Console.SetCursorPosition(0, 1);
        }
    }
}
