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
            while (live > 0)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Buchstaben wählen");
                string buchstabe = Console.ReadLine();

                Console.Clear();

                char[] newWort = wort.ToCharArray();

                if (wort.Contains(buchstabe))
                {
                    Console.WriteLine("Rchtig!");
                }
                else
                {
                    Console.WriteLine("Falsch!");
                    live--;
                }

                for (int x = 0; x < newWort.Length; x++)
                {

                    if (newWort[x] == Convert.ToChar(buchstabe))
                    {
                        placeholder[x] = buchstabe;

                    }
                    Console.Write(placeholder[x]);

                }
                Console.WriteLine(" ");

                if (wort.Contains(buchstabe))
                {
                    if (Convert.ToString(placeholder) == Convert.ToString(wort))
                    {
                        Console.WriteLine("Sie haben noch " + live + " übrig");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Sie haben Gewonnen");
                    }
                }
                else
                {
                    Console.WriteLine("Sie haben noch " + live + " übrig");
                    if (live == 9)
                    {
                        Console.WriteLine("/\\");
                    }
                    else if (live == 8)
                    {
                        Console.WriteLine("| ");
                        Console.WriteLine("/\\");
                    }
                    else if (live == 7)
                    {

                        Console.WriteLine("|");
                        Console.WriteLine("|");
                        Console.WriteLine("/\\");
                    }
                    else if (live == 6)
                    {
                        Console.WriteLine("_____");
                        Console.WriteLine("|");
                        Console.WriteLine("|");
                        Console.WriteLine("/\\");
                    }
                    else if (live == 5)
                    {
                        Console.WriteLine("_____");
                        Console.WriteLine("|   O");
                        Console.WriteLine("|");
                        Console.WriteLine("/\\");
                    }
                    else if (live == 4)
                    {
                        Console.WriteLine("_____");
                        Console.WriteLine("|   O");
                        Console.WriteLine("|   |");
                        Console.WriteLine("/\\");
                    }
                    else if (live == 3)
                    {
                        Console.WriteLine("_____");
                        Console.WriteLine("|   O");
                        Console.WriteLine("|  -|");
                        Console.WriteLine("/\\");
                    }
                    else if (live == 2)
                    {
                        Console.WriteLine("_____");
                        Console.WriteLine("|   O");
                        Console.WriteLine("|  -|-");
                        Console.WriteLine("/\\  ");
                    }
                    else if (live == 1)
                    {
                        Console.WriteLine("_____");
                        Console.WriteLine("|   O");
                        Console.WriteLine("|  -|-");
                        Console.WriteLine("/\\  /");
                    }
                    else if (live == 0)
                    {
                        Console.WriteLine("_____");
                        Console.WriteLine("|   O");
                        Console.WriteLine("|  -|-");
                        Console.WriteLine("/\\  /\\");
                    }

                }

            }

            Console.ReadKey();

        }
    }
}
