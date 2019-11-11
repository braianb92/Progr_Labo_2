using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio72
{
    public static class MetodosExtension
    {
        public static int CantidadDeDigitos(this long digitos)
        {
            string cadena = digitos.ToString();
            return cadena.Length;
        }
    }
}
