using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suma_precios_de_una_lista_de_objetos
{
    class ProductoFarmaco : Productos
    {
        public ProductoFarmaco(string nombre, double precio, Categorias categorias)
        {
            NOMBRE = nombre;
            PRECIO = precio;
            CATEGORIA = categorias;
        }


    }
}
