using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        List<AutoF1> competidores;

        private Competencia()
        {
            competidores = new List<AutoF1>();
        }

        public Competencia(short cantidadCompetidores,short cantidadVueltas):this()
        {
            this.cantidadCompetidores = cantidadCompetidores;
            this.cantidadVueltas = cantidadVueltas;
        }

        public static bool operator + (Competencia c, AutoF1 a)
        {
            if(c.cantidadCompetidores > c.competidores.Count && c!=a)
            {
                Random combustible = new Random();

                a.EnCompetencia = true;
                a.CantidadCombustible = (short)combustible.Next(1, 1000);
                a.VueltasRestantes = c.cantidadVueltas;
                return true;
            }
            return false;
        }

        public static bool operator - (Competencia c, AutoF1 a)
        {
            if(c==a)
            {
                c.competidores.Remove(a);
                return true;
            }
            return false;
        }

        public static bool operator == (Competencia c,AutoF1 a)
        {
            foreach (AutoF1 auto in c.competidores)
            {
                if (auto == a)
                    return true;
            }
            return false;
        }

        public static bool operator !=(Competencia c, AutoF1 a)
        {
            return !(c==a);
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            
            foreach (AutoF1 auto in this.competidores)
            {
                sb.AppendLine(auto.MostrarDatos());
            }
            return sb.ToString();
        }

    }
}
