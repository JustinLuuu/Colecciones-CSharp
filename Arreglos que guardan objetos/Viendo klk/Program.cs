using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Viendo_klk
{

    public enum Categorias { PREMIUM, NORMAL};  // para el manejo de constantes 

    class Program
    {
        static void Main(string[] args)
        {            
            Empleados[] emp = new Empleados[4];

            emp[0] = new Empleados("Carlos", Categorias.PREMIUM);
            emp[1] = new Empleados("Bernardo", Categorias.NORMAL);
            emp[2] = new Empleados("Alejandro", Categorias.NORMAL);
            emp[3] = new Empleados("Valentino", Categorias.PREMIUM);


            for (int i = 0; i < emp.Length; i++)
            {
                (string nombreEmpleado, double salario) = emp[i].cobro();
             
                Console.WriteLine("El empleado {0} tiene un cobro de {1} ", nombreEmpleado, salario + "\n");
                Console.WriteLine("----------------------------------------------------------------------\n");
            }


            Console.ReadKey();
        } 
    }


    class Empleados
    {
        private string nombre;
        private string categoria;
        private const double salario = 1.500;

        public Empleados(string nombreCli, Categorias categoriaCli)
        {
             NOMBRE = nombreCli;
            CATEGORIA = categoriaCli.ToString();  
        }

        public string NOMBRE
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string CATEGORIA
        {
            get { return categoria; }
            set { categoria = value; }
        }


        public (string, double) cobro()
        {
            if(CATEGORIA == "PREMIUM")
            {
                return (NOMBRE, salario * 70);
            }

            else
            {
                return (NOMBRE, salario * 30);
            }

        }


    }
              
}
