using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
     public class Local : Llamada
    {
        protected float costo;

        public Local(Llamada llamada,float costo) : base (llamada.Duracion,llamada.NroDestino,llamada.NroOrigen)
        {
            this.costo = costo;
        }

        public Local(string origen,float duracion,string destino,float costo) : base(duracion,destino,origen)
        {
            this.costo = costo;
        }

        public override float CostoLlamada
        {
            get { return this.CalcularCosto(); }
        }

        private float CalcularCosto()
        {
            return this.costo * this.duracion;
        }

        public new string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Costo Llamada: {CostoLlamada}");
            sb.AppendLine(base.Mostrar());
            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            if(this.GetType() == obj.GetType())
                return true;
            return false;
        }

    }
}
