using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper
{
    class Ejemplo_Clase_SobrecargaCasteo
    {
        //public class Dolar
        //{
        //    private double cantidad;
        //    private static double cotizRespectoDolar;

        //    #region Constructors
        //    private Dolar()
        //    {
        //        Dolar.cotizRespectoDolar = 1;
        //    }

        //    public Dolar(double cantidad) : this()
        //    {
        //        this.cantidad = cantidad;
        //    }

        //    public Dolar(double cantidad, double cotizacion) : this(cantidad)
        //    {
        //        Dolar.cotizRespectoDolar = cotizacion;
        //    }

        //    #endregion

        //    #region Methods
        //    public static double GetCotizacion()
        //    {
        //        return Dolar.cotizRespectoDolar;
        //    }

        //    public double GetCantidad()
        //    {
        //        return this.cantidad;
        //    }
        //    #endregion

        //    #region Operator Overloads
        //    public static explicit operator Euro(Dolar d)
        //    {
        //        double euros = d.GetCantidad() * Dolar.GetCotizacion();
        //        return new Euro(euros);
        //    }

        //    public static explicit operator Pesos(Dolar d)
        //    {
        //        double pesos = d.GetCantidad() * Pesos.GetCotizacion();
        //        return new Pesos(pesos);
        //    }

        //    public static implicit operator Dolar(double d)
        //    {
        //        return new Dolar(d);
        //    }

        //    public static bool operator !=(Dolar d, Euro e)
        //    {
        //        Euro dEuro = (Euro)d;
        //        if (dEuro.GetCantidad() != e.GetCantidad())
        //        {
        //            return true;
        //        }
        //        return false;
        //    }

        //    public static bool operator ==(Dolar d, Euro e)
        //    {
        //        return !(d != e);
        //    }

        //    public static bool operator !=(Dolar d, Pesos p)
        //    {
        //        Pesos dPesos = (Pesos)d;
        //        if (dPesos.GetCantidad() != d.GetCantidad())
        //        {
        //            return true;
        //        }
        //        return false;
        //    }

        //    public static bool operator ==(Dolar d, Pesos p)
        //    {
        //        return !(d != p);
        //    }

        //    public static bool operator !=(Dolar d1, Dolar d2)
        //    {
        //        if (d1.cantidad != d2.cantidad)
        //        {
        //            return true;
        //        }
        //        return false;
        //    }

        //    public static bool operator ==(Dolar d1, Dolar d2)
        //    {
        //        return !(d1 != d2);
        //    }
        //    #endregion

        //}
    }
}
