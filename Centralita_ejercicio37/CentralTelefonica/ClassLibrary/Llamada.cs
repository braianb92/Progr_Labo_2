using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{

    public class Llamada
    {
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public float Duracion { get { return duracion; } }
        public string NroDestino { get { return nroDestino; } }
        public string NroOrigen { get { return nroOrigen; } }

        public enum TipoLlamada
        {
            Local,
            Provincial,
            Todas
        }   
        

        public Llamada(float duracion,string nroDestino,string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        public static int OrdenarPorDuracion(Llamada llamada1,Llamada llamada2)
        {
            if (llamada1.duracion > llamada2.duracion)
                return 1;
            else if (llamada1.duracion < llamada2.duracion)
                return -1;
            else
                return 0;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Duracion: {this.duracion}");
            sb.AppendLine($"N° Origen: {this.nroDestino}");
            sb.AppendLine($"N° Destino: {this.nroDestino}");
            sb.AppendLine("---------------------");
            return sb.ToString();
        }

    }
}
