using System;
using System.Collections.Generic;
using System.Collections; // es necesario incluir la libreria de System.Collections para hacer uso de ArrayList
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList_probando
{
    class Program
    {
        static void Main(string[] args)
        {          
            // los ArrayList pueden almacenar diferentes tipos de datos, algo que no permite las listas genericas que almacenan un determinado tipo
            // de datos.

            ArrayList coleccion = new ArrayList();
            coleccion.Add("Justin"); // string
            coleccion.Add(4); // int
            coleccion.Add(true); // bool
           
            foreach(var el in coleccion)
            {
                Console.WriteLine(el);
            }

            Console.WriteLine("-------------------\n");


            ArrayList lista = new ArrayList();
            lista.AddRange(new string[] { "aa", "a" });  // Los ArrayList pueden guardar colecciones dentro, como el arreglo que esta ahi. Por cierto 
            // El método AddRange en listas agrega una colección completa de elementos, de lo contrario dara error si intenta agregar una coleccion con el 
            // metodo Add (), si de agregar colecciones se trata. Es vital recalcar que los elementos que estan dentro del array cuando lo insertamos 
            //en la lista ocupan espacios diferentes            
            // en la lista, por ejemplo el elemento "aa" esta en la posicion [0] y el elemento "a" ocupa la posicion [1] en toda la lista..

            lista.AddRange(new int[] { 9, 4 });

            foreach (var a in lista)
            {
                Console.WriteLine(a);
            }

            
            Console.WriteLine("---------------------\n");

            ArrayList lista1 = new ArrayList();
            lista1.Add("leonel");
            lista1.Add("hipolito");

            Console.WriteLine("Escriba el elemento a buscar");
            string palabra = Console.ReadLine();

            if (lista1.Contains(palabra))
            {
                Console.WriteLine("LO TIENE");
            }

            else
            {
                Console.WriteLine("No LO TIENE");
            }


            Console.ReadKey();
        }
     
    }
}
