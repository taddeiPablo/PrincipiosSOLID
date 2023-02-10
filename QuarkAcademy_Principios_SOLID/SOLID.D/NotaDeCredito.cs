using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.D
{
    public class NotaDeCredito : DocumentoContable
    {


        public NotaDeCredito(int numero, DateTime fecha, double importe):base(numero, fecha, importe)
        {
            _sigla = "NC";
        }
        public override void imprimir()
        {
            Console.WriteLine($"imprimiendo nota de credito : nro: {Numero}, fecha: {Fecha}, importe: {Importe}");
        }

        public override double Total()
        {
            return Importe * 1.21 * -1;
        }
    }
}
