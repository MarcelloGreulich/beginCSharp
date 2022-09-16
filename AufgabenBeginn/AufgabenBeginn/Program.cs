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
            string num1 = Console.ReadLine(); 
            Console.WriteLine("Bitte geben sie eine zahl an");
            string num2 =Console.ReadLine();

            Console.WriteLine(Sum(num1, num2));

            Console.ReadKey();
            
        }

        static string Sum(string num1,  string num2)
        {
            string sum;
            sum = num1 + num2;
            return sum;
        }

    }
}