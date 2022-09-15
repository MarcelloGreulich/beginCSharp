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
            Console.WriteLine("Azubi&studentenliste nach Buchstaben Filtern");
            string x = Console.ReadLine();
            string azubis = "asfd,saedsda,asdasd,awesd";
            string[] list = azubis.Split(',');
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i].Contains(x))
                {
                    Console.WriteLine(list[i]);
                }
            }

            Console.ReadKey();

        }
    }
}
