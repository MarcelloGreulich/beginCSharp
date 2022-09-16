using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Uebungen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wie viele Nummern sollen gespeichert werden");
            int count = Convert.ToInt32(Console.ReadLine());

            int[] numbers = new int[count];

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Bitte eine Zahl eingeben");
                int number = Convert.ToInt32(Console.ReadLine());
                numbers[i] = number;

            }

            Console.Clear();   

            Console.WriteLine("Der Maximal wert ist: " + numbers.Max());
            Console.WriteLine("Der Minimal wert ist: " + numbers.Min());
            Console.WriteLine("Der Durchschnitt ist: " + numbers.Average());

            Console.ReadKey();
        }
    }
}
