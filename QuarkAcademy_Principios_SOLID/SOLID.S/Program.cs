using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.S
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *****************************************
             * [ SINGLE RESPONSABILITY PRINCIPLE (SRP) ]
             *****************************************
             */

            Cliente unCliente = new Cliente("pablo", "taddei");

            Factura unaFactura = new Factura(unCliente, 1111111);

            Item item1 = new Item(new Producto("Arroz", 10), 5);
            Item item2 = new Item(new Producto("Queso", 90), 1);
            Item item3 = new Item(new Producto("Gaseosa", 70), 2);

            unaFactura.ListaItems.Add(item1);
            unaFactura.ListaItems.Add(item2);
            unaFactura.ListaItems.Add(item3);

            Console.WriteLine(unaFactura.Total());
            Console.ReadKey();
        }
    }
}
