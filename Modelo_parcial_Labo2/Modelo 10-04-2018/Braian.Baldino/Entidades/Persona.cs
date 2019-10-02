using System;
using System.Text;

namespace Entidades
{
    public abstract class Persona
    {
        private string nombre;
        private int dni;
        private int edad;
        private string apellido;

        public Persona(string nombre,string apellido,int edad,int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.dni = dni;
        }

        public string Nombre
        {
            get { return nombre; }
        }

        public int Edad
        {
            get { return edad; }
        }

        public int Dni
        {
            get { return dni; }
        }

        public string Apellido
        {
            get { return apellido; }
        }

        public abstract bool ValidarAptitud();

        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {Nombre}");
            sb.AppendLine($"Apellido: {Apellido}");
            sb.AppendLine($"Edad: {Edad}");
            sb.AppendLine($"DNI: {Dni}");
            return sb.ToString();
        }


    }
}
