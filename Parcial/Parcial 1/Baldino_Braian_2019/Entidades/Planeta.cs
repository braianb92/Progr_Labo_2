using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Planeta : Astro
    {
        #region Atributos
        private int cantSatelites;
        private Tipo tipo;
        private List<Astro> satelites;
        #endregion

        #region Propiedades
        /// <summary>
        /// Propiedad que retorna la lista de Satelites del planeta.
        /// </summary>
        public List<Astro> Satelites
        {
            get { return this.satelites; }
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor que requiere tres parametros y reutiliza constructor base.
        /// </summary>
        /// <param name="duraOrbita"></param>
        /// <param name="duraRot"></param>
        /// <param name="nombre"></param>
        public Planeta(int duraOrbita, int duraRot, string nombre)
            : base(duraOrbita,duraRot,nombre)
        {
            this.satelites = new List<Astro>();
        }

        /// <summary>
        /// Constructor que requiere de 5 parametros y reutiliza constructor propio.
        /// </summary>
        /// <param name="duraOrbita"></param>
        /// <param name="duraRot"></param>
        /// <param name="nombre"></param>
        /// <param name="cantSatelites"></param>
        /// <param name="tipo"></param>
        public Planeta(int duraOrbita,int duraRot,string nombre,int cantSatelites,Tipo tipo) 
            : this(duraOrbita,duraRot,nombre)
        {
            this.cantSatelites = cantSatelites;
            this.tipo = tipo;
        }
        #endregion

        #region Sobrecargas
        /// <summary>
        /// Agrega un astro dentro de un planeta. Valida que sea un Satelite y la capacidad del planeta.
        /// </summary>
        /// <param name="planeta"></param>
        /// <param name="astro"></param>
        /// <returns></returns>
        public static bool operator + (Planeta planeta, Astro astro)
        {
            if (astro is Satelite && (planeta.Satelites.Count < planeta.cantSatelites))
            {
                planeta.Satelites.Add(astro);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Compara si el satelite existe dentro del planeta.
        /// </summary>
        /// <param name="planeta"></param>
        /// <param name="satelite"></param>
        /// <returns></returns>
        public static bool operator == (Planeta planeta, Satelite satelite)
        {
            foreach (Satelite s in planeta.Satelites)
            {
                if((string)s == (string)satelite)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Compara si el Satelite no existe dentro del planeta.
        /// </summary>
        /// <param name="planeta"></param>
        /// <param name="satelite"></param>
        /// <returns></returns>
        public static bool operator !=(Planeta planeta, Satelite satelite)
        {
            return !(planeta == satelite);
        }

        /// <summary>
        /// Compara si los planetas son iguales mediante sus nombres.
        /// </summary>
        /// <param name="planeta"></param>
        /// <param name="planeta2"></param>
        /// <returns></returns>
        public static bool operator ==(Planeta planeta, Planeta planeta2)
        {
            if ((string)planeta == (string)planeta2)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Compara si los planetas son distintos mediante sus nombres.
        /// </summary>
        /// <param name="planeta"></param>
        /// <param name="planeta2"></param>
        /// <returns></returns>
        public static bool operator !=(Planeta planeta, Planeta planeta2)
        {
            return !(planeta == planeta2);
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Muestra el nombre del planeta que orbita.
        /// </summary>
        /// <returns></returns>
        public override string Orbitar()
        {
            return $"Orbita del Planeta: {this.nombre}";
        }

        /// <summary>
        /// Muestra el planeta que se encuentra rotando y el tiempo estimado de rotacion (clase base).
        /// </summary>
        /// <returns></returns>
        public override string Rotar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Rota el planeta: {this.nombre}");
            sb.AppendLine(base.Rotar());
            return sb.ToString();
        }
        #endregion

        #region Override ToString
        /// <summary>
        /// Muestra toda la informacion del planeta junto con sus respectivos satelites y su informacion.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.Orbitar());
            sb.Append(this.Mostrar());
            sb.AppendLine($"Cantidad de satelites: {this.cantSatelites}");
            sb.AppendLine($"Tipo: {this.tipo}");
            sb.AppendLine($"**Satelites**");
            foreach (Satelite satelite in this.Satelites)
            {
                sb.AppendLine(satelite.ToString());
            }
            sb.AppendLine("");
            return sb.ToString();
        }
        #endregion
    }
}
