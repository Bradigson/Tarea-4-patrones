using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_Metodo_Fabrica
{
    class CAuto : IVehiculo
    {
        public void acelerar()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("pisa el acelerador");
        }

        public void encencer()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("introduce la llavey gira la hacia la derecha");
        }

        public void frenar()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("primero pisa el freno y si n o es suficiente usa el freno de emergencia");
        }

        public void girar()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("gira el timon para girar");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("se puede comprar un carro");
        }
    }
}
