using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.S
{
    public class Factura
    {
        private Cliente uncliente;
        private int numeroFactura;
        private List<Item> listaItems;

        public Factura(Cliente uncliente, int numeroFactura)
        {
            this.Uncliente = uncliente;
            this.NumeroFactura = numeroFactura;
            this.ListaItems = new List<Item>();
        }

        public Cliente Uncliente { get => uncliente; set => uncliente = value; }
        public int NumeroFactura { get => numeroFactura; set => numeroFactura = value; }
        public List<Item> ListaItems { get => listaItems; set => listaItems = value; }

        public double Total()
        {
            double total = 0;
            foreach (Item item in this.listaItems)
            {
                total += item.subTotal();
            }
            return total;
        }
    }
}
