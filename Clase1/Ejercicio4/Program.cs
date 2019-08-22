using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroRecorrido;
            int numeroAnterior;
            int acumulador = 0;

            for (numeroRecorrido = numeroIngresado - 1; numeroRecorrido > 1; numeroRecorrido--)
            {
                for (numeroAnterior = numeroRecorrido - 1; numeroAnterior > 1; numeroAnterior--)
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
    }
}
