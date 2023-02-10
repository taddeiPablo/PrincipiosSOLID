using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.D
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             **********************************************
             * [ Dependency Inversion Principle ] (DIP)
             **********************************************
             */

            Impresora impresora = new Impresora();

            IImprimible factura = new Factura(3848374, DateTime.Now, 2000);
            IImprimible notaCredito = new NotaDeCredito(382837273, DateTime.Now, 3000);
            IImprimible fL = new FacturaLuz(300);
            IImprimible mc = new Municipal(400,"2023");

            impresora.imprimir(factura);
            impresora.imprimir(notaCredito);
            impresora.imprimir(fL);
            impresora.imprimir(mc);

            Console.ReadKey();
        }
    }
}
