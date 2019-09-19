using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    class Local : Llamada
    {
        protected float costo;

        public Local(Llamada llamada,float costo)
        {
            this.costo = costo;
        }

        public float CostoLlamada()
        {
            return this.costo;
        }

        private 


    }
}
