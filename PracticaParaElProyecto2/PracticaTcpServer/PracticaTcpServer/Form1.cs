using Newtonsoft.Json;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace PracticaTcpServer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
        }



        private void btnEncender_Click(object sender, EventArgs e)
        {
            //Thread th = new Thread(EncenderServidor);
            //th.Start();
        }

        // metodo para encender el servidor y escuchar peticiones
        /* private async void EncenderServidor()
         {
             try
             {
                 TcpListener servidor = new TcpListener(IPAddress.Any, 9999);
                 servidor.Start();

                 while (true)
                 {
                     using TcpClient client = await servidor.AcceptTcpClientAsync();
                     richTextBox1.AppendText("Cliente conectado" + Environment.NewLine);

                     using NetworkStream stream = client.GetStream();

                     byte[] buffer = new byte[4]; // Para leer la longitud de los datos
                     int bytesRead = await stream.ReadAsync(buffer, 0, 4);
                     int dataLength = BitConverter.ToInt32(buffer, 0);

                     buffer = new byte[dataLength]; // Para leer los datos
                     bytesRead = await stream.ReadAsync(buffer, 0, dataLength);
                     string dataReceived = Encoding.UTF8.GetString(buffer);

                     //int identificacion = int.Parse(dataReceived);

                     // Simula obtener la información de la base de datos
                    // Persona persona = new Persona();
                   //  persona = StringConn.GetPersona(identificacion);

                    // string personaString = JsonConvert.SerializeObject(persona);

                   //  buffer = Encoding.UTF8.GetBytes(personaString);

                     // Envía la longitud de los datos
                  //   await stream.WriteAsync(BitConverter.GetBytes(buffer.Length), 0, 4);

                     // Envía los datos
                  //   await stream.WriteAsync(buffer, 0, buffer.Length);

                     richTextBox1.AppendText("Datos enviados al cliente" + Environment.NewLine);
                 }
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }
       }*/

        // encender el servidor y escuchar peticiones
        private async void EncenderServer()
        {
            IPAddress iPAddress = IPAddress.Parse("127.0.0.1");
            TcpListener server = new TcpListener(iPAddress, 9999);
            server.Start();


        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // cargamos el datagridview con los datos de la base de datos
            dataGridView1.DataSource = StringConn.GetPersonas();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // obtenemos los valores de los textbox
            int identificacion = int.Parse(textBoxIdentificacion.Text);
            string nombre = textBoxNombre.Text;
            string apellido1 = textBoxApellido1.Text;
            string apellido2 = textBoxApellido2.Text;

            // guardamos la persona en la base de datos
            StringConn.SavePerson(identificacion, nombre, apellido1, apellido2);
            // mostramos un mensaje
            MessageBox.Show("Persona guardada en la base de datos");

            dataGridView1.DataSource = StringConn.GetPersonas(); // actualizamos el datagridview
            
        }
    }
}