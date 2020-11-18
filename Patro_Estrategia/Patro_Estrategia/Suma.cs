using Patron_Estrategia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_Estrategia
{
    class Suma : IOperacion
    {
        // este es el metodo que se encuentra en IOperacion que es la interface y suma la esta implementando
        // por lo que este es el metodo de la intrerface
        public double operacion (double a, double b)
            {
            return a + b;
            }

    }
}
