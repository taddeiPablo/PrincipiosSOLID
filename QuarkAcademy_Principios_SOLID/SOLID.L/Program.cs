using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.L
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             ******************************************
             * [ LISKOV SUBSTITUTION PRINCIPLE (LSP) ]
             ******************************************
             */

            Impresora impresora = new Impresora();

            Remito unremito = new Remito(329288, DateTime.Now, 20);
            DocumentoContable unaFactura = new Factura(39847883, DateTime.Now);
            DocumentoContable unanotadeCredito = new NotaDeCredito(38745645, DateTime.Now);

            impresora.imprimirDocumentos(unaFactura);
            impresora.imprimirDocumentos(unanotadeCredito);
            impresora.ImprimirRemito(unremito);

            Console.ReadKey();
        }
    }
}
