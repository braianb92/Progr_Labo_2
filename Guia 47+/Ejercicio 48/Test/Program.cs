using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instancio Contabilidad
            Contabilidad<Factura, Recibo> contabilidad = new Contabilidad<Factura, Recibo>();

            //Creo Factura
            Factura facturaLuz = new Factura(1500);
            Factura facturaGas = new Factura(2000);
            Factura facturaInternet = new Factura(200);

            //Creo Recibo
            Recibo reciboLuz = new Recibo();
            Recibo reciboGas = new Recibo(2000);
            Recibo reciboInternet = new Recibo(200);

            //Agrego a contabilidad
            contabilidad = contabilidad + facturaLuz;
            contabilidad = contabilidad + facturaGas;
            contabilidad = contabilidad + facturaInternet;

            contabilidad = contabilidad + reciboLuz;
            contabilidad = contabilidad + reciboGas;
            contabilidad = contabilidad + reciboInternet;

            //Muestro Contabilidad
            Console.WriteLine(contabilidad.Egresos);
            Console.WriteLine("");
            Console.WriteLine(contabilidad.Ingresos);

            Console.ReadKey();
        }
    }
}
