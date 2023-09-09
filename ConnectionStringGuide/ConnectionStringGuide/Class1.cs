using System.Configuration;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace ConnectionStringGuide
{
    public class Class1
    {
        // funcion para abrir la conexion
        public void OpenSqlConnection()
        {
           string connectionString = GetConnectionString();

            using(SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = connectionString;

                // abrimos la conexion
                conn.Open();

                Console.WriteLine("State {0}", conn.State);
                Console.WriteLine("ConnectionString: {0}", conn.ConnectionString);

            }

        }

        public string GetConnectionString()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            return connectionString;
        }
        
    }
}