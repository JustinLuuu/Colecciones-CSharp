using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_iteraciones_y_recorridos_part._2
{
    class Program
    {
        static void Main(string[] args)
        {
            
         
            LinkedList<int> numeros = new LinkedList<int>();

            foreach(int numero in new int[] {10, 8, 6, 4, 2, 0 })    // por cada elemento lo ira agregando al final en la lista
            {
                numeros.AddLast(numero);
            }


            foreach(int numero in numeros)   // recorrer lista con foreach
            {
                Console.WriteLine(numero);
            }

            Console.WriteLine("Con linkedListNode : \n");

            for(LinkedListNode<int> nodo = numeros.First; nodo != null; nodo = nodo.Next)    // funciona como un for basicamente, el ultimo parametro del LinkedListNode es el nodo.Next lo que lo hara avanzar en la coleccion de elementos.
            {
                int numero = nodo.Value;

            
                Console.WriteLine(numero);
            }


            Console.ReadKey();
        }
    }
}
