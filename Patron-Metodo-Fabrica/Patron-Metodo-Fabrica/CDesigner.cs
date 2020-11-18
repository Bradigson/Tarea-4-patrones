using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_Metodo_Fabrica
{
    class CDesigner
    {
        public static IVehiculo MetodoFabrica(int pDinero)
        {
            IVehiculo temp = null;
            // selecione el tipo de instancia segun las reglas
            if (pDinero >= 3000)
                temp = new CAvion();
            else if (pDinero >= 2000)
                temp = new CAuto();
            else
               
                temp = new CBici();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("uuuu..... solo tiene para una bicicleta");
            return temp;
        }
    }
}
