using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.S
{
    public class Cliente
    {
        private string nombre;
        private string apellido;

        public Cliente(string nombre, string apellido)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
    }
}
