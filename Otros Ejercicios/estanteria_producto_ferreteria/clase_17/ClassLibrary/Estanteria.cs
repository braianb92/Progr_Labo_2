using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Estanteria<T> where T : Producto
    {
        private int tamaño { get; set; }
        private T[] productos { get; set; }

        public Estanteria(int tamaño)
        {
            this.Tamaño = tamaño;
            this.productos = new T[this.Tamaño];
        }

        public int Tamaño
        {
            get { return this.tamaño; }
            set { this.tamaño = value; }
        }

        public T[] Productos
        {
            get { return this.productos; }
        }

        public static bool operator + (Estanteria<T> e,T t)
        {
            if(e!=t)
            {
                for (int i = 0; i < e.productos.Length; i++)
                {
                    if (e.productos[i] == null)
                    {
                        e.productos[i] = t;
                        return true;
                    }
                }   
            }
            return false;
        }

        public static bool operator - (Estanteria<T> e,T t)
        {
            if(e==t)
            {
                for (int i = 0; i < e.productos.Length; i++)
                {
                    if (!(e.productos[i] is null) && e.productos[i].Id_Prod == t.Id_Prod)
                    {
                        e.productos[i] = null;
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool operator == (Estanteria<T> e, T t)
        {
            foreach (T producto in e.Productos)
            {
                if (!(producto is null) && producto.Id_Prod == t.Id_Prod)
                    return true;
            }
            return false;
        }

        public static bool operator !=(Estanteria<T> e, T t)
        {
            return !(e == t);
        }
    }
}
