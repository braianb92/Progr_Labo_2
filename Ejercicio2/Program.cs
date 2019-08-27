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
            //de calse --> estatico / de instancia --> no estatico
            int numero;
            double potenciaCuadrado;
            double potenciaCubo;
            bool flag = false;
            Cuadrado cuadrado = new Cuadrado();
            
            do
            {
                Console.Write("Ingresar Numero mayor a 0:");
                if(cuadrado.Validar(Console.ReadLine(),out numero))
                {
                  cuadrado.PotenciarCuadrado(numero, out potenciaCuadrado);
                  cuadrado.PotenciarCubo(numero, out potenciaCubo);
                  Console.WriteLine("Numero al Cuadrado: "+ potenciaCuadrado +" Numero al cubo: "+ potenciaCubo);
                  Console.ReadKey();
                }
                else
                {
                  Console.WriteLine("ERROR!, Reingrese Numero.");
                  flag = true;
                  
                }
            } while (flag);          
        }
    }
}
