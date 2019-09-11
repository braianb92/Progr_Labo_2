using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Pesos
    {
        private double cantidad;
        private static double cotizRespectoDolar;

        private Pesos()
        {
            Pesos.cotizRespectoDolar = 38.33;
        }

        public Pesos(double cantidad):this()
        {
            this.cantidad = cantidad;
        }

        public Pesos(double cantidad, double cotizacion) : this(cantidad)
        {
            Pesos.cotizRespectoDolar = cotizacion;
        }

        public static double GetCotizacion()
        {
            return Pesos.cotizRespectoDolar;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static explicit operator Dolar(Pesos p)
        {
            double cantidadDolar = p.GetCantidad() * Pesos.GetCotizacion();
            return new Dolar(cantidadDolar);
        }

        public static explicit operator Euro(Pesos p)
        {
            Dolar dolares = (Dolar)p;
            double cantidadEuro = dolares.GetCantidad() * Euro.GetCotizacion();
            return new Euro(cantidadEuro);
        }

        public static implicit operator Pesos(double d)
        {
            return new Pesos(d);
        }

        public static bool operator != (Pesos p,Dolar d)
        {
            Dolar pDolar = (Dolar)p;
            if(pDolar.GetCantidad()!=d.GetCantidad())
            {
                return true;
            }
            return false;
        }

        public static bool operator == (Pesos p, Dolar d)
        {
            return !(p != d);
        }

        public static bool operator !=(Pesos p, Euro e)
        {
            Euro pEuro = (Euro)p;
            if (pEuro.GetCantidad() != e.GetCantidad())
            {
                return true;
            }
            return false;
        }

        public static bool operator ==(Pesos p, Euro e)
        {
            return !(p != e);
        }

        public static bool operator !=(Pesos p1, Pesos p2)
        {
            if (p1.cantidad != p2.cantidad)
            {
                return true;
            }
            return false;
        }

        public static bool operator == (Pesos p1, Pesos p2)
        {
            return !(p1 != p2);
        }

        //public static Pesos operator - (Pesos p,Dolar d)
        //{
        //    Dolar dolares = (Dolar)p;
        //    double cantidadEuro = dolares.GetCantidad() * Euro.GetCotizacion();
        //    return new Euro(cantidadEuro);
        //}

    }
}
