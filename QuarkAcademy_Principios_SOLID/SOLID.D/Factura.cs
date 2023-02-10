using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.D
{
    public class Factura : DocumentoContable
    {

        public Factura(int numero, DateTime fecha, double importe): base(numero, fecha, importe)
        {
            _sigla = "FC";
        }

        public override void imprimir()
        {
            Console.WriteLine($"Imprimiendo Factura : nro: {Numero}, fecha:{Fecha}, importe: {Importe}");
        }

        public override double Total()
        {
            return Importe * 1.21;
        }
    }
}
