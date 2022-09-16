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
            Console.WriteLine("Blitte gebe eine Zahl an");
            int zahl1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Blitte gebe eine Zahl an");
            int zahl2 = Convert.ToInt32(Console.ReadLine());

            float[] ergebniss = new float[4];

            ergebniss[0] = Add(zahl1, zahl2);
            ergebniss[1] = Sub(zahl1, zahl2);
            ergebniss[2] = Multi(zahl1, zahl2);
            ergebniss[3] = Div(zahl1, zahl2);

            foreach (var item in ergebniss)
            {
                Console.WriteLine(item);
            }
            
            Console.ReadKey();

        }

        static float Add(int zahl1, int zahl2)
        {
            float summe = zahl1 + zahl2;
            return summe;
        }

        static float Sub(int zahl1, int zahl2)
        {
            float summe = zahl1 - zahl2;
            return summe;
        }
        static float Multi(int zahl1, int zahl2)
        {
            float summe = zahl1 * zahl2;
            return summe;
        }
        static float Div(int zahl1, int zahl2)
        {
            float summe = zahl1 / zahl2;
            return summe;
        }
    }
}