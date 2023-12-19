using System.Data.SqlClient;

/*
 * En este ejemplo vamos a usar ADO.Net
 */

namespace CRUDCORE.Data
{
    public class Conexion
    {
        private string ConnectionString = string.Empty;

        public Conexion()
        {
            var builder = new ConfigurationBuilder().
                SetBasePath(Directory.GetCurrentDirectory()).
                AddJsonFile("appsettings.json").Build();

            ConnectionString = builder.GetSection("ConnectionStrings:CadenaSQL").Value;
        }

        public string getCadenaSql()
        {
            return ConnectionString;
        }
    }
}
