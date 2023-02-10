using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.O
{
    public abstract class DocumentoContable
    {
        private int numero;
        private double importe;
        private DateTime fecha;

        public DocumentoContable(int numero)
        {
            this.numero = numero;
        }

        public int Numero { get => numero; set => numero = value; }
        public double Importe { get => importe; set => importe = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }

        public abstract string Descripcion();
    }
}
