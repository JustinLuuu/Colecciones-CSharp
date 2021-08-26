using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_practico_con_listas_y_metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            int contadorPares = 0;
            int contadorImpares = 0;

            List<int> listin = new List<int>();
            listin.Add(4);
            listin.Add(5);
            listin.Add(6);
            listin.Add(7);
            listin.Add(8);

            foreach (int number in listin)
            {
                clasecita.revisar(number, ref contadorPares, ref contadorImpares);
            }

            Console.WriteLine("Hay " + contadorPares + "pares");
            Console.WriteLine("Hay " + contadorImpares + "impares");



            Console.ReadKey();
        }
    }

    class clasecita
    {
        public static void revisar(int num, ref int contpar, ref int contIm)
        {
            if (num % 2 == 0)
            {
                contpar++;

            }

            else
            {
                contIm++;

            }

        }


    }

}
