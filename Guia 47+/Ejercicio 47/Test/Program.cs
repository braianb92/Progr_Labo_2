using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instacio Torneo
            Torneo<Equipo> torneoFutbol = new Torneo<Equipo>("Torneo de Futbol");
            Torneo<Equipo> torneoBasquet = new Torneo<Equipo>("Torneo de Basket");

            //Instancio Equipos de Futbol
            EquipoFutbol equipoFut1 = new EquipoFutbol("Boca", new DateTime());
            EquipoFutbol equipoFut2 = new EquipoFutbol("River", new DateTime());
            EquipoFutbol equipoFut3 = new EquipoFutbol("Racing", new DateTime());

            //Instancio Equipos de Basket
            EquipoBasquet equipoBas1 = new EquipoBasquet("Spurs", new DateTime());
            EquipoBasquet equipoBas2 = new EquipoBasquet("Lakers", new DateTime());
            EquipoBasquet equipoBas3 = new EquipoBasquet("Bulls", new DateTime());

            //Agrego Equipos al Torneo
            torneoFutbol = torneoFutbol + equipoFut1;
            torneoFutbol = torneoFutbol + equipoFut2;
            torneoFutbol = torneoFutbol + equipoFut3;

            torneoBasquet = torneoBasquet + equipoBas1;
            torneoBasquet = torneoBasquet + equipoBas2;
            torneoBasquet = torneoBasquet + equipoBas3;

            //Muestro Torneos
            Console.WriteLine(torneoFutbol.Mostrar());
            Console.WriteLine("");
            Console.WriteLine(torneoBasquet.Mostrar());

            //Partidos Futbol
            Console.WriteLine("");
            Console.WriteLine("**PARTIDO 1**");
            Console.WriteLine(torneoFutbol.JugarPartido());
            Console.WriteLine("");
            Console.WriteLine("**PARTIDO 2**");
            Console.WriteLine(torneoFutbol.JugarPartido());
            Console.WriteLine("");
            Console.WriteLine("**PARTIDO 3**");
            Console.WriteLine(torneoFutbol.JugarPartido());
            Console.WriteLine("");

            //Partidos Basket
            Console.WriteLine("");
            Console.WriteLine("**PARTIDO 1**");
            Console.WriteLine(torneoBasquet.JugarPartido());
            Console.WriteLine("");
            Console.WriteLine("**PARTIDO 2**");
            Console.WriteLine(torneoBasquet.JugarPartido());
            Console.WriteLine("");
            Console.WriteLine("**PARTIDO 3**");
            Console.WriteLine(torneoBasquet.JugarPartido());
            Console.WriteLine("");

            Console.ReadKey();
        }
    }
}
