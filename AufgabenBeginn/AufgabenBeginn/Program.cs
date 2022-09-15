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
            
            while (number1>0)
            {
                number1--;
                Console.WriteLine(number1);
                
            }

            Console.ReadKey();

        }
    }
}
