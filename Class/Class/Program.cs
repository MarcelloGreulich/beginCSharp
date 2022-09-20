using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<Animal> animals = new List<Animal>();
            animals.Add(new Rihno("Günter",12,1500,15,2,false,false,true,"pfnnnpfnnnwüüüü"));
            animals.Add(new Ape("Hans", 3, 500, 8, 1, true, false, false, "ahhhahahahahahahah"));
            animals.Add(new Lion("Leonard", 5, 800, 16, 3, false, true, false, "pfnnnpfnnnwüüüü"));

            foreach (Animal a in animals) 
            {
                a.PrintAnimal();
                a.Nahrungsaufnahme();
                a.Wasseraufnahme();
                a.Gerausche();
                Console.WriteLine("----------------------------------");
            } 

            Console.ReadKey();


        }
    }
}
