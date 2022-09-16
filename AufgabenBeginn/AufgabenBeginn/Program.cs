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
        public static void Main(string[] args)
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

            int min = numbers[0];
            int max = numbers[0];
            float avg = 0;

            for (int i = 0; i < count; i++)
            {
                if (max < numbers[i])
                {
                    max = numbers[i];
                }
                if(min > numbers[i])
                {
                    min = numbers[i];
                }
                avg = avg + numbers[i];
            }

            Console.WriteLine("Der Maximal wert ist: " + max);
            Console.WriteLine("Der Minimal wert ist: " + min);
            Console.WriteLine("Der Durchschnitt ist: " + avg/numbers.Length);

            Console.ReadKey();
        }     
    }
}
