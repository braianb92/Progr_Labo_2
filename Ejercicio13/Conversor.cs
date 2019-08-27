using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
  class Conversor
  {
    public static string DecimalBinario(double numero)
    {
      String cadena = "";
      if (numero > 0)
      {
        
        while (numero > 0)
        {
          if (numero % 2 == 0)
          {
            cadena = "0" + cadena;
          }
          else
          {
            cadena = "1" + cadena;
          }
          numero = (int)(numero / 2);
        }
      }
      return cadena;
    }

    public static double BinarioDecimal(string binario)
    {
      double numDecimal=0;
      int digito;
      

      for (int i = binario.Length; i >= 0 ; i--)
      {
        if(int.TryParse(binario,out digito))
        {
          numDecimal += Math.Pow(digito * 10, i);
        }  
      }
      return numDecimal;
    }
  }
}
