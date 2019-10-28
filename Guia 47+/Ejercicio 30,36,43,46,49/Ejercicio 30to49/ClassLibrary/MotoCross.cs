using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class MotoCross : VehiculoDeCarrera
    {
        private short cilindrada;

        public MotoCross(short numero, string escuderia) : base(numero, escuderia)
        {
            cilindrada = 0;
        }

        public static bool operator == (MotoCross a1, MotoCross a2)
        {
            if (a1.numero == a2.numero && a1.escuderia == a2.escuderia && a1.cilindrada == a2.cilindrada)
                return true;
            return false;
        }

        public static bool operator != (MotoCross a1, MotoCross a2)
        {
            return !(a1 == a2);
        }

        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine($"{this.cilindrada}");
            return sb.ToString();
        }
    }
}
