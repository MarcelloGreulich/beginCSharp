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
            Console.WriteLine("Geben eine Zahl ein");
            int number1 = Convert.ToInt32(Console.ReadLine());
            int ergebnis = 0;
            for (int i = 0; i < number1; i++)
            { 
                ergebnis = ergebnis + i;
                Console.WriteLine(ergebnis-i + "+" + i + "=" + ergebnis); 
            }

            Console.ReadKey();

        }
    }
}
