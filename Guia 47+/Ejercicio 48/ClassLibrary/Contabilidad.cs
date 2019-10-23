using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Contabilidad<T, U> where T : Documento where U : Documento, new()
    {
        private List<T> egresos;
        private List<U> ingresos;

        public Contabilidad()
        {
            egresos = new List<T>();
            ingresos = new List<U>();
        }

        public string Egresos
        {
            get
            {
                StringBuilder sb = new StringBuilder();

                sb.AppendLine("**LISTA EGRESOS**");
                foreach (T egreso in this.egresos)
                {
                    sb.AppendLine($"{egreso.Numero}");
                }
                return sb.ToString();
            }
        }

        public string Ingresos
        {
            get
            {
                StringBuilder sb = new StringBuilder();

                sb.AppendLine("**LISTA INGRESOS**");
                foreach (U ingreso in this.ingresos)
                {
                    sb.AppendLine($"{ingreso.Numero}");
                }
                return sb.ToString();
            }
        }

        public static Contabilidad<T,U> operator + (Contabilidad<T, U> c, T egreso)
        {
            foreach (T item in c.egresos)
            {
                if (item == egreso)
                    return c;
            }
            c.egresos.Add(egreso);
            return c;
        }

        public static Contabilidad<T, U> operator +(Contabilidad<T, U> c, U ingreso)
        {
            foreach (U item in c.ingresos)
            {
                if (item == ingreso)
                    return c;
            }
            c.ingresos.Add(ingreso);
            return c;
        }

    }
}
