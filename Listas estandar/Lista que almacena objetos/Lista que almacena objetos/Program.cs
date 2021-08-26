using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_que_almacena_objetos
{
    class Program
    {

        static void Main(string[] args)
        {
            // adicionar a la lista de forma explicita diferentes objetos
            List<Coordenadas> milista = new List<Coordenadas>
            {
                new Coordenadas(4, 5),
                new Coordenadas(1, 9),
                new Coordenadas(3,8)

            };

            foreach (Coordenadas coo in milista)
            {
                Console.WriteLine(coo);
            }

              Console.ReadKey();
        }

    }


    class Coordenadas
    {
        private int x;
        private int y;

        public Coordenadas(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return string.Format("Coordenada {0}, {1}", x,y); 
        }

    }


}
