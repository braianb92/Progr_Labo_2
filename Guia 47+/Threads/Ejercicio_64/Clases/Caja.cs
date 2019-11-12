using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio_64.Clases
{
    public class Caja
    {
        private List<string> filaClientes;

        public List<string> FilaClientes
        {
            get { return this.filaClientes; }
        }

        public Caja()
        {
            this.filaClientes = new List<string>();
        }

        public void AtenderClientes()
        {
            foreach (string cliente in FilaClientes)
            {
                Thread.Sleep(1000);
                Console.WriteLine($"Atendiendo a {cliente} por {Thread.CurrentThread.Name}");
            }
        }
    }
}
