using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Torneo<T> where T : Equipo
    {
        private string nombre;
        List<T> equipos;

        public Torneo(string nombre)
        {
            this.nombre = nombre;
            equipos = new List<T>();
        }

        public static bool operator == (Torneo<T> t,T e)
        {
            foreach (T item in t.equipos)
            {
                if (item == e)
                    return true;
            }
            return false;
        }

        public static bool operator !=(Torneo<T> t, T e)
        {
            return !(t == e);
        }

        public static Torneo<T> operator + (Torneo<T> t,  T e)
        {
            if(t!=e)
            {
                t.equipos.Add(e);
                return t;
            }
            return t;
        }

        private string CalcularPartido(T e1, T e2)
        {
            Random resultado = new Random();
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"[{e1.Nombre}][{resultado.Next(0,5)}] - [{resultado.Next(0,5)}][{e2.Nombre}]");
            return sb.ToString();
        }

        public string JugarPartido()
        {
            Random random = new Random();

            int cantidadEquipos = this.equipos.Count;            
            int equipo1 = random.Next(1, cantidadEquipos);
            int equipo2 = random.Next(1, cantidadEquipos);

            if(cantidadEquipos>=2)
            {
                while (equipo1 == equipo2)
                {
                    equipo1 = random.Next(1, cantidadEquipos);
                }
                return CalcularPartido(this.equipos.ElementAt(equipo1), this.equipos.ElementAt(equipo2));
            }           
            return "El partido no se pudo jugar";
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{this.nombre}");
            foreach (T equipo in this.equipos)
            {
                sb.AppendLine($"{equipo.Ficha()}");
            }
            return sb.ToString();
        }

    }
}
