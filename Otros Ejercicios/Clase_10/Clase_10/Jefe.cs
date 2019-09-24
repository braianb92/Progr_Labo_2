using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_10
{
     public class Jefe : Empleado
    {
        private int bono;

        public Jefe(string nombre,int cuil,float sueldo,int bono):base(nombre,cuil,sueldo)
        {
            this.bono = bono;
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Bono: {this.bono}");
            return base.Mostrar() + sb.ToString();
        }

        public override string ToString()
        {
            return Mostrar();
        }
    }
}
