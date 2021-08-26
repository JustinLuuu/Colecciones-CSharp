using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suma_precios_de_una_lista_de_objetos
{
    enum Categorias { A, B };

    abstract class Productos
    {
        private string nombre;
        private double precio;
        private Categorias categoria;

        public string NOMBRE { get => nombre; set => nombre =value; }
        public double PRECIO { get => precio; set => precio = value; }
        public Categorias CATEGORIA { get => categoria; set => categoria = value; }

    }

}
