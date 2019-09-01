using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoligrafoSpace;

namespace Ejercicio17
{
    class Program
    {
        static void Main(string[] args)
        {
            Boligrafo boligrafoAzul = new Boligrafo(100, ConsoleColor.Blue);
            Boligrafo boligrafoRojo = new Boligrafo(50, ConsoleColor.Red);

            if(boligrafoAzul.Pintar(5, out string gastoAzul))
            {
                Console.ForegroundColor = boligrafoAzul.color;
                Console.WriteLine("Gasto de tinta--> " + gastoAzul);
            }                
            else
                Console.WriteLine("No se pudo pintar con azul");

            if (boligrafoRojo.Pintar(10, out string gastoRojo))
            {
                Console.ForegroundColor = boligrafoRojo.color;
                Console.WriteLine("Gasto de tinta--> " + gastoRojo);
            }
            else
                Console.WriteLine("No se pudo pintar con rojo");

            Console.ReadKey();
        }
    }
}
