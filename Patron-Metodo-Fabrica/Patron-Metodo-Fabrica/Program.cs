using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_Metodo_Fabrica
{
    class Program
    {
        static void Main(string[] args)
        {
            string dato;
            int dinero;
            IVehiculo vehiculo;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("cuanto dinero tiene para tu transporte?");
            dato = Console.ReadLine();
            dinero = Convert.ToInt32(dato);

            //aqui obtenemos el vehiculo de la fabrica
            vehiculo = CDesigner.MetodoFabrica(dinero);

            vehiculo.encencer();
            vehiculo.acelerar();
            vehiculo.frenar();
            vehiculo.girar();


            Console.ReadKey();


        }
    }
}
