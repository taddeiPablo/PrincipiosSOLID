using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.D
{
    public class FacturaLuz : Impuesto
    {

        public FacturaLuz(double importe) : base(importe)
        {

        }

        public override void imprimir()
        {
            Console.WriteLine($"imprimiendo factura de luz, importe:{Importe}");
        }
    }
}
