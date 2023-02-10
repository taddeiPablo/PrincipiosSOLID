using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.O
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *********************************
             * [ OPEN/CLOSE PRINCIPLE (OCP) ]
             *********************************
             */

            DocumentoContable factura = new Factura(23454622);
            Console.WriteLine(factura.Descripcion());
            DocumentoContable nota_de_credito = new NotaDeCredito(234242342);
            Console.WriteLine(nota_de_credito.Descripcion());
            Console.ReadKey();
        }
    }
}
