using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)

        {
            
            Interface myinterface = new Interface();
            Message message1 = new Message("Привет");
            //Console.BackgroundColor = ConsoleColor.Cyan;
            //Console.WriteLine(message1.ReturnText());

            ConsoleKeyInfo keyf1 = new ConsoleKeyInfo('z', ConsoleKey.Z, false, false, false);
            // message1.WriteLineText();
            while (true)
            {

                myinterface.PaintInterface();
                message1.WriteLineText();
                ConsoleKeyInfo arar;


               // Console.WriteLine(keyf1.KeyChar);
                if (keyf1.Equals(arar = Console.ReadKey(true)))
                {
                    Console.WriteLine("Программа отображает ранее введенные строки. ");
                }
                else
                {
                    
                }
                Console.WriteLine("Можно вводить текст ниже");
                message1.textmessage = Console.ReadLine();
                //string a = Convert.ToString(Console.ReadKey());
                //    Console.WriteLine(a);

                

                //  if (ConsoleKeyInfo.Equals(Console.ReadKey(), ConsoleKey.F1))


               // Console.ReadKey();

                // Console.ReadLine();
            }


        }
    }
}
