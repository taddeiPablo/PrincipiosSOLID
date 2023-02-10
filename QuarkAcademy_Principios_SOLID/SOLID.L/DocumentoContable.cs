using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.L
{
    public abstract class DocumentoContable
    {
        protected string _sigla;
        private int numero;
        private DateTime fecha;

        public DocumentoContable(int numero, DateTime fecha)
        {
            this.Numero = numero;
            this.Fecha = fecha;
        }

        public int Numero { get => numero; set => numero = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }

        public string imprimir()
        {
            return $"imprimiendo {descripcion()}";
        }

        public virtual string descripcion()
        {
            return $"sigla : {_sigla}, nro: {numero}, fecha: {fecha}";
        }
    }
}
