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
            Console.WriteLine("Geben sie die erste Zahl ein");
            int zahl1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Geben sie die zweite Zahl ein");
            int zahl2 = Convert.ToInt32(Console.ReadLine());

            //calculate
            int zahl3 = zahl1+zahl2;

            //print sum
            Console.WriteLine("Die Summe ihrer Zahlen ist: " + zahl3);

            //end Programm
            Console.ReadKey();  

        }
    }
}
