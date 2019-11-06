using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    //Delegate
    public delegate void DelegadoString(string msg);
    

    public class Persona
    {
        //Atributes
        private string nombre;
        private string apellido;

        //Event
        public event DelegadoString EventoString;

        //Properties
        public string Nombre
        {
            get { return this.nombre; }
            set { nombre = value; }
        }
        public string Apellido
        {
            get { return this.apellido; }
            set {
                this.EventoString("Cambio!");
                apellido = value; }
        }

        //Constructor
        public Persona()
        {
            nombre = string.Empty;
            apellido = string.Empty;
        }

        //Methods
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Nombre} {Apellido}");
            return sb.ToString();
        }
    }
}
