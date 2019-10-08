using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Planeta : Astro
    {
        private int cantSatelites;
        private Tipo tipo;
        private List<Astro> satelites;

        public List<Astro> Satelites
        {
            get { return this.satelites; }
        }

        public Planeta(int duraOrbita, int duraRot, string nombre)
            : base(duraOrbita,duraRot,nombre) { }

        public Planeta(int duraOrbita,int duraRot,string nombre,int cantSatelites,Tipo tipo) 
            : this(duraOrbita,duraRot,nombre)
        {
            this.cantSatelites = cantSatelites;
            this.tipo = tipo;
        }

        public static bool operator + (Planeta planeta, Astro astro)
        {
            if (astro is Satelite)
            {
                planeta.Satelites.Add(astro);
                return true;
            }
            return false;
        }

        public static bool operator == (Planeta planeta, Satelite satelite)
        {
            foreach (Planeta p in planeta.Satelites)
            {
                if((string)planeta == (string)satelite)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Planeta planeta, Satelite satelite)
        {
            return !(planeta == satelite);
        }

        public static bool operator ==(Planeta planeta, Planeta planeta2)
        {
            if ((string)planeta == (string)planeta2)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Planeta planeta, Planeta planeta2)
        {
            return !(planeta == planeta2);
        }

        public override string Orbitar()
        {
            return $"Orbita del Planeta: {this.nombre}";
        }

        public override string Rotar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Rotar());
            sb.AppendLine($"Rota el planeta: {this.nombre}");
            return sb.ToString();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.Orbitar());
            sb.AppendLine($"Cantidad de satelites: {this.cantSatelites}");
            sb.AppendLine($"Tipo: {this.tipo}");
            sb.AppendLine($"**Satelites**");
            foreach (Astro astro in this.Satelites)
            {
                sb.AppendLine((string)astro);
            }
            return sb.ToString();
        }
    }
}
