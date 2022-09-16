using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Uebungen
{
    internal class Programm
    {
        public static void Main(string[] args)
        {   
            Console.WriteLine("Bitte geben sie eine zahl an");
            int num1 = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Bitte geben sie eine zahl an");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Sum(num1, num2));

            Console.ReadKey();
            
        }

        static int Sum(int num1, int num2)
        {
            int sum = 0;
            sum = num1 + num2;
            return sum;
        }

    }
}