using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
  class Program
  {
    static void Main(string[] args)
    {

      //Desarrollar una clase llamada Conversor, que posea dos métodos de clase(estáticos):
      //string DecimalBinario(double). Convierte un número de entero a binario.
      //double BinarioDecimal(string). Convierte un número binario a entero.

      double aBinario = 120; //1111000
      string aDecimal = "100000100"; //520
      Console.WriteLine("Binario: " + Conversor.DecimalBinario(aBinario));
      Console.WriteLine("Decimal: " + Conversor.BinarioDecimal(aDecimal));
      Console.ReadKey();
    }
  }
}
