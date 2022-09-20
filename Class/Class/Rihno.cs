using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    internal class Rihno:Animal
    {
        public Rihno(string name, int alter, int gewicht, int lebensdauer, int groese, bool fell, bool essen, bool trinken, string gerausch)
        {
            Name = name;
            Alter = alter;
            Gewicht = gewicht;
            Lebensdauer = lebensdauer;
            Groese = groese;
            Fell = fell;
            Essen = essen;
            Trinken = trinken;
            Gerausch = gerausch;
   
         
        }
        public override void Gerausche()
        {
            Console.WriteLine($"{this.GetType().Name} macht {Gerausch}");
        }
    }
}
