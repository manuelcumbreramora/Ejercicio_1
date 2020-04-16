using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class DiegoArias
    {
        public double RndNumber { get; }


        public DiegoArias() 
	{
		this.RndNumber = (new Random()).NextDouble();
        }
    }
}
