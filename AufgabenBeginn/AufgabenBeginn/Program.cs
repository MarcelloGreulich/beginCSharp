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

            //Count the length of the text
            int length_txt = txt.Length;

            //print Length of the text
            Console.WriteLine("Die Länge des eingegebenen Texts is: " + length_txt);

            //end Programm
            Console.ReadKey();  

        }
    }
}
