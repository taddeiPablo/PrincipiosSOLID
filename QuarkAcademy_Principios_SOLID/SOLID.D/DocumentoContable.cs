using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.D
{
    public abstract class DocumentoContable: IImprimible
    {
        protected string _sigla;
        private int numero;
        private DateTime fecha;
        private double importe;

        public DocumentoContable(int numero, DateTime fecha, double importe)
        {
            this.Numero = numero;
            this.Fecha = fecha;
            this.Importe = importe;
        }

        public int Numero { get => numero; set => numero = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public double Importe { get => importe; set => importe = value; }

        public abstract void imprimir();

        public abstract double Total();
    }
}
