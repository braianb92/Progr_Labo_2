using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Ingresar un número y mostrar: el cuadrado y el cubo del mismo.Se debe validar que el número sea
            //mayor que cero, caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!".
            //Nota: Utilizar el método ‘Pow’ de la clase Math para realizar la operación.

            string entrada;
            int numero;
            
            do
            {
                Console.Write("Ingresar Numero mayor a 0:");
                entrada = Console.ReadLine();
                if (int.TryParse(entrada, out numero))
                {
                    if(numero > 0)
                    {
                        Console.WriteLine("Numero al Cuadrado:{0}, Numero al cubo: {1}", Math.Pow(numero, 2), Math.Pow(numero, 3));
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("ERROR!, Reingrese Numero.");
                    }
                }
            } while (numero <= 0);
            
            
        }
    }
}
