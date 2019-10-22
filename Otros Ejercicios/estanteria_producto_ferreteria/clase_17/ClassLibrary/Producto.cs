using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public abstract class Producto
    {
        private int id_prod;
        private string descripcion;

        public Producto(int id, string descripcion)
        {
            this.id_prod = id;
            this.descripcion = descripcion;
        }

        public int Id_Prod
        {
            get { return this.id_prod; }
            set { this.id_prod = value; }
        }

        public string Descripcion
        {
            get { return this.descripcion; }
            set { this.descripcion = value; }
        }
    }
}
