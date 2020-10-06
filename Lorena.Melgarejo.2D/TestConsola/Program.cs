using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace TestConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Producto miproducto = new Producto("127", ECategoria.Almacen, "Alegria", "Galletitas de 300gr", 45, 10);
            Producto miproducto2 = new Producto("128", ECategoria.Almacen, "Alegria", "Galletitas de 60gr", 25, 10);
            Producto miproducto3 = new Producto("128", ECategoria.Almacen, "Alegria", "Galletitas de 60gr", 25, 10);
            //Market miMarket = new Market(1000);
            

            //Muestra el Producto
            Console.WriteLine(miproducto.ToString());
           // Console.WriteLine(miMarket.ToString());


            Console.ReadKey();

        }
    }
}
