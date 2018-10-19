using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio52
{
    public class Lapiz  : IAcciones
    {
        private float tamañoMina;

        public Lapiz(int mina)
        {
            tamañoMina = mina;
        }
        ConsoleColor IAcciones.Color
        {
            get
            {
                return ConsoleColor.Gray;
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        float IAcciones.UnidadesDeEscritura
        {
            get
            {
                return tamañoMina;
            }
            set
            {
                tamañoMina = value;
            }
        }

        EscrituraWrapper IAcciones.Escribir(string texto)
        {
            StringBuilder escrito = new StringBuilder();
            float tamaño = (float)texto.Length;
            int i = 0;
            while(tamaño >= 0.1)
            {
                escrito.AppendFormat("{0}", texto[i]);
                i++;
                tamaño = (float)(tamaño - 0.1);
            }
            return new EscrituraWrapper(escrito.ToString(), ((IAcciones)this).Color);
        }

        bool IAcciones.Recargar(int unidades)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return "Es un Lapiz, de color " + ((IAcciones)this).Color.ToString() + " y tiene un nivel de tinta de " + ((IAcciones)this).UnidadesDeEscritura;
        }
    }
}
