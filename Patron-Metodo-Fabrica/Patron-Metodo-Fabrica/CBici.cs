using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_Metodo_Fabrica
{
    class CBici : IVehiculo
    {
        public void acelerar()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("la bicicleta no necesita ser encendida");
        }

        public void encencer()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Pedalea fuerte para acelerar");
        }

        public void frenar()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("primero frena de atras");
        }

        public void girar()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("usar el timon para girar y hacer piruetas");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("se puede comprar una bicicleta");
        }
    }
}
