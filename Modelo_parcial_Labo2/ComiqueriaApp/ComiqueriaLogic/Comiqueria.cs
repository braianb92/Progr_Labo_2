using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public class Comiqueria
    {
        private List<Producto> productos;
        private List<Venta> ventas;

        public Comiqueria()
        {
            this.productos = new List<Producto>();
            this.ventas = new List<Venta>();
        }

        public Producto this [Guid codigo]
        {
            get
            {
                foreach (Producto producto in this.productos)
                {
                    if ((Guid)producto == codigo)
                        return producto;
                }
                return null;
            }
        }


        public Dictionary<Guid,string> ListarProductos()
        {
            Dictionary<Guid, string> dictionary = new Dictionary<Guid, string>();

            foreach (Producto producto in this.productos)
            {
                dictionary.Add((Guid)producto,producto.Descripcion);
            }

            return dictionary;
        }

        private int VentaMasReciente(Venta v1, Venta v2)
        {
            if (v1.Fecha.Date == v2.Fecha.Date)
                return 0;
            else if (v1.Fecha.Date > v2.Fecha.Date)
                return 1;
            else
                return -1;
        }

        public string ListarVentas()
        {
            StringBuilder sb = new StringBuilder();

            this.ventas.Sort(VentaMasReciente);

            foreach (Venta venta in this.ventas)
            {
                sb.AppendLine(venta.ObtenerDescripcionBreve());
            }

            return sb.ToString();
        }

        public static bool operator == (Comiqueria c,Producto p)
        {
            foreach (Producto producto in c.productos)
            {
                if (producto.Descripcion == p.Descripcion)
                    return true;
            }
            return false;
        }

        public static bool operator !=(Comiqueria c, Producto p)
        {
            return !(c == p);
        }

        public static Comiqueria operator + (Comiqueria c, Producto p)
        {
            if (c != p)
                c.productos.Add(p);
            return c;
        }

        public void Vender(Producto producto)
        {
            Vender(producto, 1);
        }

        public void Vender(Producto producto,int cantidad)
        {
            this.ventas.Add(new Venta(producto, cantidad));
        }

    }
}
