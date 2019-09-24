using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_10
{
     public class Empleado : Persona
    {
        private float sueldo;

        public Empleado(string nombre,int cuil, float sueldo) : base(nombre,cuil)
        {
            this.sueldo = sueldo;
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {base.Nombre}");
            sb.AppendLine($"Cuil: {base.Cuil}");
            sb.AppendLine($"Sueldo: {this.sueldo}");
            return sb.ToString();
        }

        public override string ToString()
        {
            return Mostrar();
        }
    }
}
