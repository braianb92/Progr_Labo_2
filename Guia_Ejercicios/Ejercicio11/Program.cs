using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int numero;
            int acumulador = 0;
            int max = int.MinValue;
            int min = int.MaxValue;
            do
            {
                Console.Write("Ingrese {0}° Numero: ", i+1);
                if(int.TryParse(Console.ReadLine(),out numero)&&Validacion.Validar(numero,-100,100))
                {
                    if (numero > max)
                    {
                        max = numero;
                    }
                    else if (numero < min)
                    {
                        min = numero;
                    }
                    acumulador += numero;
                    i++;
                }
                else
                    Console.WriteLine("Error, reingrese numero.");

            } while (i<10);

            Console.WriteLine("Valor maximo ingresado: "+max+"\nValor minimo ingresado: "+min+"\nPromedio: "+acumulador/i);
            Console.ReadKey();
        }
    }
}
