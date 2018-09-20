using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ejercicio31
{
    enum Puesto
    {
        Caja1,
        Caja2
    }

    class PuestoAtencion
    {
        private Puesto puesto;
        private static int numeroActual;

        static PuestoAtencion()
        {
            numeroActual = 0;
        }
        
        public PuestoAtencion(Puesto puesto)
        {
            this.puesto = puesto;
        }

        public bool Atender(Cliente cli)
        {
            Thread.Sleep(500);
            return true;
        }

        static int NumeroActual
        {
            get
            {
                numeroActual++;
                return numeroActual;
            }
        }
    }
}
