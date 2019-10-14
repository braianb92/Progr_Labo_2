using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Satelite : Astro
    {
        #region Constructores
        /// <summary>
        /// Constructor que requiere de tres parametros y reutiliza constructor base.
        /// </summary>
        /// <param name="duraOrbita"></param>
        /// <param name="duraRotacion"></param>
        /// <param name="nombre"></param>
        public Satelite(int duraOrbita, int duraRotacion, string nombre)
            : base(duraOrbita,duraRotacion,nombre) {}
        #endregion

        #region Propiedades
        /// <summary>
        /// Retorna el nombre del satelite.
        /// </summary>
        public string Nombre
        {
            get { return this.nombre; }
        }
        #endregion

        #region Override ToString
        /// <summary>
        /// Muestra toda la informacion del satelite.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Mostrar();
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Muestra el satelite que orbita.
        /// </summary>
        /// <returns></returns>
        public override string Orbitar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Orbitar el satelite: {this.Nombre}");
            return sb.ToString();
        }
        #endregion
    }
}
