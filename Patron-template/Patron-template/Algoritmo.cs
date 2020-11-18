using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_template
{
    class Algoritmo
    {
        public double metodoTemplate(Iprimitiva tipo, int cantidad)
        {
            double total = 0;
            //crear juguete
            total += crearjuguete(cantidad);

            //lo decoramos
            total += tipo.Decorar(cantidad);

            //verificar cantidad
            calidad();

            //empacamos
            total += tipo.Empacar(cantidad);
            return total;
        }
        private double crearjuguete(int pCantidad)
        {
            Console.WriteLine("Estamos creando {0} juguetes", pCantidad);
            return 16.50 * pCantidad;
        }
        private void calidad()
        {
            Console.WriteLine("pasa control de claidad");

        }
    }
}
