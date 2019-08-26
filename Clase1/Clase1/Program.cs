using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Ingresar 5 números por consola, guardándolos en una variable escalar.Luego calcular y mostrar: el
            //valor máximo, el valor mínimo y el promedio.

            string consola;
            int numero;
            int sumatoria = 0 ;
            int maximo=int.MinValue;
            int minimo=int.MaxValue;
            double promedio;
            int i = 0;

            do
            {
                Console.Write("Ingresar Numeroo:");
                consola = Console.ReadLine();
                if (int.TryParse(consola, out numero))
                {
                    if (numero > maximo)
                    {
                        maximo = numero;
                    }
                    else if (numero < minimo)
                    {
                        minimo = numero;
                    }
                    sumatoria += numero;
                    i++;
                }
                

            } while (i < 5);

            promedio = sumatoria / 5;
            Console.Write("El numero maximo ingresado: {0}, Numero minimo ingresado: {1}, Promedio: {2}",maximo,minimo,promedio);
            Console.ReadKey();
        }
    }
}
