using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Jugador : Persona
    {
        private float altura;
        private float peso;
        private Posicion posicion;

        public float Altura
        {
            get { return altura; }
        }

        public float Peso
        {
            get { return peso; }
        }

        public Posicion Posicion
        {
            get { return posicion; }
        }

        public Jugador(string nombre,string apellido,int edad,int dni,float peso,float altura,Posicion posicion) 
            : base(nombre,apellido,edad,dni)
        {
            this.peso = peso;
            this.altura = altura;
            this.posicion = posicion;
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"Peso: {Peso}");
            sb.AppendLine($"Altura: {Altura}");
            sb.AppendLine($"Posicion: {Posicion}");
            return sb.ToString();
        }

        public bool ValidarEstadoFisico()
        {
            double IMC = peso / Math.Pow(Altura,2);

            return (IMC > 18.5 && IMC <= 25) ? true : false;
        }

        public override bool ValidarAptitud()
        {
            return (ValidarEstadoFisico() && Edad < 40) ? true : false ;
        }

    }
}
