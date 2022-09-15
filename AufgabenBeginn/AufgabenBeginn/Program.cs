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
            Console.WriteLine("Geben einen Text mit Semikolon ein");
            string txt = Console.ReadLine();

            string []split_txt = txt.Split(';');

            for (int i = 0; i < split_txt.Length; i++)
            {
                Console.WriteLine(split_txt[i]);
            }
            

            //end Programm
            Console.ReadKey();


        }
    }
}
