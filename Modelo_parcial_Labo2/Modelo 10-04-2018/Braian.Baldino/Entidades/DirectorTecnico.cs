using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class DirectorTecnico : Persona
    {
        private int añosExperiencia;

        public DirectorTecnico(string nombre,string apellido,int edad,int dni,int añosExperiencia) : base(nombre,apellido,edad,dni)
        {
            AñosExperiencia = añosExperiencia;
        }

        public int AñosExperiencia
        {
            get { return añosExperiencia; }

            set { this.añosExperiencia = value; }
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"Años de Experiencia: {AñosExperiencia}");
            return sb.ToString();
        }

        public override bool ValidarAptitud()
        {
            return (this.Edad < 65 && this.AñosExperiencia >= 2) ? true : false;
        }

        public bool ValidarDirector()
        {
            if (this.Nombre != "" && this.Apellido != "" && this.Edad > 0 && this.Dni > 0)
                return true;
            else
                return false;

        }
    }
}
