using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atencion_al_Cliente
{
    class Negocio
    {
        private Puesto caja;
        private Queue<Cliente> clientes;
        private string nombre;

        public Cliente Cliente
        {
            get
            {
                return this.clientes.Dequeue();
            }
            set
            {
                this.clientes.Enqueue(value);
            }
        }

        private Negocio()
        {
            this.clientes = new Queue<Cliente>();
            this.caja = Puesto.Caja1;
        }

        public Negocio(string nombre) : this()
        {
            this.nombre = nombre;
        }

        public static bool operator == (Negocio n,Cliente c)
        {
            foreach (Cliente cliente in n.clientes)
            {
                if(cliente==c)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n == c);
        }

        public static bool operator + (Negocio n, Cliente c)
        {
            if(n!=c)
            {
                PuestoAtencion puesto = new PuestoAtencion(n.caja);
                puesto.Atender(c);
                return true;
            }
            return false;        
        }
    }

    
}
