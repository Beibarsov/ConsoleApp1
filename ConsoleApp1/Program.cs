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
            int selectid = 0;
            Interface myinterface = new Interface();
            Message message1 = new Message("Привет");
            Button button1 = new Button(1, "start", "Начать");
            Button button2 = new Button(2, "settings", "Настройки");
            Button button3 = new Button(3, "settings12", "Настройки12");

            //Console.BackgroundColor = ConsoleColor.Cyan;
            //Console.WriteLine(message1.ReturnText());

            ConsoleKeyInfo keyf1 = new ConsoleKeyInfo('z', ConsoleKey.Z, false, false, false);
            // message1.WriteLineText();
            while (true)
            {

                myinterface.PaintInterface();
                message1.WriteLineText();
                button1.PaintButton(selectid);
                button2.PaintButton(selectid);
                button3.PaintButton(selectid);


                switch (Console.ReadKey().Key) { 
                    case (ConsoleKey.PageDown):
                        selectid++;
                        break;
                    case (ConsoleKey.PageUp):
                        selectid--;
                        break;
                    default:
                        break;
                }
                //if (ConsoleKey.PageDown.Equals(Console.ReadKey().Key)) { 
                //    selectid++;
                //}
                //else if (ConsoleKey.PageUp.Equals(Console.ReadKey().Key))
                //{
                //    selectid--;
                //}
                

                //ConsoleKeyInfo arar;


                // Console.WriteLine(keyf1.KeyChar);
                //if (keyf1.Equals(arar = Console.ReadKey(true)))
                //{
                //    Console.WriteLine("Программа отображает ранее введенные строки. ");
                //}
                //else
                //{

                //}
                //Console.WriteLine("Можно вводить текст ниже");
                //message1.textmessage = Console.ReadLine();



                //  if (ConsoleKeyInfo.Equals(Console.ReadKey(), ConsoleKey.F1))

                Console.WriteLine(selectid);
                //Console.ReadKey();

                // Console.ReadLine();
            }


        }
    }
}
