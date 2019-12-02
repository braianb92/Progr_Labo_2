using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic.Entidades
{
    public static class FormatearPrecio
    {

        public static string FormatPrecio(this double precio)
        {
            return string.Format($"${Math.Round(precio,2,MidpointRounding.ToEven)}");
        }
    }
}
