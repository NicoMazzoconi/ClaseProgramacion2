using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("GENERANDO NUMERO RANDOM");
            int[] numeroEnteros = new int[20];
            for(int i = 0; i < 20; i++)
            {
                Random rm = new Random(i * DateTime.Now.Millisecond);
                
                numeroEnteros[i] = rm.Next(-32768, 32767);
                Console.WriteLine(numeroEnteros[i]);
            }

            Console.WriteLine("NUMEROS POSITIVOS DE MAYOR A MENOR");
            int flagSwap, aux;
            do
            {
                flagSwap = 0;
                for (int i = 0; i < 20 - 1; i++)
                {
                    if (numeroEnteros[i] < numeroEnteros[i + 1])
                    {
                        aux = numeroEnteros[i];
                        numeroEnteros[i] = numeroEnteros[i + 1];
                        numeroEnteros[i + 1] = aux;
                        flagSwap = 1;
                    }
                }
            }while(flagSwap == 1);

            for(int i = 0; i < 20; i++)
            {
                if (numeroEnteros[i] > 0)
                    Console.WriteLine(numeroEnteros[i]);
            }
            Console.WriteLine("NUMERO NEGATIVOS DE MENOR A MAYOR");
            do
            {
                flagSwap = 0;
                for (int i = 0; i < 20 - 1; i++)
                {
                    if (numeroEnteros[i] > numeroEnteros[i + 1])
                    {
                        aux = numeroEnteros[i];
                        numeroEnteros[i] = numeroEnteros[i + 1];
                        numeroEnteros[i + 1] = aux;
                        flagSwap = 1;
                    }
                }
            } while (flagSwap == 1);

            for (int i = 0; i < 20; i++)
            {
                if (numeroEnteros[i] < 0)
                    Console.WriteLine(numeroEnteros[i]);
            }
            List<int> listaEnteros = new List<int>();
            listaEnteros.Add(2); 
            Console.ReadKey();
        }
    }
}
