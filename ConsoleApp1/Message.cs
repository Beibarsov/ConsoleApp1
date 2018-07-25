using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Message
    {
        public string textmessage;

        public enum MyEnum
        {
            Blue, Red
        }


        public Message(string textmessage)
        {
            this.textmessage = textmessage;
        }

        public string ReturnText()
        {
            return textmessage;
        }

        public void WriteLineText()
        {
            
            //ConsoleColor[] myColor = new ConsoleColor[2];
            //myColor[0] = ConsoleColor.Blue;
            //myColor[1] = ConsoleColor.Red;
            ////int r = Convert.ToInt32(Console.ReadLine()) - 1; 
            //Console.ForegroundColor = myColor[(int)MyEnum.Red];
            Console.WriteLine(textmessage+"\n\n");

            //Console.ResetColor();
            //Console.WriteLine(textmessage);


        }
    }
}
