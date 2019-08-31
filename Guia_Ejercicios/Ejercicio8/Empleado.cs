using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    class Empleado
    {
        //Properties
        public string nombre { get; set; }
        public int antiguedad { get; set; }
        public double horasTrabajadas { get; set; }
        public double valorHoras { get; set; }

        //Default Constructor
        public Empleado()
        {

        }

        //Overload Constructor
        public Empleado(string nombreParam, int antiguedadParam,double horasParam,double valorHorasParam)
        {
            nombre = nombreParam;
            antiguedad = antiguedadParam;
            horasTrabajadas = horasParam;
            valorHoras = valorHorasParam;
        }

        public double calcularHoraxCantidad(double horas,double valor)
        {
            return horas * valor;
        }

        //cantidad de años trabajados(antiguedad), multiplicados por $ 150(valorBono)
        public int bonoAñosTrabajados(int antiguedad, int valorBono)
        {
            return antiguedad * valorBono;
        }

        public double descuentos(double monto,int porcentajeDescuento)
        {
            return  (porcentajeDescuento * monto) / 100;
        }

    }
}
