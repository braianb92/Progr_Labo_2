using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Planeta pJupiter = new Planeta(100, 500, "Jupiter",2,Tipo.Rocoso);
            Planeta pVenus = new Planeta(5, 300, "Venus");
            Planeta pPluton = new Planeta(1, 1, "Pluton");

            Satelite satelite1 = new Satelite(2, 1, "Luna");
            Satelite satelite2 = new Satelite(5, 4, "Sol");
            Satelite satelite3 = new Satelite(14, 50, "Nave espacial");

            Console.WriteLine("Creacion Jupiter");
            Console.WriteLine(pJupiter.ToString());
            Console.WriteLine("");

            Console.WriteLine("Creacion Venus");
            Console.WriteLine(pVenus.ToString());
            Console.WriteLine("*************");
            Console.WriteLine("");

            Console.WriteLine("Creacion Pluton");
            Console.WriteLine(pVenus.ToString());
            Console.WriteLine("*************");
            Console.WriteLine("");

            Console.WriteLine("Asignacion Satelites a Jupiter");
            Console.WriteLine("");
            if (pJupiter + satelite1)
            {
                Console.WriteLine("Se agrego Luna a Jupiter");
            }
            else
            {
                Console.WriteLine("No se agrego Luna a Jupiter");
            }

            if (pJupiter + satelite2)
            {
                Console.WriteLine("Se agrego Sol a Jupiter");
            }
            else
            {
                Console.WriteLine("No se agrego Sol a Jupiter");
            }

            if (pJupiter + satelite3)
            {
                Console.WriteLine("Se agrego Nave espacial a Jupiter");
            }
            else
            {
                Console.WriteLine("Jupiter no puede agregar Nave espacial porque no hay mas capacidad (2)");
            }

            Console.WriteLine("");
            Console.WriteLine("Asignacion Planeta a Venus");
            Console.WriteLine("");
            if (pVenus + pPluton)
            {
                Console.WriteLine("Se agrego Pluton a Venus");
            }
            else
            {
                Console.WriteLine("No se agrego Pluton a Venus. Pluton es un planeta, no un Satelite.");
            }

            Console.WriteLine("");
            Console.WriteLine("********");
            Console.WriteLine("Vuelvo a mostrar ambos Planetas");
            Console.WriteLine(pVenus.ToString());
            Console.WriteLine("");
            Console.WriteLine(pJupiter.ToString());
            Console.WriteLine("********");
            Console.WriteLine("");

            Console.ReadKey();
        }
    }
}
