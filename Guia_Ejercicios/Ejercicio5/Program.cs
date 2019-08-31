using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Un centro numérico es un número que separa una lista de números enteros(comenzando en 1) en
            //dos grupos de números, cuyas sumas son iguales.
            //El primer centro numérico es el 6, el cual separa la lista(1 a 8) en los grupos: (1; 2; 3; 4; 5) y(7; 8)
            //cuyas sumas son ambas iguales a 15.El segundo centro numérico es el 35, el cual separa la lista(1 a
            //49) en los grupos: (1 a 34) y(36 a 49) cuyas sumas son ambas iguales a 595.
            //Se pide elaborar una aplicación que calcule los centros numéricos entre 1 y el número que el
            //usuario ingrese por consola.
            //Nota: Utilizar estructuras repetitivas y selectivas.

            //NO FUNCIONA
            string stringNum;
            int numeroTope;
            int centroNumerico;
            int primerLista;
            int segundaLista;
            int primerRecorrido;
            int segundoRecorrido;

            Console.Write("Centro Numerico - Ingrese numero hasta donde desea calcular: ");
            stringNum = Console.ReadLine();
            if (int.TryParse(stringNum, out numeroTope))
            {
                for (centroNumerico = 1; centroNumerico <= numeroTope; centroNumerico++)
                {
                    primerLista = 0;
                    segundaLista = 0;

                    for (primerRecorrido = 1; primerRecorrido < centroNumerico; primerRecorrido++)
                    {
                        primerLista += primerRecorrido;
                        for (segundoRecorrido = centroNumerico + 1; segundoRecorrido <= numeroTope; segundoRecorrido++)
                        {
                            segundaLista += segundoRecorrido;
                        }
                    }
                    if (primerLista == segundaLista)
                    {
                        Console.WriteLine("El numero " + centroNumerico + " es un Centro Numerico y cada lista suma: " + primerLista);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
