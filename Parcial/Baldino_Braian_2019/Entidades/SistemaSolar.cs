using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class SistemaSolar
    {
        private List<Astro> planetas;

        public List<Astro> Planetas
        {
            get { return this.planetas; }
        }

        private SistemaSolar()
        {

        }

        public string MostrarInformacionAstros()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Planeta planeta in Planetas)
            {
                sb.AppendLine(planeta.ToString());
            }
            return sb.ToString();
        }
    }
}
