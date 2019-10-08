using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public abstract class Producto
    {
        private Guid codigo;
        private string descripcion;
        private double precio;
        private int stock;

        protected Producto(string descripcion,int stock,double precio)
        {
            this.codigo = Guid.NewGuid();
            this.descripcion = descripcion;
            this.precio = precio;
            this.Stock = stock;
        }

        #region Propiedades
        public string Descripcion
        {
            get { return descripcion; }
        }

        public double Precio
        {
            get { return precio; }
        }

        public int Stock
        {
            get { return stock; }
            set
            {
                if (value >= 0)
                    this.stock = value;
            }
        }
        #endregion

        public static explicit operator Guid (Producto p)
        {
            return p.codigo;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Descripcion: {Descripcion}");
            sb.AppendLine($"Codigo: {(Guid)this}");
            sb.AppendLine($"Precio: {Precio}");
            sb.AppendLine($"Stock: {Stock}");

            return sb.ToString();
        }
    }
}
