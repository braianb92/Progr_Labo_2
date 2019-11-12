using Ejercicio_64.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio_64
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instancio Cajas
            Caja caja1 = new Caja();
            Caja caja2 = new Caja();

            //Instancio Negocio
            Negocio negocio = new Negocio(caja1, caja2);
            negocio.Clientes.Add("Juan");
            negocio.Clientes.Add("Pedro");
            negocio.Clientes.Add("Mabel");
            negocio.Clientes.Add("Monica");
            negocio.Clientes.Add("Federico");
            negocio.Clientes.Add("Lujan");
            negocio.Clientes.Add("Martita");
            negocio.Clientes.Add("Felipe");
            negocio.Clientes.Add("Octavio");
            negocio.Clientes.Add("Agustina");

            //Instancio Threads
            Thread threadAsignacion = new Thread(negocio.AsignarCaja);
            Thread threadCaja1 = new Thread(caja1.AtenderClientes);
            Thread threadCaja2 = new Thread(caja2.AtenderClientes);

            //Asignacion 'Name'
            threadCaja1.Name = "Caja 1";
            threadCaja2.Name = "Caja 2";

            //Iniciar Hilos
            threadAsignacion.Start();
            threadAsignacion.Join();
            threadCaja1.Start();
            threadCaja2.Start();

            Console.ReadKey();
        }
    }
}
