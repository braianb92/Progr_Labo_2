using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Satelite : Astro
    {
        public Satelite(int duraOrbita, int duraRotacion, string nombre)
            : base(duraOrbita,duraRotacion,nombre) {}

        public string Nombre
        {
            get { return this.nombre; }
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        public override string Orbitar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Orbitar el satelite: {this.Nombre}");
            return sb.ToString();
        }
    }
}
