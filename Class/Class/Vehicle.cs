using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public abstract class Vehicle
    {
        public int TypeId { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string TypeName { get; set; }
        public int CCM { get; set; }
        public string Color { get; set; }
        public int Tyres { get; set; }

        public bool MotorLauft { get; private set; }

        public int Geschwindigkeit { get; private set; }
        public void Starten()
        {
            if(MotorLauft == true)
            {
                Console.WriteLine("Motor läuft schon)");

            }
            else
            {
                MotorLauft = true;
                Console.WriteLine("Motor wird gestartet!..WRRRRUUUUMMMMM");
            }        
        }

        public void Beschleunigen()
        { 
            Geschwindigkeit += 10;
        }

        public void Bremsen()
        {
            if (Geschwindigkeit<=0)
            {
                Console.WriteLine($"{this.GetType()} steht bereits!");
            }
            Geschwindigkeit -= 10;
            Console.WriteLine($"{this.GetType().Name} wird gebrems");
        }
    }
}
