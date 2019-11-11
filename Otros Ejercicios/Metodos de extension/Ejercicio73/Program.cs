using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio73
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese una palabra con . / , / ;      ");
            string cadena = Console.ReadLine();
            Console.Write($"Contiene {cadena.CantidadSignosDePuntuacion()} Signos de puntuacion. La palabra es -->  {cadena}");
            Console.ReadKey();
        }
    }
}
