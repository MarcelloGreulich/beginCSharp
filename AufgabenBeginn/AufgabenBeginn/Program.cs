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
            //Ask user for number
            Console.WriteLine("Geben einen Text mit leerzeichen davor und dannach ein");
            string txt = Console.ReadLine();

            string remove_txt = txt.TrimStart(' ').TrimEnd(' ');
                    

            Console.WriteLine(remove_txt);

            //end Programm
            Console.ReadKey();


        }
    }
}
