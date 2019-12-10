using System;
using System.Text;
using System.Threading;
using System.Xml.Serialization;

namespace Entidades
{
    [XmlInclude(typeof(Astro))]
    public class Satelite : Astro ,IAstro
    {
        #region Constructores
        public Satelite() { }

        public Satelite(int duraOrbita, int duraRotacion, string nombre)
            : base(duraOrbita, duraRotacion, nombre) { }
        #endregion

        #region Methods
        public string Orbitar()
        {
            return $"Orbitar el satelite: {this.Nombre}";
        }

        public string Rotar()
        {
            return $"Rota el satelite: {this.Nombre}";
        }

        /// <summary>
        /// Devuelve la informacion del Satelite.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Satelite");
            stringBuilder.AppendLine(Mostrar());

            return stringBuilder.ToString();
        }

        public void RunEvntRotar()
        {

            for (int i = 0; i < DuraRotacion; i++)
            {
                Thread.Sleep(800);
            }
            InvocarEvento(this.Rotar());
        }

        public void RunEvntOrb()
        {
            for (int i = 0; i < DuraOrbita; i++)
            {
                Thread.Sleep(400);
            }
            InvocarEvento(this.Orbitar());
        }
        #endregion
    }
}
