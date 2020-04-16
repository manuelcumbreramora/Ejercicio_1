using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class AlvaroGame
    {
        public String toc;
        public String metodoAlvaro()
        {
            //Hola2
            Random random = new Random();
            if (random.Next(0,10) > 7)
            {
                toc = "Ganador";
            }
            else
            {
                toc = "Looser";
            }
            return toc;
        }
    }
}
