using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public sealed class Venta
    {
        private DateTime fecha;
        private static int porcentajeIva;
        private double precioFinal;
        private Producto producto;

        internal DateTime Fecha
        {
            get { return this.fecha; }
        }

        static Venta()
        {
            Venta.porcentajeIva = 21;
        }
        
        internal Venta(Producto producto, int cantidad)
        {
            this.producto = producto;
            Vender(cantidad);
        }

        private void Vender(int cantidad)
        {
            this.producto.Stock = this.producto.Stock - cantidad;
            this.fecha = DateTime.Now;
            this.precioFinal = CalcularPrecioFinal(this.producto.Precio, cantidad);
        }

        public static double CalcularPrecioFinal(double precioUnidad,int cantidad)
        {
            double porcentaje = ((precioUnidad * cantidad) * Venta.porcentajeIva) / 100;
            return (precioUnidad * cantidad) + porcentaje;
        }

        public string ObtenerDescripcionBreve()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Fecha: {this.Fecha}");
            sb.AppendLine($"Descripcion: {this.producto.Descripcion}");
            sb.AppendLine($"Precio Final: {this.precioFinal}");

            return sb.ToString();
        }


    }
}
