using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    class Estante
    {
        private Producto[] productos;
        private int ubicacionEstante;

        public Estante(int capacidad,int ubicacion):this(capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }

        private Estante(int capacidad)
        {
            this.productos = new Producto[capacidad];
        }

        public Producto[] GetProductos()
        {
            return this.productos;
        }

        public static string MostrarEstante(Estante estante)
        {
            string cadena = "";
            foreach (var producto in estante.productos)
            {
                cadena += Producto.MostrarProducto(producto)+"\n\n";
            }

            return cadena;
        }

        //retornará true, si es que el producto ya se encuentra en el estante, false, caso contrario.
        public static bool operator ==(Estante e, Producto p)
        {
            foreach (var producto in e.productos)
            {
                if ((producto == p))
                    return true;
            }

            return false;
        }

        //retornará true, si es que el producto no se encuentra en el estante, false, caso contrario.
        public static bool operator !=(Estante e, Producto p)
        {
            return !(e == p);  
        }

        //Adición, retornará true y agregará el producto si el estante posee capacidad de almacenar 
        //al menos un producto más y dicho producto no se encuentra en él; false, caso contrario.
        public static bool operator +(Estante e, Producto p)
        {
            int i = 0;
            if (e != p)
            {
                foreach (Producto producto in e.productos)
                {
                    if (Object.ReferenceEquals(producto,null))
                    {
                        e.productos[i] = p;
                        return true;
                    }
                    i++;
                }  
            }
            return false;
        }

        //Sustracción(Estante, Producto), retornará un estante sin el producto,
        //siempre y cuando el producto se encuentre en el listado
        public static Estante operator -(Estante e, Producto p)
        {
            int i = 0;
            if (e == p)
            {
                foreach (Producto producto in e.productos)
                {
                    if (Object.ReferenceEquals(producto, p))
                    {
                        e.productos[i] = null;
                        return e;
                    }
                    i++;
                }
            }
            return e;
        }
    }
}
