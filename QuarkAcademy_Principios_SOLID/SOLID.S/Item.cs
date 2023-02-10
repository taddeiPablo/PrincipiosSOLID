using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.S
{
    public class Item
    {
        private Producto unproducto;
        private int cantidad;

        public Item(Producto unproducto, int cantidad)
        {
            this.Unproducto = unproducto;
            this.Cantidad = cantidad;
        }

        public double subTotal()
        {
            return this.cantidad * this.unproducto.Precio;
        }

        public Producto Unproducto { get => unproducto; set => unproducto = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
    }
}
