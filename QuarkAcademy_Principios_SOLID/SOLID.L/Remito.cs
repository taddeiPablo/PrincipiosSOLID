using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.L
{
    public class Remito
    {
        private int cantBultos;
        private int numero;
        private DateTime fecha;

        public Remito(int numero, DateTime fecha, int cantBultos)
        {
            this.cantBultos = cantBultos;
            this.numero = numero;
            this.fecha = fecha;
        }

        public int CantBultos { get => cantBultos; set => cantBultos = value; }
        public int Numero { get => numero; set => numero = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }

        public string imprimir()
        {
            return $"imprimiendo : {descripcion()}";
        }

        public string descripcion()
        {
            return $"nroRemito: {Numero}, cantBultos: {cantBultos}, fecha: {Fecha}";
        }
    }
}
