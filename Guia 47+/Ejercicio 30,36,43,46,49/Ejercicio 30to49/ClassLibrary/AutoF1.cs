using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class AutoF1
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        public AutoF1 (short numero,string escuderia)
        {
            cantidadCombustible = 0;
            enCompetencia = false;
            this.escuderia = escuderia;
            this.numero = numero;
            vueltasRestantes = 0;
        }

        public short CantidadCombustible
        {
            get { return this.cantidadCombustible; }
            set { this.cantidadCombustible = value; }
        }

        public short VueltasRestantes
        {
            get { return this.vueltasRestantes; }
            set { this.vueltasRestantes = value; }
        }

        public bool EnCompetencia
        {
            get { return this.enCompetencia; }
            set { this.enCompetencia = value; }
        }

        public static bool operator == (AutoF1 a1, AutoF1 a2)
        {
            if (a1.numero == a2.numero && a1.escuderia == a2.escuderia)
                return true;
            return false;
        }

        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{escuderia}");
            sb.AppendLine($"{numero}");
            sb.AppendLine($"{this.EnCompetencia}");
            sb.AppendLine($"{this.CantidadCombustible}");
            sb.AppendLine($"{this.VueltasRestantes}");
            return sb.ToString();
        }
    }
}
