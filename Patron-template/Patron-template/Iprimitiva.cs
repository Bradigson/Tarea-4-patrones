using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_template
{
    interface Iprimitiva
    {
        double Decorar(int cantidad);
        double Empacar(int cantidad);
    }
}
