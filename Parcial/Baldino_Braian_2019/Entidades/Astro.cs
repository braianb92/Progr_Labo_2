using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Astro
    {
        #region Atributos
        private int duracionOrbita;
        private int duracionRotacion;
        protected string nombre;
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor que requiere de tres parametros.
        /// </summary>
        /// <param name="duraOrbita"></param>
        /// <param name="duraRotacion"></param>
        /// <param name="nombre"></param>
        public Astro(int duraOrbita,int duraRotacion,string nombre)
        {
            this.duracionOrbita = duraOrbita;
            this.duracionRotacion = duraRotacion;
            this.nombre = nombre;
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Muestra el nombre, orbita y rotacion del Astro.
        /// </summary>
        /// <returns></returns>
        protected string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Orbita: {this.duracionOrbita}");
            sb.AppendLine($"Rotacion: {this.duracionRotacion}");

            return sb.ToString();
        }

        /// <summary>
        /// Metodo abstracto.
        /// </summary>
        /// <returns></returns>
        public abstract string Orbitar();
        
        /// <summary>
        /// Muestra el tiempo estimado de rotacion del Astro.
        /// </summary>
        /// <returns></returns>
        public virtual string Rotar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Rotando. Tiempo estimado: {this.duracionRotacion}");
            return sb.ToString();
        }
        #endregion

        #region Sobrecargas & Conversiones
        /// <summary>
        /// Devuelve el nombre del astro.
        /// </summary>
        /// <param name="astro"></param>
        public static explicit operator string(Astro astro)
        {
            return astro.nombre;
        }
        #endregion

    }
}
