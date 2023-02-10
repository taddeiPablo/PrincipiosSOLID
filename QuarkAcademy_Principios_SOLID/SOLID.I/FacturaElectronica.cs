using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.I
{
    public class FacturaElectronica : DocumentoContable, IEmailable
    {
        private string Cae;


        public FacturaElectronica(int numero, DateTime fecha):base(numero, fecha)
        {

        }

        public string CAE { get => Cae; set => Cae = value; }

        public void enviarPorEmail()
        {
            Console.WriteLine($"se envio con exito la factura por email, fecha:{Fecha}, nro: {Numero}");
        }

        public override void imprimir()
        {
            Console.WriteLine($"imprimiendo : nro{Numero}, fecha: {Fecha}, cae: {CAE}");
        }
    }
}
