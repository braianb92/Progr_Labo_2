using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio_64.Clases
{
    public class Negocio
    {
        private Caja caja1;
        private Caja caja2;
        private List<string> clientes;

        public Caja Caja1
        {
            get { return this.caja1; }
        }

        public Caja Caja2
        {
            get { return this.caja2; }
        }

        public List<string> Clientes
        {
            get { return this.clientes; }
            set { this.clientes = value; }
        }

        public Negocio(Caja c1, Caja c2)
        {
            this.clientes = new List<string>();
            this.caja1 = c1;
            this.caja2 = c2;
        }

        public void AsignarCaja()
        {
            Console.WriteLine("Asignando Cajas...");
            foreach (string cliente in Clientes)
            {
                Thread.Sleep(1000);
                if (Caja1.FilaClientes.Count < Caja2.FilaClientes.Count)
                {
                    Caja1.FilaClientes.Add(cliente);
                    Console.WriteLine($"{cliente} por Caja 1");
                }
                    
                else
                {
                    Caja2.FilaClientes.Add(cliente);
                    Console.WriteLine($"{cliente} por Caja 2");
                }
                    
            }
        }
    }
}
