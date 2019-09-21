﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Provincial : Llamada
    {
        protected Franja franjaHoraria;

        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3
        }

        public Provincial(Franja miFranja, Llamada llamada) : base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this.franjaHoraria = miFranja;
        }

        public Provincial(string origen, Franja miFranja, float duracion, string destino) : base(duracion, destino, origen)
        {
            this.franjaHoraria = miFranja;
        }

        public float CostoLlamada()
        {
            return this.CalcularCosto();
        }

        private float CalcularCosto()
        {
            if (this.franjaHoraria == Franja.Franja_1)
                return Duracion * (float)0.99;
            else if (this.franjaHoraria == Franja.Franja_2)
                return Duracion * (float)1.25;
            else
                return Duracion * (float)0.66;
        }

        public new string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Costo Llamada: {CostoLlamada().ToString()}");
            sb.AppendLine($"Franja Horaria: {franjaHoraria.ToString()}");
            sb.AppendLine(base.Mostrar());
            return sb.ToString();
        }
    }
}
