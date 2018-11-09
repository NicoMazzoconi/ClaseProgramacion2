using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Temporizador
{
    public delegate bool encargadoTiempo();

    sealed class Temporizador
    {
        Thread hilo;
        int intervalo;

        public bool Activo
        {
            get
            {
                return hilo.IsAlive;
            }
            set
            {
                if (value == true && !(hilo.IsAlive))
                    hilo.Start();
                else if (value == false && hilo.IsAlive)
                    hilo.Abort();
            }
        }

        public int Intervalo
        {
            get
            {
                return intervalo;
            }

            set
            {
                intervalo = value;
            }
        }

        private void Corriendo()
        {
            while(true)
            {
                Thread.Sleep(intervalo);
                EventTiempo.Invoke();
            }
        }

        public event encargadoTiempo EventTiempo;
    }
}
