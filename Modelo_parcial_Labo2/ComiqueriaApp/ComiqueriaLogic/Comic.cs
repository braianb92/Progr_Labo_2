using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public class Comic : Producto
    {
        #region Nested Type
        public enum TipoComic
        {
            Occidental,
            Oriental
        }
        #endregion

        private string autor;
        private TipoComic tipoComic;

        public Comic(string descripcion,int stock,double precio,string autor,TipoComic tipoComic)
            : base(descripcion,stock,precio)
        {
            this.autor = autor;
            this.tipoComic = tipoComic;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Autor: {this.autor}");
            sb.AppendLine($"Autor: {this.tipoComic}");
            sb.AppendLine(base.ToString());

            return sb.ToString();
        }
    }
}
