using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class Kreis:IGeometry
    {
        public float Radius { set; get; }

        public Kreis(float radius)
        {
            Radius = radius;
        }

        public float Umfang()
        {
            return 2 * (float)Math.PI * Radius;
        }
        public float Flaeche()
        {
            return (float)Math.PI* Radius*Radius;
        }

    }
}
