using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SistemaSolar
    {
        #region Atributos
        private List<Astro> planetas;
        #endregion

        #region Propiedades
        /// <summary>
        /// Retorna los planetas contenidos en el Sistema Solar.
        /// </summary>
        public List<Astro> Planetas
        {
            get { return this.planetas; }
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor Privado que no requiere parametros.
        /// </summary>
        private SistemaSolar() { }
        #endregion

        #region Metodos
        /// <summary>
        /// Muestra toda la informacion de cada planeta y sus satelites, los cuales estan contenidos en el Sistema Solar.
        /// </summary>
        /// <returns></returns>
        public string MostrarInformacionAstros()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Planeta planeta in Planetas)
            {
                sb.AppendLine(planeta.ToString());
            }
            return sb.ToString();
        }
        #endregion
    }
}
