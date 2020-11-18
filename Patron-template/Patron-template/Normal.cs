using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_template
{
    class Normal : Iprimitiva
    {
        public double Decorar(int cantidad)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("hacer {0} veces", cantidad);
            Console.WriteLine("pintar logo tipo");
            Console.WriteLine("poner brillos");
            Console.WriteLine("adicionar cromos");
            return 7.50 * cantidad;


        }

        public double Empacar(int cantidad)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("hacer {0} veces", cantidad);
            Console.WriteLine("prepara cajas");
            Console.WriteLine("poner instruciones");
            Console.WriteLine("poner garantia");
            Console.WriteLine("meter en caja con empaque");
            Console.WriteLine("sellar caja");
            return 12.50 * cantidad;
        }
    }
}
