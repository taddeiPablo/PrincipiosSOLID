using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.L
{
    public class Impresora
    {
        public void ImprimirRemito(Remito remito)
        {
            Console.WriteLine(remito.imprimir());
        }

        public void imprimirDocumentos(DocumentoContable documento)
        {
            Console.WriteLine(documento.imprimir());
        }
    }
}
