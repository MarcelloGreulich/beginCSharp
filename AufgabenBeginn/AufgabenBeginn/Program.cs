using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            Random rnd = new Random();
            //Variablen
            int einsatz = 10;
            int kontostand = 10000;
            bool a=false;
            int i = 0;
            do
	        {
                int lastbet = einsatz;
                int k = rnd.Next(0, 37);
                kontostand = kontostand - einsatz;
                if (kontostand>=10000 && a==true)
	            {
                    einsatz=10;
	            }
                else if(kontostand>=10000 && a==false)
                {
                    einsatz = einsatz*2;
                }
                else if (kontostand<10000)
                {
                    int gesamtverlust = 10000 - kontostand;
                    einsatz=gesamtverlust*2;
                }else if (kontostand <= lastbet)
                {
                    einsatz = kontostand;
                }
                
                if (einsatz>=1000)
	            {
                    einsatz=1000;
	            }

                if (k%2==0 && k!=0)
                {
                    kontostand = kontostand + 2 * einsatz;
                    a = true;
                }
                else if (k % 2 == 1) 
                { 
                   a = false;
                }else if (k == 0)
                {
                    einsatz=einsatz;
                    kontostand=kontostand+einsatz;
                }
                i++;
                Console.WriteLine($"Anzahl der Spiele :{i}");
                Console.WriteLine($"Geworfene Zahl: {k}");
                Console.WriteLine($"Altes Kapital :{kontostand+einsatz}");
                Console.WriteLine($"Neuer Kontostand: {kontostand}");
                Console.WriteLine(einsatz);  
              
	        } while (kontostand - einsatz >=0);

            Console.ReadKey();
        }
    }
}