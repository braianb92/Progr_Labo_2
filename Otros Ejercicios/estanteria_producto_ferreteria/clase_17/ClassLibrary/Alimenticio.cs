using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Alimenticio : Producto
    {
        private DateTime vencimiento;

        public Alimenticio(int id, string descripcion,DateTime vencimiento):base(id,descripcion)
        {
            this.vencimiento = vencimiento;
        }

        public DateTime Vencimiento
        {
            get { return this.vencimiento; }
            set { this.vencimiento = value; }
        }
    }
}
