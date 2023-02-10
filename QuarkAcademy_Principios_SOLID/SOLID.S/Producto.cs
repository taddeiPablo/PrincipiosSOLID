using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.S
{
    public class Producto
    {
        private string descripcion;
        private double precio;

        public Producto(string descripcion, double precio)
        {
            this.Precio = precio;
            this.Descripcion = descripcion;
        }

        public string Descripcion { get => descripcion; set => descripcion = value; }
        public double Precio { get => precio; set => precio = value; }
    }
}
