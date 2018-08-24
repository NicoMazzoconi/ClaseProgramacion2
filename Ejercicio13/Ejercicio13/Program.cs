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
      Console.Title = "Ejercicio Nro 13";
      double numero;
      string numeroStr;
      numeroStr = Console.ReadLine();
      if(double.TryParse(numeroStr, out numero))
      {
        Console.WriteLine(Conversor.DecimalBinario(numero));
      }
      Console.ReadKey();
    }
  }
}
