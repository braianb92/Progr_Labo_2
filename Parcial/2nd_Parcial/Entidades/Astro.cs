using System;
using System.Text;
using System.Threading;
using System.Xml.Serialization;

namespace Entidades
{
    public abstract class Astro
    { 
        #region Atributes
        protected int duraOrbita;
        protected int duracionRotacion;
        protected string nombre;
        private Thread hiloRotacion;
        private Thread hiloOrbita;
        #endregion

        #region Events
        public event AstroDelegate AstroEvent;
        #endregion

        #region Properties
        public Thread HiloRotacion
        {
            get
            {
                return hiloRotacion;
            }
            set
            {
                hiloRotacion = value;
            }
        }

        public Thread HiloOrbita
        {
            get
            {
                return hiloOrbita;
            }
            set
            {
                hiloOrbita = value;
            }
        }

        public int DuraOrbita
        {
            get
            {
                return duraOrbita;
            }
            set
            {
                duraOrbita = value;
            }
        }

        public int DuraRotacion
        {
            get
            {
                return duracionRotacion;
            }
            set
            {
                duracionRotacion = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }
        #endregion

        #region Constr.
        public Astro() { }
        public Astro(int duraOrbita, int duraRotacion, string nombre)
        {
            this.duraOrbita = duraOrbita;
            this.duracionRotacion = duraRotacion;
            this.nombre = nombre;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Muestra la informacion del Astro. Nombre, Duracion de orbita y rotacion.
        /// </summary>
        /// <returns></returns>
        protected string Mostrar()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine($"Nombre: {nombre}");
            retorno.AppendLine($"Duracion de la orbita: {duraOrbita}");
            retorno.AppendLine($"Duracion de la rotacion: {duracionRotacion}");
            return retorno.ToString();
        }

        public void InvocarEvento(string str)
        {
            AstroEvent(str);
        }
        #endregion
    }
}
