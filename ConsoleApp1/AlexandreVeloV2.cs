using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Trabajador2
    {
        private int Sueldo { get; set; }
        private string Nombre { get; set; }

        public Trabajador2(string nombre, int sueldo)
        {
            Sueldo = sueldo;
            Nombre = nombre;
        }

        public int getSueldo()
        {
            return Sueldo * 1000;
        }
    }
}
