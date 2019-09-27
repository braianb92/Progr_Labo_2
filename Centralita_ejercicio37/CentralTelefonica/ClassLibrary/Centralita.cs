using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        public List<Llamada> Llamadas
        {
            get
            {
                return this.listaDeLlamadas;
            }
        }

        public Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa) : this()
        {
            this.razonSocial = nombreEmpresa;
        }

        private void AgregarLlamada(Llamada llamadaNueva)
        {
            this.listaDeLlamadas.Add(llamadaNueva);
        }


        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float acumulador = 0;
            Local local;
            Provincial provincial;

            if (tipo == Llamada.TipoLlamada.Todas)
            {
                foreach (Llamada llamada in Llamadas)
                {
                    if (llamada is Local)
                    {
                        local = (Local)llamada;
                        acumulador += local.CostoLlamada;
                    }
                    else if (llamada is Provincial)
                    {
                        provincial = (Provincial)llamada;
                        acumulador += provincial.CostoLlamada;
                    }
                }
            }
            else if (tipo == Llamada.TipoLlamada.Local)
            {
                foreach (Llamada llamada in Llamadas)
                {
                    if (llamada is Local)
                    {
                        local = (Local)llamada;
                        acumulador += local.CostoLlamada;
                    }
                }
            }
            else if (tipo == Llamada.TipoLlamada.Provincial)
            {
                foreach (Llamada llamada in Llamadas)
                {
                    if (llamada is Provincial)
                    {
                        provincial = (Provincial)llamada;
                        acumulador += provincial.CostoLlamada;
                    }
                }
            }
            return acumulador;
        }

        public float GananciasPorLocal
        {
            get { return CalcularGanancia(Llamada.TipoLlamada.Local); }
        }

        public float GananciasPorProvincial
        {
            get { return CalcularGanancia(Llamada.TipoLlamada.Provincial); }
        }

        public float GananciasPorTotal
        {
            get { return CalcularGanancia(Llamada.TipoLlamada.Todas); }
        }

        public void OrdenarLlamadas()
        {
            Llamadas.Sort(Llamada.OrdenarPorDuracion);
        }

        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Razon Social: {razonSocial}");
            sb.AppendLine($"Ganancias Locales: {GananciasPorLocal.ToString()}");
            sb.AppendLine($"Ganancias Provinciales: {GananciasPorProvincial.ToString()}");
            sb.AppendLine($"Ganancias por llamados Totales: {GananciasPorTotal.ToString()}");
            foreach (Llamada llamada in Llamadas)
            {
                sb.AppendLine($"\n***Detalle Llamada***");
                sb.AppendLine($"{llamada.ToString()}");
            }
            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        public static bool operator ==(Centralita c, Llamada l)
        {
            foreach (Llamada llamada in c.Llamadas)
            {
                if (llamada == l)
                    return true;
            }
            return false;
        }

        public static bool operator !=(Centralita c, Llamada l)
        {
            return !(c == l);
        }

        public static Centralita operator + (Centralita c, Llamada llamadaNueva)
        {
            if(c!=llamadaNueva)
                c.AgregarLlamada(llamadaNueva);
            return c;
        }
    }
}
