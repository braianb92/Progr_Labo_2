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
        List<VehiculoDeCarrera> competidores;

        private Competencia()
        {
            competidores = new List<VehiculoDeCarrera>();
        }

        public Competencia(short cantidadCompetidores,short cantidadVueltas):this()
        {
            this.cantidadCompetidores = cantidadCompetidores;
            this.cantidadVueltas = cantidadVueltas;
        }

        public List<VehiculoDeCarrera> Competidores
        {
            get { return this.competidores; }
        }

        public static bool operator + (Competencia c, VehiculoDeCarrera vehiculoDeCarrera)
        {
            if(c.competidores.Count < c.cantidadCompetidores && c!= vehiculoDeCarrera)
            {
                Random combustible = new Random();

                vehiculoDeCarrera.EnCompetencia = true;
                vehiculoDeCarrera.CantidadCombustible = (short)combustible.Next(15, 100);
                vehiculoDeCarrera.VueltasRestantes = c.cantidadVueltas;
                c.competidores.Add(vehiculoDeCarrera);
                return true;
            }
            return false;
        }

        public static bool operator - (Competencia c, VehiculoDeCarrera vehiculoDeCarrera)
        {
            if(c== vehiculoDeCarrera)
            {
                c.competidores.Remove(vehiculoDeCarrera);
                return true;
            }
            return false;
        }

        public static bool operator == (Competencia c, VehiculoDeCarrera vehiculoDeCarrera)
        {
            foreach (VehiculoDeCarrera auto in c.competidores)
            {
                if (auto == vehiculoDeCarrera)
                    return true;
            }
            return false;
        }

        public static bool operator !=(Competencia c, VehiculoDeCarrera vehiculoDeCarrera)
        {
            return !(c== vehiculoDeCarrera);
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Cantidad de Vueltas: {cantidadVueltas}");
            sb.AppendLine($"Cantidad de Vueltas: {cantidadCompetidores}");
            foreach (VehiculoDeCarrera auto in Competidores)
            {
                sb.AppendLine(auto.MostrarDatos());
            }
            return sb.ToString();
        }

    }
}
