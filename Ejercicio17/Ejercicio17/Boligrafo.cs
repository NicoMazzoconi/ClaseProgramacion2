using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boligrafos
{
    public class Boligrafo
    {
        private ConsoleColor color;
        private short tinta;
        const short cantidadTintaMaxima = 100;

        public ConsoleColor GetColor()
        {
            return this.color;
        }

        public short GetTinta()
        {
            return this.tinta;
        }

        private void SetTinta(short tinta)
        {
            if (tinta < 0)
            {
                if (this.tinta - tinta >= 0)
                    this.tinta = (short)(this.tinta - tinta);
                else
                    this.tinta = 0;
            }
            else if (tinta > 0)
            {
                if (this.tinta + tinta <= cantidadTintaMaxima)
                    this.tinta = (short)(this.tinta + tinta);
                else
                    this.tinta = 100;
            }
        }

        public void Recarga()
        {
            SetTinta(100);
        }

        public void Pintar(int gasto, out string dibujo)
        {
            short i;
            dibujo = "";
            if (gasto >= this.tinta)
            {
                for (i = 0; i < tinta; i++)
                    dibujo = dibujo + "*";
                SetTinta(-100);
            }
            else
                for (i = 0; i < gasto; i++)
                    dibujo = dibujo + "*";
            SetTinta((short)-i);
        }

        public Boligrafo BoligrafoCreate(short tinta, ConsoleColor color)
        {
            Boligrafo boligrafo = new Boligrafo();
            if (tinta > 100)
                boligrafo.tinta = 100;
            else if (tinta < 0)
                boligrafo.tinta = 0;
            else
                boligrafo.tinta = tinta;
            boligrafo.color = color;
            return boligrafo;
        }
    }
}
