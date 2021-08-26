using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Dictionary_usos
{
    class Program
    {
       private static Dictionary<int, string> miDic;  // Dictionary tiene una forma muy particular de guardar informacion, ya que almacena tipo clave-valor
       
        static void Main(string[] args)
        {
            miDic = new Dictionary<int, string>();
                
            SqlConnection con;
            int key;
            string value;

            con = RecibirConexion(); 

            con.Open();

            SqlCommand comando = new SqlCommand("Select IdProducto, Nombre from dbo.Producto", con);
            SqlDataReader lector = comando.ExecuteReader();

            while (lector.Read())
            {
                key = Convert.ToInt32(lector["IdProducto"]);
                value = lector["Nombre"].ToString();
                miDic.Add(key, value);
            }

            con.Close();
            
           
            foreach (KeyValuePair<int, string> item in miDic)
            {
                Console.WriteLine(@"Id : {0}  \\  Producto : {1} ", item.Key, item.Value);
            }


            string val;
            miDic.TryGetValue(38, out val);  // forma de conseguir elemento

            Console.WriteLine(val);
            Console.ReadKey();
        }


        // SqlConnectionStringBuilder se puede utilizar para construir una cadena de conexion que pueda establecer una comunicacion
        // directa al servidor y a su vez a la base de datos

        private static SqlConnection RecibirConexion()
        {
            SqlConnectionStringBuilder cadenaConexion = new SqlConnectionStringBuilder();
            cadenaConexion.DataSource = "localhost\\SQLEXPRESS";
            cadenaConexion.InitialCatalog = "proyecto_SistemaFacturacion";
            cadenaConexion.IntegratedSecurity = true;

            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = cadenaConexion.ConnectionString;

            return conexion;
        }

 
    }
  
}
