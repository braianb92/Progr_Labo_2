using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    #region Enum
    public enum EPuestoJerarquico
    {
        Administración = 1,
        Gerencia,
        Sistemas,
        Accionista
    }
    #endregion

    public class Empleado
    {
        

        private string nombre;
        private string apellido;
        private string legajo;
        private int salario;
        private EPuestoJerarquico puesto;

        public Empleado(string nombre,string apellido,string legajo,int salario, EPuestoJerarquico puesto)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
            this.salario = salario;
            this.puesto = puesto;
        }

        public static bool operator == (Empleado e1,Empleado e2)
        {
            if(e1.legajo == e2.legajo)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Empleado e1, Empleado e2)
        {
            return !(e1 == e2);
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nombre: "+this.nombre);
            sb.AppendLine("Apellido: " + this.apellido);
            sb.AppendLine("Legajo: " +this.legajo);
            sb.AppendLine("Salario: " + this.salario.ToString());
            sb.AppendLine("Puesto: " + this.puesto.ToString());
            sb.AppendLine("---------------");
            return sb.ToString();
        }

    }
}
