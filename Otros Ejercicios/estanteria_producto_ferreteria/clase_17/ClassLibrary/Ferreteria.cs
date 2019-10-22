using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Ferreteria : Producto
    {
        private float peso;

        public Ferreteria(int id, string descripcion, float peso) : base(id, descripcion)
        {
            this.peso = peso;
        }

        public float Peso
        {
            get { return this.peso; }
            set { this.peso = value; }
        }
    }
}
