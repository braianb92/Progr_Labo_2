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
            //Fecha de hoy
            DateTime fecha = DateTime.Today;

            // Instancio Estanterias.
            Estanteria<Producto> estProductos = new Estanteria<Producto>(50);
            Estanteria<Alimenticio> estAlimenticio = new Estanteria<Alimenticio>(50);
            Estanteria<Ferreteria> estFerreteria = new Estanteria<Ferreteria>(50);

            //Creo Productos.
            Alimenticio arroz = new Alimenticio(1,"Arroz",new DateTime());
            Alimenticio leche = new Alimenticio(2, "Leche", fecha);
            Alimenticio aceite = new Alimenticio(3, "Aceite", fecha);

            Ferreteria tornillo = new Ferreteria(4,"Tornillo",(float)30.5);
            Ferreteria bulon = new Ferreteria(5, "Bulon", (float)4.5);
            Ferreteria tuerca = new Ferreteria(6, "Tuerca", (float)2.5);

            // Agrego al estante (Ferreteria)
            Console.WriteLine("**Si esta bien, agrega 3 prod. Ferreteria.");
            Console.WriteLine("");
            if (estFerreteria+tornillo)
            {
                Console.WriteLine("Agrege Tornillo a Estante de Ferreteria");
            }
            if (estFerreteria + bulon)
            {
                Console.WriteLine("Agrege bulon a Estante de Ferreteria");
            }
            if (estFerreteria + tuerca)
            {
                Console.WriteLine("Agrege tuerca a Estante de Ferreteria");               
            }
            Console.WriteLine("");

            // Agrego al estante (Alimenticio)
            Console.WriteLine("**Si esta bien, agrega 3 prod. Alimenticio.");
            Console.WriteLine("");
            if (estAlimenticio + arroz)
            {
                Console.WriteLine("Agrege arroz a Estante de Alimenticio");
            }
            if (estAlimenticio + aceite)
            {
                Console.WriteLine("Agrege aceite a Estante de Alimenticio");
            }
            if (estAlimenticio + leche)
            {
                Console.WriteLine("Agrege leche a Estante de Alimenticio");
            }
            Console.WriteLine("");

            // Agrego al estante (General)
            Console.WriteLine("**Si esta bien, agrega 4 prod. Generales.");
            Console.WriteLine("");
            if (estProductos + arroz)
            {
                Console.WriteLine("Agrege arroz a Estante de Productos Generales");
            }
            if (estProductos + bulon)
            {
                Console.WriteLine("Agrege bulon a Estante de Productos Generales");
            }
            if (estProductos + leche)
            {
                Console.WriteLine("Agrege leche a Estante de Productos Generales");
            }
            if (estProductos + tornillo)
            {
                Console.WriteLine("Agrege leche a Estante de Productos Generales");
            }
            Console.WriteLine("");

            //Quito elementos.
            Console.WriteLine("**Si esta bien, QUITO 4 prod. Generales.");
            Console.WriteLine("");
            if (estProductos - arroz)
            {
                Console.WriteLine("Quite arroz a Estante de Productos Generales");
            }
            if (estProductos - bulon)
            {
                Console.WriteLine("Quite bulon a Estante de Productos Generales");
            }
            if (estProductos - leche)
            {
                Console.WriteLine("Quite leche a Estante de Productos Generales");
            }
            if (estProductos - tornillo)
            {
                Console.WriteLine("Quite tornillo a Estante de Productos Generales");
            }

            Console.ReadKey();
        }
    }
}
