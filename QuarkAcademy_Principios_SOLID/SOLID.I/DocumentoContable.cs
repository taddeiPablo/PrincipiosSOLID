using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.I
{
    public abstract class DocumentoContable : IImprimible
    {
        private int numero;
        private DateTime fecha;


        public DocumentoContable(int numero, DateTime fecha)
        {
            this.numero = numero;
            this.fecha = fecha;
        }

        public int Numero { get => numero; set => numero = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }

        public abstract void imprimir();
    }
}
