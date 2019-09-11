using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Euro
    {
        private double cantidad;
        private static double cotizRespectoDolar;

        private Euro()
        {
            Euro.cotizRespectoDolar = 1.16;
        }

        public Euro(double cantidad):this()
        {
            this.cantidad = cantidad;
        }

        public Euro(double cantidad, double cotizacion) : this(cantidad)
        {
            Euro.cotizRespectoDolar = cotizacion;
        }

        public static double GetCotizacion()
        {
            return Euro.cotizRespectoDolar;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        #region Operator Overloads
        public static explicit operator Dolar(Euro e)
        {
            double dolares = e.GetCantidad() * Euro.GetCotizacion();
            return new Dolar(dolares);
        }

        public static explicit operator Pesos(Euro e)
        {
            double pesos = e.GetCantidad() * Euro.GetCotizacion();
            return new Pesos(pesos);
        }

        public static implicit operator Dolar(double d)
        {
            return new Dolar(d);
        }

        public static bool operator !=(Dolar d, Euro e)
        {
            Euro dEuro = (Euro)d;
            if (dEuro.GetCantidad() != e.GetCantidad())
            {
                return true;
            }
            return false;
        }

        public static bool operator ==(Dolar d, Euro e)
        {
            return !(d != e);
        }

        public static bool operator !=(Dolar d, Pesos p)
        {
            Pesos dPesos = (Pesos)d;
            if (dPesos.GetCantidad() != d.GetCantidad())
            {
                return true;
            }
            return false;
        }

        public static bool operator ==(Dolar d, Pesos p)
        {
            return !(d != p);
        }

        public static bool operator !=(Dolar d1, Dolar d2)
        {
            if (d1.cantidad != d2.cantidad)
            {
                return true;
            }
            return false;
        }

        public static bool operator ==(Dolar d1, Dolar d2)
        {
            return !(d1 != d2);
        }
        #endregion
    }
}
