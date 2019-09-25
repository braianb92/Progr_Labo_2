using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio38
{
    class Program
    {
        static void Main(string[] args)
        {
            ///EJERCICIO 38 CON CLASE NORMAL
            #region EJ-38
            //Console.Title = "Ejercicio Nº38 Guía 2017";
            //Sobreescrito sobrecarga = new Sobreescrito();
            //Console.WriteLine(sobrecarga.ToString());
            //string objeto = "¡Este es mi método ToString sobreescrito!";
            //Console.WriteLine("----------------------------------------------");
            //Console.Write("Comparación Sobrecargas con String: ");
            //Console.WriteLine(sobrecarga.Equals(objeto));
            //Console.WriteLine("----------------------------------------------");
            //Console.WriteLine(sobrecarga.GetHashCode());
            //Console.ReadKey();
            #endregion

            ///EJERCICIO 39 CON CLASE ABSTRACTA
            #region EJ-39
            Console.Title = "Ejercicio Nº38 Guía 2017";
            Sobreescrito sobreescrito = new SobreSobreescrito();
            Console.WriteLine(sobreescrito.ToString());
            string objeto = "¡Este es mi método ToString sobreescrito!";
            Console.WriteLine("----------------------------------------------");
            Console.Write("Comparación Sobrecargas con String: ");
            Console.WriteLine(sobreescrito.Equals(objeto));
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(sobreescrito.GetHashCode());
            Console.ReadKey();
            #endregion
        }
    }
}
