using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.D
{
    public class Municipal: Impuesto
    {
        private string partida;

        public Municipal(double importe, string partida) : base(importe)
        {
            this.partida = partida;
        }

        public string Partida { get => partida; set => partida = value; }

        public override void imprimir()
        {
            Console.WriteLine($"imprimiendo Impuesto Municipal, partida:{partida}, importe:{Importe}");
        }
    }
}
