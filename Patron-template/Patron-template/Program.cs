using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_template
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidad = 0;
            string tipo = "";
            Iprimitiva calidad = null;
            double total = 0; ;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("1-barato, 2-normal");
            tipo = Console.ReadLine();

            if (tipo.Equals("1"))
                calidad = new Barato();
            if (tipo.Equals("2"))
                calidad = new Normal();
            Console.WriteLine("cuantos a producir?");
            cantidad = Convert.ToInt32(Console.ReadLine());


            Algoritmo producion = new Algoritmo();


            total = producion.metodoTemplate(calidad, cantidad);


            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("el total es:{0}", total);
            Console.ReadKey();

        }
    }
}
