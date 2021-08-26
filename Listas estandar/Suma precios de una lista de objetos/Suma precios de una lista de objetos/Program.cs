using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suma_precios_de_una_lista_de_objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Productos> listaProductos = new List<Productos>()
            {
                new ProductoFarmaco("Xanax", 210, Categorias.A),
                new ProductoFarmaco("Antigripal", 150, Categorias.A),
                new ProductoAlimenticio("Leche", 50, Categorias.B),
                new ProductoAlimenticio("Yogurt", 36, Categorias.A),
                new ProductoAlimenticio("Manzana", 50, Categorias.B)
            };

             Console.WriteLine( "El total de todos los productos es " + Calculos.CalcularPrecios(listaProductos));
             Console.WriteLine(Calculos.ContarProductos(listaProductos));
             Console.WriteLine(Calculos.ContarTipos(listaProductos));

            Console.ReadKey();
        }
      
    }

}
