using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;

        public Producto(string marca,string codigo,float precio)
        {
            this.marca = marca;
            this.codigoDeBarra = codigo;
            this.precio = precio;
        }

        public string GetMarca()
        {
            return this.marca;
        }
        
        public float GetPrecio()
        {
            return this.precio;
        }

        public static string MostrarProducto(Producto producto)
        {
            return string.Format("Marca: {0}\nPrecio: {1}\nCodigo: {2}\n", producto.marca, producto.precio, producto.codigoDeBarra);
        }

        public static explicit operator string (Producto p)
        {
            return p.codigoDeBarra;
        }

        public static bool operator == (Producto p1,Producto p2)
        {
            if(!(p1 is null) && !(p2 is null))
            {
                if (p1.marca == p2.marca && p1.codigoDeBarra == p2.codigoDeBarra)
                    return true;
            }

            return false;            
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            if (p1.marca != p2.marca || p1.codigoDeBarra != p2.codigoDeBarra)
            {
                return true;
            }
            return false;
        }

        public static bool operator == (Producto p1, string marca)
        {
            if (p1.marca == marca)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Producto p1, string marca)
        {
            if (p1.marca != marca)
            {
                return true;
            }
            return false;
        }
    }
}
