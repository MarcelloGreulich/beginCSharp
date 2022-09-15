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
            Console.WriteLine("Geben sie bitte einen Text ein");
            string txt = Console.ReadLine();


            //Replace "U" and "u" with "G" and "g"
            string replaced_txt = txt.Replace("U", "G").Replace("u", "g");

            //print Replaced Text
            Console.WriteLine("Ihr Veränderter Text ist: " + replaced_txt);

            //end Programm
            Console.ReadKey();  

        }
    }
}
