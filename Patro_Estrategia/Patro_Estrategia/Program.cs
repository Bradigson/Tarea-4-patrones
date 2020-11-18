using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_Estrategia
{
    class Program
    {
        static void Main(string[] args)
        {
            string datos = "";
            double x = 0;
            double y = 0;
            double r = 0;
            string opcion = "";
            
            IOperacion miOperacion = new Suma();
            
            while (opcion != "5")
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("1-suma, 2-resta, 3-multiplicacion, 4-division, 5-salir");
                opcion = Console.ReadLine();
                if (opcion == "5")
                    break;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("valor de a");
                datos = Console.ReadLine();
                x = Convert.ToDouble(datos);

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Valor de b");
                datos = Console.ReadLine();
                y = Convert.ToDouble(datos);

                //Ahora selecionamos el algorimo de acuerdo a la necesidad
                if (opcion.Equals("1"))
                    miOperacion = new Suma();
                if (opcion == "2")
                    miOperacion = new Resta();
                if (opcion.Equals("3"))
                    miOperacion = new Multiplicacion();
                if (opcion.Equals("4"))
                    miOperacion = new Division();
                r = miOperacion.operacion(x, y);
                Console.BackgroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("El resultado es {0}", r);
            }Console.ReadKey();
        }
    }
}
