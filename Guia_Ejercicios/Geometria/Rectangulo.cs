using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    class Rectangulo
    {
        private float area;
        private float perimetro;
        Punto vertice1;
        Punto vertice2;
        Punto vertice3;
        Punto vertice4;

        public Rectangulo() { }


        public float Area()
        {
            return this.area;
        }

        public float Perimetro()
        {
            return this.perimetro;
        }
    }
}
