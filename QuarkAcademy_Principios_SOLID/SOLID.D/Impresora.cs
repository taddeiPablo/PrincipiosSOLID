using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.D
{
    public class Impresora
    {
        public void imprimir(IImprimible imprimible)
        {
            imprimible.imprimir();
        }
    }
}
