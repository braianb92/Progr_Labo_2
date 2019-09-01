using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    class Alumno
    {
        private byte nota1 { get; set; }
        private byte nota2 { get; set; }
        public float notaFinal { get; set; }
        public string apellido { get; set; }
        public int legajo { get; set; }
        public string nombre { get; set; }

        public Alumno(string nombre,string apellido,int legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }
        public void Estudiar(byte notaUno,byte notaDos)
        {
            this.nota1 = notaUno;
            this.nota2 = notaDos;
        }

        public void CalcularFinal()
        {
            Random notaFinal = new Random();
            if(this.nota1>=4&&this.nota2>=4)
            {
                this.notaFinal = notaFinal.Next();
            }
            else
            {
                this.notaFinal = -1;
            }       
        }

        public string Mostrar()
        {
            string fullName;
            string notas;
            string legajo;
            string notaFinal;

            fullName = this.nombre.ToString() + " " + this.apellido.ToString();
            notas = this.nota1.ToString() + " y " + this.nota2.ToString();
            legajo = this.legajo.ToString();

            if (this.notaFinal != -1)
                notaFinal = this.notaFinal.ToString();
                
            else
                notaFinal = "Alumno desaprobado";

            return fullName + "\n" + notas + "\n" + legajo + "\n" + notaFinal;
        }
    }
}
