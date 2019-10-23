using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public abstract class Equipo
    {
        protected string nombre;
        protected DateTime fechaCreacion;

        public string Nombre
        {
            get { return this.nombre; }
        }

        public DateTime FechaCreacion
        {
            get { return this.fechaCreacion; }
        }

        public Equipo(string nombre,DateTime fecha)
        {
            this.nombre = nombre;
            this.fechaCreacion = fecha;
        }

        public static bool operator == (Equipo e1, Equipo e2)
        {
            if (e1.FechaCreacion == e2.FechaCreacion && e1.Nombre == e2.Nombre)
                return true;
            return false;
        }

        public static bool operator !=(Equipo e1, Equipo e2)
        {
            return !(e1 == e2);
        }

        public string Ficha()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.Nombre} fundado el {this.FechaCreacion}");
            return sb.ToString();
        }
    }
}
