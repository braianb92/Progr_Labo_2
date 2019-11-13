﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class AutoF1 : VehiculoDeCarrera
    {
       
        private short caballosDeFuerza;

        public AutoF1 (short numero,string escuderia) : base(numero,escuderia)
        {
            caballosDeFuerza = 0;
        }

        public static bool operator == (AutoF1 a1, AutoF1 a2)
        {
            if (a1.numero == a2.numero && a1.escuderia == a2.escuderia && a1.caballosDeFuerza == a2.caballosDeFuerza )
                return true;
            return false;
        }

        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }

        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine($"{this.caballosDeFuerza}");
            return sb.ToString();
        }
    }
}