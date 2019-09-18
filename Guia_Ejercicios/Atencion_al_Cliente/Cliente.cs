using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atencion_al_Cliente
{
    class Cliente
    {
        private string nombre { get; set; }
        private int numero { get; }

        public Cliente(int numero)
        {
            this.numero = numero;
        }

        public Cliente(int numero,string nombre) : this(numero)
        {
            this.nombre = nombre;
        }

        public static bool operator == (Cliente c1,Cliente c2)
        {
            if (c1.numero == c2.numero)
                return true;
            else
                return false;
        }

        public static bool operator !=(Cliente c1, Cliente c2)
        {
            return !(c1 == c2);
        }
    }
}
