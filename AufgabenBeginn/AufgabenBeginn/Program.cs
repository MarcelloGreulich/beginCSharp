using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebungen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ask user for number
            Console.WriteLine("Geben einen Text ein");
            string txt = Console.ReadLine();

            txt = txt.PadRight(20,'y');
                    

            Console.WriteLine(txt);

            //end Programm
            Console.ReadKey();


        }
    }
}
