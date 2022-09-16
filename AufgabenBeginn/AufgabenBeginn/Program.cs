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
        static void Main(string[] args)
        {

            Console.WriteLine("gib mir ein wort");
            string wort = Console.ReadLine();
            Console.Clear();

            var placeholder = new List<string>();

            for (int i = 0; i < wort.Length; i++)
            {
                placeholder.Add(" _ ");
                Console.Write(placeholder[i]);
            }

            

            int live = 10;
            while ( live > 0)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Buchstaben wählen");
                string buchstabe = Console.ReadLine();

                char[] newWort = wort.ToCharArray();
       
                for (int x = 0; x < newWort.Length; x++)
                {

                    Console.WriteLine(newWort[x]);
                    if (newWort[x]==Convert.ToChar(buchstabe))
                    {
                        Console.WriteLine("test");
             
                    }
                    
                }

                if (wort.Contains(buchstabe))
                {
                    Console.WriteLine("Rchtig!");
                    Console.WriteLine("Sie haben noch " + live + " übrig");
                }
                else { 
                    Console.WriteLine("Falsch!");
                    live--;
                    Console.WriteLine("Sie haben noch " + live + " übrig");
                }


                
            }


            /*  _____
              |   O
              |  -|-
             /\   /\
            */

            Console.ReadKey();
        }
    }
}
