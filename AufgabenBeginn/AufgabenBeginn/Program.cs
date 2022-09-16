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
            /* list.Insert(1, 99);
            list.Add(91);
            list.Add(92);
            list.Add(93);
            list.RemoveAt(0);
            list.Remove(99);
            list.RemoveAt(list.Count - 1);
            */
            List(list);

            foreach (var item in list)
            {
                if (item > 80)
                {
                    list.Remove(item);
                }
            }

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();


            
            

        }

        static List<int> List(List<int> list)
        {
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

            return list;



        }

    }
}