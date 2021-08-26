using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace probando
{
    class Program    
    {
        static void Main(string[] args) 
        {
            
            int contador = 0;

            List<Usuario> lista = new List<Usuario>();

            Usuario user1 = new Usuario();
            user1.NOMBRE = "Justin";
            user1.NACIONALIDAD = "Dominicano";
            user1.EDAD = 18;

            Usuario user0 = new Usuario();
            user0.NOMBRE = "Justin";
            user0.NACIONALIDAD = "Dominicano";
            user0.EDAD = 18;

            Usuario user2 = new Usuario();
            user2.NOMBRE = "Donald";
            user2.NACIONALIDAD = "Hungaro";
            user2.EDAD = 70;

            lista.Add(user1);
            lista.Add(user2);
            lista.Add(user0);

            foreach (Usuario us in lista)
            {
                ContarMiNombre(us, ref contador);
            }

            Console.WriteLine("Solo se repitio tu nombre {0} veces en el listado de clientes ", contador);

            Console.ReadKey();
        }

        static void ContarMiNombre(Usuario user, ref int contando)
        {
            if(user.NOMBRE == "Justin")
            {
                contando++;
            }    
        }

    }


    class Usuario
    {
        public string NOMBRE { get; set; }
        public string NACIONALIDAD { get; set; }
        public int EDAD { get; set; }


    }

}
