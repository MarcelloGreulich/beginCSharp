using System;
using System.Collections.Generic;
using System.ComponentModel;
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

           List<string> names = new List<string>();

            Console.WriteLine("wie viele namen wollen sie speichern?");
            int count = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < count; i++)
            {
                Console.WriteLine("Bitte geben Sie den ersten namen ein");
                string name = Console.ReadLine();
                names.Add(name);
            }

            Console.Clear();

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            Console.ReadKey();

        }
    }
}
