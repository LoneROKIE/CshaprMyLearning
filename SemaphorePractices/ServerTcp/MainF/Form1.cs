using Entidades;
using System.Configuration;
using System.Data.SqlClient;
using System.Net;
using System.Net.Sockets;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MainF
{
    public partial class Form1 : Form
    {
        public static TcpClient tcpClient;
        public static TcpListener tcpListener;
        // hilo
        public static Thread subprocesoEscuchaClientes;
        public static bool servIniciado = false;


        // creamos una cadena de conexion
        public static string cadena = ConfigurationManager.ConnectionStrings["CadenaConexion"].ConnectionString;
        public Form1()
        {
            InitializeComponent();
            // inicializamos el datagrid view con los valores de la DB
            dataGridView1.DataSource = ListarPersonas();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // obtenemos los valores para guardarlos en la DB
            int id = Convert.ToInt32(txtId.Text);
            string nombre = textNombre.Text;
            string apellido1 = textApellido1.Text;
            string apellido2 = textApellido2.Text;

            // creamos un objeto persona
            Persona persona = new Persona
            {
                id = id,
                nombre = nombre,
                apellido1 = apellido1,
                apellido2 = apellido2
            };
            try
            {

                using (SqlConnection connection = new SqlConnection(cadena))
                {
                    // abrimos conexion
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO persona(personaId,nombre,apellido1,apellido2)" +
                        " VALUES(@id,@nomb,@ap1,@ap2)", connection);
                    // PARAMETROS
                    cmd.Parameters.AddWithValue("@id", persona.id);
                    cmd.Parameters.AddWithValue("@nomb", persona.nombre);
                    cmd.Parameters.AddWithValue("@ap1", persona.apellido1);
                    cmd.Parameters.AddWithValue("@ap2", persona.apellido2);


                    // ejecutamos query
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Persona agregada con exito");


                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("PARECE QUE HUBO ALGUN ERROR: " + ex);

            }
            finally
            {
                dataGridView1.DataSource = ListarPersonas();
            }
        }

        // metodo para ver todas las personas en la DB
        public static List<Persona> ListarPersonas()
        {
            // creamos la lista
            List<Persona> personas = new List<Persona>();
            try
            {
                using (SqlConnection connection = new SqlConnection(cadena))
                {
                    // abrimos la  conexion
                    connection.Open();

                    SqlCommand cmd = new SqlCommand("SELECT * FROM persona", connection);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        // creamos un objeto persona
                        Persona persona = new Persona
                        {
                            id = reader.GetInt32(0),
                            nombre = reader.GetString(1),
                            apellido1 = reader.GetString(2),
                            apellido2 = reader.GetString(3)
                        };
                        personas.Add(persona);
                    }

                    // devolvemos la lista
                    return personas;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al intentar mostrar las personas: " + ex);
                return null;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ListarPersonas();
        }

        private void btnIniciarServ_Click(object sender, EventArgs e)
        {

        }


        // metodos del servidor
        
        // iniciar el servidor
        private static void IniciarServidor()
        {
            var ipEndPoint = new IPEndPoint(IPAddress.Any, 9999); // ipddress y port
            tcpClient = new(ipEndPoint);

            subprocesoEscuchaClientes = new Thread(new ThreadStart(EscuchaClientes));
            // inicia el subproceso
            subprocesoEscuchaClientes.Start();
            subprocesoEscuchaClientes.IsBackground = true;
        }

        private static void EscuchaClientes()
        {
            try
            {
                // iniciamos el tcp listener
                tcpListener.Start();

                while (servIniciado)
                {
                    // aceptamos los clientes
                    TcpClient cliente = tcpListener.AcceptTcpClient();
                    // hilo nuevo para manejar la comunicacion con los clientes que se conecten
                    Thread hiloCliente = new Thread(new ParameterizedThreadStart(ComunicacionCliente));
                    hiloCliente.Start(cliente);
                }


            }catch(Exception ex)
            {
                MessageBox.Show("Excepcion ocurrida al escuchar cliente: " + ex);
            }
        }

        private static void ComunicacionCliente(object Cliente)
        {

        }


    }
}
