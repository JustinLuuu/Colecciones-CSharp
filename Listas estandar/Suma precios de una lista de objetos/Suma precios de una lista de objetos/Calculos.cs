using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suma_precios_de_una_lista_de_objetos
{
    class Calculos
    {
        public static double CalcularPrecios(List<Productos> lista)
        {
            double suma = 0;

            foreach(var producto in lista)
            {
                suma += producto.PRECIO;
            }

            return suma;
        }


        public static string ContarProductos(List<Productos> lista)
        {
            string cat;
            int conteoA = 0;
            int conteoB = 0;

            foreach(var producto in lista)
            {
                cat = producto.CATEGORIA.ToString();

                if (cat.Equals("A"))
                {
                    conteoA++;
                }

                else
                {
                    conteoB++;
                }

            }
            return string.Format("Hay {0} productos [ categoria A ] y {1} [ categoria B ] ", conteoA, conteoB);
        }


        public static string ContarTipos(List<Productos> lista )
        {
            int alimenticio = 0;
            int farmaco = 0;

            foreach(var producto in lista)
            {
                if(producto is ProductoAlimenticio)
                {
                    alimenticio++;
                }

                else
                {
                    farmaco++;
                }

            }

            return string.Format("Hay {0} productos alimenticios y {1} productos farmacos", alimenticio, farmaco);
        }



    }
}
