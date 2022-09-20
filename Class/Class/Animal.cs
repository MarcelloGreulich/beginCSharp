using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public int Alter { get; set; }
        public int Gewicht { get; set; }
        public int Lebensdauer { get; set; }
        public int Groese { get; set; }
        public bool Fell { get; set; }

        public bool Essen { get; set; }
        public bool Trinken { get; set; }
        public string Gerausch { get; set; }    
        public void PrintAnimal()
        {
            string x;
            if (Fell == true)
            {
                x = " ";
            }
            else
            {
                x = " kein ";
            }
            Console.WriteLine($"{this.GetType().Name} heißt {Name} und ist {Alter} Jahre Alt. Es wiegt {Gewicht} Kilo und hat eine Lebensdauer von {Lebensdauer} Jahren");
            Console.WriteLine($"{Name} ist {Groese} Meter Groß und hat{x}fell");
        }
        public void Nahrungsaufnahme()
        {

            if (Essen == true)
            {
                Console.WriteLine($"{this.GetType().Name} ist bereits am essen");
            }
            else
            {
                Essen = true;
                Console.WriteLine($"{this.GetType().Name} begibt sich nun zum essen");
            }

        }

        public void Wasseraufnahme()
        {
            if (Trinken == true)
            {
                Console.WriteLine($"{this.GetType().Name} ist bereits am trinken");
            }
            else
            {
                Console.WriteLine($"{this.GetType().Name} begibt sich nun zum Trinken");
            }


        }

        public abstract void Gerausche(); 

    }
}
