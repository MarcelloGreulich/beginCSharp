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
            Console.WriteLine("Geben sie bitte eine fließkommerzahl ein");
            float zahl1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Geben sie bitte eine fließkommerzahl ein");
            float zahl2 = float.Parse(Console.ReadLine());

            //calculate
            float zahl3 = zahl1+zahl2;

            //Print sum
            Console.WriteLine("Das Ergebnis ist:" + zahl3);

            //end Programm
            Console.ReadKey();


        }
    }
}
