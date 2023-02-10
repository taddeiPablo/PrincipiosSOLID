using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.I
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             ********************************************
             * [ Interface Segregation Principle (ISP) ]
             ********************************************
             */

            Factura unafactura = new Factura(238378947, DateTime.Now);
            unafactura.Cai = "#35253534";
            FacturaElectronica unafacturaElectronica = new FacturaElectronica(3248238, DateTime.Now);
            unafacturaElectronica.CAE = "#456456464564564";

            unafactura.imprimir();
            // solo la factura electronica nos permite enviar por email por implementar la interfaz IEMAILEABLE
            unafacturaElectronica.imprimir();
            unafacturaElectronica.enviarPorEmail();
            Console.ReadKey();
        }
    }
}
