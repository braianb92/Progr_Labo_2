using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
  public  class Cuadrado
  {
    public bool Validar(string stringNumero,out int numero)
    {
      if(int.TryParse(stringNumero,out numero))
      {
        if (numero > 0)
        {
          return true;
        }
        else
        {
          return false;
        }
      }
      else
      {
        return false;
      }
          
    }

      public  bool PotenciarCuadrado(int numero,out double max)
      {
          max = Math.Pow(numero, 2);
          return true;
      }

      public bool PotenciarCubo(int numero, out double max)
      {
        max = Math.Pow(numero, 3);
        return true;
      }
  }
}
