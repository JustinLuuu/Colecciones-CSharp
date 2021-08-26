using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace HashTable_Usos  
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable mitabla = new Hashtable(); 

            mitabla.Add(123, "Ironman");    // insertamos primero la clave identificativa del item, y luego el item.
            mitabla.Add(22, "Ben10");    // insertamos primero la clave identificativa del item, y luego el item.
            mitabla.Add(265, "Timmy Turner");    // insertamos primero la clave identificativa del item, y luego el item.
            mitabla.Add(5454, "Flash");  
            mitabla.Add(5, "Aquaman");
                      
            string el = mitabla[123].ToString();  // acceder al valor del Hashtable por medio de la llave o clave, para luego convertirlo a string con el Metodo ToString puesto que algo que se almacena en este tipo de coleccion es object y no string
          
            ICollection keys = mitabla.Keys;  // Aplicar la interfaz de ICollection para obtener las llaves del Hashtable
            ICollection values = mitabla.Values; // Aplicar la interfaz de ICollection para obtener los valores del Hashtable

            foreach(int llaves in keys)   // recorrer cada una de las llaves que obtiene la interfaz ICollection [skeys] / NOTA: la interfaz ICollection solo se recorre por medio de un foreach, obvio
            {
                Console.WriteLine(llaves) ;
            }

            foreach (string valor in values)   // recorrer cada uno de los valores que obtiene la interfaz ICollection [values]
            {
                Console.WriteLine(valor);
            }

                Console.ReadKey();

            // Eliminamos un elemento del Hashtable por medio de su key, en este caso el del key 22
            mitabla.Remove(22);


            var cosa1 = mitabla[22];   // guardar dentro de una variable implicita el elemento que tiene por clave 22 en el Hashtable
            var cosa2 = mitabla[265];   // guardar dentro de una variable implicita el elemento que tiene por clave 265 en el Hashtable
            Console.WriteLine(cosa1  + "" + cosa2);  // imprimimos los valores capturados

            Console.WriteLine("-------------------------------\n");

           foreach(DictionaryEntry elemento in mitabla)  // DictionaryEntry se usa para iterar a traves de Hashtables, optando tambien por la posibilidad de acceder a la clave o al valor.
           {
               Console.WriteLine("[{0}] - {1}  ", elemento.Key, elemento.Value); 
           } 

            Console.WriteLine("----------------------------------\n");

            // BUSQUEDAS Y VERIFICACION DE VALORES
        
            if (mitabla.ContainsKey(5))  // usamos el metodo Contains para verificar si el key de x elemento existe retornando un booleano
            {
                Console.WriteLine("Existe un elemento con ese key");
            }

            else
            {
                Console.WriteLine("No existe un elemento con ese key");
            }


            if (mitabla.ContainsValue("Ben10"))  // usamos el metodo Contains para verificar si el valor existe retornando un booleano
            {
                Console.WriteLine("Existe un elemento con ese nombre");
            }

            else
            {
                Console.WriteLine("No existe un elemento con ese nombre");
            }



            Console.WriteLine("----------------------------------\n");

            // Imprimir solamente las llaves en el Hashtable

            foreach (int key in mitabla.Keys)
            {
                Console.WriteLine($"Llaves {key}");              
            }

            
            Console.WriteLine("----------------------------------\n");


            // Imprimir solamente los valores en el Hashtable

            foreach (string valores in mitabla.Values)
            {
                Console.WriteLine($"Valores {valores}");
            }



            Console.ReadKey();
                
        }
    }
}
