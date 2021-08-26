using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_con_objetos
{
    class Program
    {
        public static void Main()
        {
         
            // Crear un diccionario, CustomerID es la clave. El tipo es int
            // El objeto del cliente es el valor. El tipo es cliente
            Dictionary<int, Customer> dictionaryCustomers = new Dictionary<int, Customer>();

            // Crear objetos de cliente
            Customer customr1 = new Customer()
            {
                ID = 101,
                Name = "Mark",
                Salary = 5000
            };


            Customer customr2 = new Customer()
            {
                ID = 102,
                Name = "Pam",
                Salary = 7000
            };


            Customer customr3 = new Customer()
            {
                ID = 104,
                Name = "Rob",
                Salary = 5500
            };


            // Agregar objetos de cliente al diccionario
            dictionaryCustomers.Add(customr1.ID, customr1);
            dictionaryCustomers.Add(customr2.ID, customr2);
            dictionaryCustomers.Add(customr3.ID, customr3);


            // Recuperar el valor (objeto Cliente) del diccionario,
            // usando clave (ID de cliente). La forma más rápida de obtener un valor
            // del diccionario está usando su clave
            Console.WriteLine("Customer 101 in customer dictionary");
            Customer customer101 = dictionaryCustomers[101];
            Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}",
                            customer101.ID, customer101.Name, customer101.Salary);
            Console.WriteLine("--------------------------------------------------");


            // También es posible recorrer cada par clave / valor en un diccionario
            Console.WriteLine("All customer keys and values in customer dictionary");
            foreach (KeyValuePair<int, Customer> customerKeyValuePair in dictionaryCustomers)
            {
                Console.WriteLine("Key = " + customerKeyValuePair.Key);
                Customer cust = customerKeyValuePair.Value;
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cust.ID, cust.Name, cust.Salary);
            }
            Console.WriteLine("--------------------------------------------------");


            // También puede usar la variable VAR implícitamente escrita para
            // recorrer cada par clave / valor en un diccionario. Pero intenta
            // para evitar usar var, ya que esto hace que su código sea menos legible
            Console.WriteLine("All customer keys and values in customer dictionary");
            foreach (var customerKeyValuePair in dictionaryCustomers)
            {
                Console.WriteLine("Key = " + customerKeyValuePair.Key);
                Customer cust = customerKeyValuePair.Value;
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cust.ID, cust.Name, cust.Salary);
            }
            Console.WriteLine("--------------------------------------------------");

            // To get all the keys in the dictionary
            Console.WriteLine("All Keys in Customer Dictionary");
            foreach (int key in dictionaryCustomers.Keys)
            {
                Console.WriteLine(key);
            }
            Console.WriteLine("--------------------------------------------------");

            // Para obtener todas las claves en el diccionario
            Console.WriteLine("All Customer objects in Customer Dictionary");
            foreach (Customer customer in dictionaryCustomers.Values)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", customer.ID, customer.Name, customer.Salary);
            }

            // Si intenta agregar una clave que ya existe en el diccionario,
            // obtendrá una excepción: un elemento con la misma clave ya ha sido
            // adicional. Entonces, verifique si la clave ya existe
            if (!dictionaryCustomers.ContainsKey(101))
            {
                dictionaryCustomers.Add(101, customr1);
            }

            // Al acceder a un valor de diccionario por clave, asegúrese de que el diccionario
            // contiene la clave, de lo contrario obtendrá la excepción KeyNotFound.
            if (dictionaryCustomers.ContainsKey(110))
            {
                Customer cus = dictionaryCustomers[110];
            }
            else
            {
                Console.WriteLine("Key does not exist in the dictionary");
            }
        }
    }

    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }

}



