using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio73
{
    public static class MetodoExtension
    {
        public static int CantidadSignosDePuntuacion(this string cadena)
        {
            int contadorSigno = 0;
            for (int i = 0; i < cadena.Length; i++)
            {
                if (cadena[i] == '.')
                    contadorSigno++;
                else if (cadena[i] == ',')
                    contadorSigno++;
                else if (cadena[i] == ';')
                    contadorSigno++;
            }
            return contadorSigno;
        }
    }
}
