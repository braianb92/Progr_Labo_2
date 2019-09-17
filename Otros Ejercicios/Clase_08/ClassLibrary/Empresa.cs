using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Empresa
    {
        private List<Empleado> nominaEmpleados { get; set; }
        private string razonSocial { get; set; }
        private string direccion { get; set; }
        private float ganancias { get; set; }

        private Empresa()
        {
            this.nominaEmpleados = new List<Empleado>();
        }

        public Empresa(string razonSocial,string direccion,float ganancias) : this()
        {
            this.razonSocial = razonSocial;
            this.direccion = direccion;
            this.ganancias = ganancias;
        }

        public static Empresa operator + (Empleado e, Empresa c)
        {
            foreach (Empleado empleado in c.nominaEmpleados)
            {
                if(empleado==e)
                {
                    return c;
                }
            }
            c.nominaEmpleados.Add(e);
            return c;
        }

        public string MostrarEmpresa()
        {
            string strEmpleado = "";
            StringBuilder strEmpresa = new StringBuilder();
            strEmpresa.AppendLine($" La empresa {this.razonSocial} sita en la calle {this.direccion} ,cuenta con ganancias por {this.ganancias} y con {this.nominaEmpleados.Count()} empleados:");
            foreach (Empleado empleado in this.nominaEmpleados)
            {
                strEmpleado += empleado.Mostrar();
            }
            return strEmpresa.ToString()+"\n"+strEmpleado;
        }
    }
}
