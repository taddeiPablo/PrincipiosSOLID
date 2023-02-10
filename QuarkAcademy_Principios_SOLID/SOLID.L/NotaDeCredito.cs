using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.L
{
    public class NotaDeCredito : DocumentoContable
    {

        public NotaDeCredito(int numero, DateTime fecha): base(numero, fecha)
        {
            _sigla = "NC";
        }

        public override string descripcion()
        {
            return $"sigla: {_sigla}, fecha: {Fecha}, nro: {Numero}";
        }
    }
}
