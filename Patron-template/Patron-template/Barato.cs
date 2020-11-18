using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_template
{
    class Barato: Iprimitiva
    {
        public double Decorar(int cantidad)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            for(int n =0; n<cantidad; n += 1)
            {
                Console.WriteLine("pagar etiqueta");
            }
            return 1.5 * cantidad;

        }
        public double Empacar(int cantidad)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            for(int n=0; n<cantidad; n = n + 1)
            {
                Console.WriteLine("meter en bolsa");
                
            }
            return 0.25 * cantidad;
        }
    }
}
