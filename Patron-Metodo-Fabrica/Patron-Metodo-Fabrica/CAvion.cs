using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_Metodo_Fabrica
{
    class CAvion : IVehiculo
    {
        public void acelerar()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("girar la gran palanca de acelerar");
        }

        public void encencer()
        {

            Console.WriteLine("debe de seguir la indicaciones dadas junto a su compañero de vuelo");
        }

        public void frenar()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("ir desacelerando despacio");
        }

        public void girar()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("jusnto a su compañero girar los wheels hacia la direccion deseada");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Se puede compra un avion");

        }
    }
}
