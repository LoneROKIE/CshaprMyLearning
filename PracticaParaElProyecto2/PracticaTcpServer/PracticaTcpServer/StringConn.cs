using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaTcpServer
{
    public class StringConn
    {
        private static string GetConnectionString()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["myconnectionstring"].ConnectionString;
            return connectionString;
        }

        // metodo para guardar una persona en la base de datos
        public static void SavePerson(int identificacion, string nombre, string apellido1, string apellido2)
        {
            // se crea un objeto de la clase SqlConnection
            using SqlConnection conn = new SqlConnection(GetConnectionString());
            // se crea un objeto de la clase SqlCommand
            using SqlCommand cmd = new SqlCommand("INSERT INTO persona(identificacion,nombre,apellido_1,apellido_2) " +
                "VALUES(@identificacion, @nombre, @apellido1, @apellido2)", conn);
            // se agregan los parametros
            cmd.Parameters.AddWithValue("@identificacion", identificacion);
            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Parameters.AddWithValue("@apellido1", apellido1);
            cmd.Parameters.AddWithValue("@apellido2", apellido2);
            // se abre la conexion
            conn.Open();
            // se ejecuta el comando
            cmd.ExecuteNonQuery();
            // se cierra la conexion
            conn.Close();
        }

        // metodo para listar las personas de la base de datos ademas de que devuelve una lista de personas
        public static List<Persona> GetPersonas()
        {
            // se crea un objeto de la clase SqlConnection
            using SqlConnection conn = new SqlConnection(GetConnectionString());
            // se crea un objeto de la clase SqlCommand
            using SqlCommand cmd = new SqlCommand("SELECT * FROM persona", conn);
            // se crea un objeto de la clase List<Persona>
            List<Persona> personas = new List<Persona>();
            // se abre la conexion
            conn.Open();
            // se crea un objeto de la clase SqlDataReader
            using SqlDataReader reader = cmd.ExecuteReader();
            // ciclo para recorrer los registros
            while (reader.Read())
            {
                // se crea un objeto de la clase Persona
                Persona persona = new Persona();
                // se asignan los valores a los atributos del objeto persona
                persona.Identificacion = reader.GetInt32(0);
                persona.Nombre = reader.GetString(1);
                persona.Apellido1 = reader.GetString(2);
                persona.Apellido2 = reader.GetString(3);
                // se agrega el objeto persona a la lista personas
                personas.Add(persona);
            }
            // se cierra la conexion
            conn.Close();
            // se retorna la lista personas
            return personas;
        }

        // metodo para buscar una persona por identificacion
        public static Persona GetPersona(int identificacion)
        {
            // se crea un objeto de la clase SqlConnection
            using SqlConnection conn = new SqlConnection(GetConnectionString());
            // se crea un objeto de la clase SqlCommand
            using SqlCommand cmd = new SqlCommand("SELECT * FROM persona WHERE identificacion = @identificacion", conn);
            // se agregan los parametros
            cmd.Parameters.AddWithValue("@identificacion", identificacion);
            // se abre la conexion
            conn.Open();
            // se crea un objeto de la clase SqlDataReader
            using SqlDataReader reader = cmd.ExecuteReader();
            // se crea un objeto de la clase Persona
            Persona persona = new Persona();
            // se recorre el registro
            while (reader.Read())
            {
                // se asignan los valores a los atributos del objeto persona
                persona.Identificacion = reader.GetInt32(0);
                persona.Nombre = reader.GetString(1);
                persona.Apellido1 = reader.GetString(2);
                persona.Apellido2 = reader.GetString(3);
            }
            // se cierra la conexion
            conn.Close();
            // se retorna el objeto persona
            return persona;
        }

    }

    // clase persona
    public class Persona
    {
        public int Identificacion { get; set; }
        public string Nombre { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }

    }
}
