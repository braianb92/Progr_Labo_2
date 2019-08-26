using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Por teclado se ingresa el valor hora, el nombre, la antigüedad(en años) y la cantidad de horas
            //trabajadas en el mes de N empleados de una fábrica.

            //Se pide calcular el importe a cobrar teniendo en cuenta que el total(que resulta de multiplicar el
            //valor hora por la cantidad de horas trabajadas), hay que sumarle la cantidad de años trabajados
            //multiplicados por $ 150, y al total de todas esas operaciones restarle el 13 % en concepto de
            //descuentos.
            //Mostrar el recibo correspondiente con el nombre, la antigüedad, el valor hora, el total a cobrar en
            //bruto, el total de descuentos y el valor neto a cobrar de todos los empleados ingresados.
            //Nota: Utilizar estructuras repetitivas y selectivas.

            string continuar;
            string stringValor;
            string stringHoras;
            string stringAntiguedad;
            string nombre;
            double valorHora;
            int horas;
            int antiguedad;
            double totalBruto;
            double totalNeto;
            double descuentos;

            List<Empleado> employeeList = new List<Empleado>();
            do
            {
                Console.WriteLine("Ingrese nombre del Empleado:");
                nombre = Console.ReadLine();

                Console.WriteLine("Ingrese antiguedad del Empleado:");
                stringAntiguedad = Console.ReadLine();

                Console.WriteLine("Ingrese horas trabajadas del Empleado:");
                stringHoras = Console.ReadLine();

                Console.WriteLine("Ingrese VALOR de horas trabajadas:");
                stringValor = Console.ReadLine();

                if (int.TryParse(stringAntiguedad,out antiguedad)
                    && int.TryParse(stringHoras,out horas)
                    && double.TryParse(stringValor,out valorHora))
                {
                    employeeList.Add(new Empleado(nombre, antiguedad, horas, valorHora));
                    
                }
                else
                {
                    Console.WriteLine("Alguno de los datos ingresados no es correcto.");
                }

                Console.WriteLine("Desea agregar otro empleado? - s/n\n");
                continuar = Console.ReadLine().ToLower();

            } while (continuar == "s");

            foreach (var item in employeeList)
            {
                totalBruto = item.calcularHoraxCantidad(item.horasTrabajadas, item.valorHoras);
                totalBruto += item.bonoAñosTrabajados(item.antiguedad, 150);
                descuentos = item.descuentos(totalBruto, 13);
                totalNeto = totalBruto - descuentos;

                Console.WriteLine("*****RECIBO*****");
                Console.WriteLine("Nombre: {0}\nAntiguedad: {1}\nValor hora: {2}\nTotal Bruto: {3}\n"+
                                  "Total Neto: {4}\nTotal Descuentos: {5}.",
                                  item.nombre,item.antiguedad,item.valorHoras,totalBruto,totalNeto,descuentos);
                Console.WriteLine("************");
            }
            Console.ReadKey();
            
        }
    }
}
