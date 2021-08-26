using System;
using System.Collections.Generic;

namespace LinkedList
{

    class Program
    {

        // Main Method 
        static public void Main()
        {

            LinkedList<String> my_list = new LinkedList<String>();  // crear lista linkeada


            my_list.AddLast("Zoya");             //// agregar elemento al final de la lista
            my_list.AddLast("Shilpa");
            my_list.AddLast("Rohit");
            my_list.AddLast("Rohan");
            my_list.AddLast("Juhi");
            my_list.AddLast("Zoya");


            my_list.AddFirst("Zoya");             //// agregar elemento al principio de la lista
            my_list.AddFirst("Shilpa");
            my_list.AddFirst("Rohit");
            my_list.AddFirst("Rohan");
            my_list.AddFirst("Juhi");
            my_list.AddFirst("Zoya");


            foreach (string str in my_list)    /// recorrer lista
            {
                Console.WriteLine(str);
            }

            

            //////////////////////////////////////////////////////////////////////////

            my_list.Remove(my_list.First);       /// eliminar ultimo elemento de la lista

            foreach (string str in my_list)
            {
                Console.WriteLine(str);
            }

            ////////////////////////////////////////////////////////////////////////////////


            my_list.Remove("Rohit");        /// eliminar elemento en especifico con tan solo decir el elemento o el nombre del elemento.

            foreach (string str in my_list)
            {
                Console.WriteLine(str);
            }

            ////////////////////////////////////////////////////////////////////////////////////////////



            my_list.Clear();    /// limpiar o eliminar todos los elementos de la lista

            Console.WriteLine("Number of students: {0}", my_list.Count);    /// contar elementos de la lista


        }
    }
}