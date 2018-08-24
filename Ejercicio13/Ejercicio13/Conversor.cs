using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
  class Conversor
  {
    public static string DecimalBinario(double decim)
    {
      string binario = "1";
      double resto;
      while(decim > 1)
      {
        resto = decim % 2;
        decim = decim / 2;
        binario = binario + resto;
      }
      return binario;
    }
    public static double BinarioDecimal(string binario)
    {
      return 1;
    }

  }
}
