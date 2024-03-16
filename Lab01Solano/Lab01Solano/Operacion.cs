using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01Solano
{
    internal class Operacion
    {
        public int ValorA { get; set;}
        public int ValorB { get; set;}
        public int ValorC { get; set;}

        public int Sumar()
        {
            return ValorB+ValorA;
        }

        public int Restar()
        {
            return ValorB-ValorA;
        }

    }
}
