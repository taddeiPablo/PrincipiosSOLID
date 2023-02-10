using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.L
{
    public class Factura : DocumentoContable
    {

        public Factura(int numero, DateTime fecha):base(numero, fecha)
        {
            _sigla = "FC";
        }

        public override string descripcion()
        {
            return $"sigla: {_sigla}, fecha: {Fecha}, nro: {Numero}";
        }
    }
}
