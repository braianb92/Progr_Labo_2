using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Partiendo de la base del ejercicio anterior, se pide realizar un programa que imprima por pantalla
            //una pirámide

            //FALTA EL DISEÑO (espacios)

            int altura;
            string stringNumero;
            string character = "\t*";

            Console.Write("Indique altura de piramide:");
            stringNumero = Console.ReadLine();

            if(int.TryParse(stringNumero,out altura)&&altura>0)
            {
                for (int i = 0; i < altura; i++)
                {
                    Console.WriteLine(character);
                    character += "**";
                }
            }
            else
            {
                Console.WriteLine("El numero ingresado no es entero positivo");
            }
            Console.ReadKey();     
        }
    }
}
