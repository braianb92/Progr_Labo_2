using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_10
{
    public class Vendedor : Empleado
    {
        private int objetivo;

        public Vendedor(string nombre,int cuil,float sueldo,int objetivo) : base(nombre,cuil,sueldo)
        {
            this.objetivo = objetivo;
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Objetivo: {this.objetivo}");
            return base.Mostrar() + sb.ToString();
        }

        public override string ToString()
        {
            return Mostrar();
        }
    }
}
