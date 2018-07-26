using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Button
    {

        int id;
        string name;
        string description;
        public int count = 0;
       // bool selected = false;

        public Button (int _id, string _name, string _description)
        {
            this.id = _id;
            this.name = _name;
            this.description = _description;
            count++;

        }

        public void PaintButton(int _id)
        {
            if (_id == id)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("{0}", description);
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.WriteLine("{0}", description);
            }
            
        }

        //public void SelectButton()
        //{

        //    Console.ForegroundColor = ConsoleColor.Red;
        //    Console.WriteLine("{0}", description);
        //    Console.ForegroundColor = ConsoleColor.White;

        //}
    }
}
