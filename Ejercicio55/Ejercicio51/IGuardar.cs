﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio51
{
    public interface IGuardar<T>
    {
        string RutaDeArchivo
        {
            get;
            set;
        }

        bool Guardar(string path, string info);

        T Leer(string path);
    }
}
