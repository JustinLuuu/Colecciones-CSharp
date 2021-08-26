using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    

    class Program
    {
     
        static void Main(string[] args)
        {
          
            /// primera lista 

            List<int> numeros = new List<int>();   // crear lista

            numeros.Add(8);  // agregar elemento
            numeros.Add(9);
            numeros.Add(10);

          
            foreach(int elemento in numeros)  // bucle foreach
            {
                Console.WriteLine(elemento);
            }


            int[] arreglo = new int[numeros.Count];    // asignandole una capacidad de elementos al arreglo conforme a la capacidad de lista, como se trata de listas y no arreglos es .Count  y no .Length

            for (int i = 0; i < arreglo.Length; i++)
            {
                arreglo[i] = numeros[i];  /// asignando valores de la lista al array 
            }

            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.WriteLine(arreglo[i]);
            }



            Console.ReadKey();


            // segunda lista

            List<string> nombres = new List<string>();

            nombres.Add("Justin");
            nombres.Add("Eliezer");
            nombres.Add("Rafael");
           

            for (int i = 0; i < nombres.Count; i++)   // el mismo resultado que un foreach pero como es una lista que estamos tratando se usa el .Count que el .Length
            {
                Console.WriteLine(nombres[i]);
            }



            // tercera lista

            List<int> Lista = new List<int>();

                                                      //  Lista.Add(Convert.ToInt32(Console.ReadLine()));    << para agregar en la lista escribiendo en consola

            int elem = 1;
                
            while(elem != 0)  // un jueguito, hasta que no hayamos insertado un 0 entonces nos mantendra ahi adentro
            {
                elem = Convert.ToInt32(Console.ReadLine());   //// insercion de datos
                 
                if(elem == 0) 
                {
                    break;
                }

                Lista.Add(elem);
            }


            foreach(int r in Lista)
            {
                Console.WriteLine(r);
            }

               
            Console.ReadKey();


            // cuarta lista, ejercicio :eliminar el numero 3 si existe un numero3

            List<int> NumerosLista = new List<int>();   

            bool encontrar = false;

            NumerosLista.Add(5);
            NumerosLista.Add(4);
            NumerosLista.Add(3);
            NumerosLista.Add(2);

            foreach (int numerito in NumerosLista) 
            {
                if (numerito == 3)
                {
                    encontrar = true;
                }

            }

            if (encontrar == true)
            {
                NumerosLista.Remove(3);  /// usamos el .Remove para eliminar un elemento en especifico, a diferencia del RemoveAt, el RemoveAt se refiere a posiciones y el Remove se refiere al elemento concretamente como tal
            }


            foreach (int numerito in NumerosLista)
            {
                Console.WriteLine(numerito);
            }





            Console.ReadKey();


        }
    }
}
