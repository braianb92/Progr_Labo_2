using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno1 = new Alumno("Juan","Perez",1001);
            Alumno alumno2 = new Alumno("Marta","Fernandez",1002);
            Alumno alumno3 = new Alumno("Pedro","Lopez",1003);

            alumno1.Estudiar(5, 10);
            alumno1.CalcularFinal();

            alumno2.Estudiar(3, 6);
            alumno2.CalcularFinal();

            alumno3.Estudiar(8, 7);
            alumno3.CalcularFinal();

            Console.WriteLine("***LISTADO ALUMNOS***\n\n{0}\n\n{1}\n\n{2}", alumno1.Mostrar(), alumno2.Mostrar(), alumno3.Mostrar());
            Console.ReadKey();
        }
    }
}
