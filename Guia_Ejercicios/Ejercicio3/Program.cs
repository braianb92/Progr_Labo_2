using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario
            //por consola.
            //Nota: Utilizar estructuras repetitivas, selectivas y la función módulo(%).

            string consola;
            int numeroIngresado;
            int numeroAnterior;
            int numeroRecorrido;

            Console.Write("Ingrese numero:");
            consola = Console.ReadLine();
            if (int.TryParse(consola,out numeroIngresado))
            {
                for(numeroRecorrido = numeroIngresado-1; numeroRecorrido > 1; numeroRecorrido--)
                {
                    for(numeroAnterior = numeroRecorrido - 1; numeroAnterior > 1; numeroAnterior--)
                    {
                        if (numeroRecorrido % numeroAnterior == 0)
                        {
                            break;
                        }

                    }
                    if (numeroAnterior == 1)
                    {
                        Console.WriteLine("El numero {0} es primo.", numeroRecorrido);
                    }

                }
            }
            Console.ReadKey();
            
        }
    }
}
