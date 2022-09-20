using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    internal class Dreieck:IGeometry
    {
        public int Seite1 { set; get; }
        public int Seite2 { set; get; }
        //hypotenuse
        public int Seite3 { set; get; }

        public Dreieck(int seite1, int seite2, int seite3)
        {
            Seite1 = seite1;
            Seite2 = seite2;
            Seite3 = seite3;
        }

        public float Umfang() 
        {
            return Seite1+Seite2+Seite3;  
        }

        public float Flaeche()
        {
            return 2;
        }



    }
}
