using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio72
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un Numero: ");
            string numeroStr = Console.ReadLine();
            long.TryParse(numeroStr, out long numero);
            Console.WriteLine($"Numero de {numero.CantidadDeDigitos()} digitos");

            Console.Write("Ingrese un Numero: ");
            numeroStr = Console.ReadLine();
            long.TryParse(numeroStr, out long numero2);
            Console.WriteLine($"Numero de {numero2.CantidadDeDigitos()} digitos");

            Console.ReadKey();

        }
    }
}
