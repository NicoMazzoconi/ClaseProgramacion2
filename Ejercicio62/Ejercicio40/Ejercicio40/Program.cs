﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio40
{
    class Program
    {
        static void Main(string[] args)
        {
            // Mi central
            Centralita c = new Centralita("Fede Center");
            // Mis 4 llamadas
            Local l1 = new Local("Bernal", 30, "Rosario", 2.65f);
            Provincial l2 = new Provincial("Morón", Franja.Franja_1, 21, "Bernal");
            Local l3 = new Local("Lanús", 45, "San Rafael", 1.99f);
            Provincial l4 = new Provincial(l2, Franja.Franja_3);
            // Las llamadas se irán registrando en la Centralita.
            // La centralita mostrará por pantalla todas las llamadas según las vaya registrando.
            c = c + l4;
          //  Console.WriteLine(c.Mostrar());
            c = c + l3;
            //  Console.WriteLine(c.Mostrar());
            c = c + l2;
            //  Console.WriteLine(c.Mostrar());
            c = c + l1;
            //Console.WriteLine(c.Mostrar());
            c.OrdenarLlamadas();
            Console.WriteLine(c.ToString());
            Console.ReadKey();
        }
    }
}
