using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{

    public abstract class Llamada
    {
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public float Duracion { get { return duracion; } }
        public string NroDestino { get { return nroDestino; } }
        public string NroOrigen { get { return nroOrigen; } }
        public abstract float CostoLlamada { get; }

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

         protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Duracion: {Duracion}");
            sb.AppendLine($"N° Origen: {NroOrigen}");
            sb.AppendLine($"N° Destino: {NroDestino}");
            sb.AppendLine("---------------------");
            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }


        public static bool operator == (Llamada l1,Llamada l2)
        {
            if(l1.NroOrigen == l2.NroOrigen && l1.NroDestino == l2.NroDestino && l1.Equals(l2))
                return true;
            return false;
        }

        public static bool operator !=(Llamada l1, Llamada l2)
        {
            return !(l1 == l2);
        }


    }
}
