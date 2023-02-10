using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.I
{
    public class Factura : DocumentoContable
    {
        private string cai;

        public Factura(int numero, DateTime fecha):base(numero, fecha)
        {

        }
        public string Cai { get => cai; set => cai = value; }

        public override void imprimir()
        {
            Console.WriteLine($"imprimiendo factura : nro:{Numero}, fecha: {Fecha}");
        }
    }
}
