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

            string a = "y";
            int number;

            Console.Write($"Möchten sie außer ");
            foreach (var item in list)
            {
                Console.Write(item + ", ");
            }
            Console.Write("noch weitere Zahlen hinzufügen? (y/n)");
            Console.WriteLine(" ");
            a = Console.ReadLine();

            do
            {
                Console.WriteLine("welche zahlen wollen sie nocch hinzufügen");
                number = Convert.ToInt32(Console.ReadLine());
                list.Add(number);


                Console.Write($"Möchten sie außer ");
                foreach (var item in list)
                {
                    Console.Write(item + ", ");
                }
                Console.Write("noch weitere Zahlen hinzufügen? (y/n)");
                Console.WriteLine(" ");
                a = Console.ReadLine();
            } while (a == "y");


                foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();


            
            

        }

    }
}