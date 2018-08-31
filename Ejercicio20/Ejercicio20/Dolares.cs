using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    class Dolares
    {
        private double Cantidad;
        private static float CotizRespectoDolar;
        static Dolares()
        {
            CotizRespectoDolar = 1;
        }

        public Dolares(double cantidad)
        {
            this.Cantidad = cantidad;
        }

        public Dolares(double cantidad, float cotizacion) :this(cantidad)
        {
            CotizRespectoDolar = cotizacion;
        }

        public double GetCantidad()
        {
            return this.Cantidad;
        }

        public float GetCotizacion()
        {
            return CotizRespectoDolar;
        }

        public static explicit operator Pesos(Dolares d)
        {
            Pesos p = (Pesos)d;
            return p;
        }

        public static explicit operator Euros(Dolares d)
        {
            Euros e = (Euros)d;
            return e;
        }

        public static implicit operator Dolares(double d)
        {
            Dolares e = new Dolares(d);
            return e;
        }

        public static bool operator !=(Dolares d, Pesos p)
        {
            if ((Dolares)p != d)
                return true;
            return false;
        }

        public static bool operator ==(Dolares e, Pesos p)
        {
            if (e == (Dolares)p)
                return true;
            return false;
        }

        public static bool operator !=(Dolares d, Euros p)
        {
            if ((Dolares)p != d)
                return true;
            return false;
        }

        public static bool operator ==(Dolares e, Euros p)
        {
            if (e == (Dolares)p)
                return true;
            return false;
        }

        public static bool operator !=(Dolares d, Dolares d2)
        {
            if (d != d2)
                return true;
            return false;
        }

        public static bool operator ==(Dolares d, Dolares d2)
        {
            if (d == d2)
                return true;
            return false;
        }
    }
}
