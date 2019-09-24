using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_10
{
    public abstract class Persona
    {
        private string nombre;
        private int cuil;


        public string Nombre
        {
            get { return this.nombre; }
        }

        public int Cuil
        {
            get { return this.cuil; }
        }

        public Persona(string nombre,int cuil)
        {
            this.nombre = nombre;
            this.cuil = cuil;
        }

        public abstract string Mostrar();

        public override string ToString()
        {
            return Mostrar();
        }
    }
}
