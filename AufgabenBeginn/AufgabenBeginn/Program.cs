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
            List<int> list = new List<int>() {5,3,7};
            
            Console.WriteLine(Sum(list)); 

            Console.ReadKey();
            
        }

        static int Sum(List<int> list)
        {
            int sum = 0;
            foreach (var item in list)
            {
                sum = sum + item;
            }

            return sum;
        }

    }
}