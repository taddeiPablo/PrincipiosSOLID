using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.D
{
    public abstract class Impuesto: IImprimible
    {
        private double importe;

        public Impuesto(double importe)
        {
            this.Importe = importe;
        }

        public double Importe { get => importe; set => importe = value; }

        public abstract void imprimir();
    }
}
