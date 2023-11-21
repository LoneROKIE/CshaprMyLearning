using Microsoft.VisualBasic;
using Newtonsoft.Json;
using System.Net.Sockets;
using System.Text;

namespace PracticaTcpCliente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(Conectar);
            t.Start();
        }
        // metodo para conectarse al servidor y enviar mensajes
        private void Conectar()
        {
            using (TcpClient client = new TcpClient("localhost", 9999))
            using (NetworkStream n = client.GetStream())
            {
                string msg = textBox1.Text;

                // Envía la longitud de los datos
                byte[] msgLengthBytes = BitConverter.GetBytes(msg.Length);
                n.Write(msgLengthBytes, 0, 4);

                // Envía los datos
                byte[] msgBytes = Encoding.UTF8.GetBytes(msg);
                n.Write(msgBytes, 0, msgBytes.Length);

                // Recibe la longitud de los datos
                BinaryReader r = new BinaryReader(n);

                // Recibe los datos
                int dataLength = r.ReadInt32();
                byte[] dataBuffer = new byte[dataLength];
                r.Read(dataBuffer, 0, dataLength);
                string personaString = Encoding.UTF8.GetString(dataBuffer);

                Persona p = JsonConvert.DeserializeObject<Persona>(personaString);

                textBoxIdentificacion.Text = p.Identificacion.ToString();
                textBoxNombre.Text = p.Nombre;
                textBoxApe1.Text = p.Apellido1;
                textBoxApe2.Text = p.Apellido2;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonConsultarTodosLosClientes_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ConsultarTodasLasPersonas();
            
        }

        public List<Persona> ConsultarTodasLasPersonas()
        {
            // le solicitamos al servidor que nos envie las lista de Persona
            // para ello le enviamos el mensaje ConsultarTodosLosClientes
            // y el servidor nos envia la lista de Persona
            using (TcpClient client = new TcpClient("localhost", 9999))
            using (NetworkStream n = client.GetStream())
            {
                MensajesServidor<List<Persona>> mensajesServidor = new MensajesServidor<List<Persona>> { Metodo = "ConsultarClientes" };

                string msg = JsonConvert.SerializeObject(mensajesServidor);
                StreamWriter writer = new StreamWriter(n);
                writer.WriteLine(msg);
                writer.Flush();

                // Recibe la longitud de los datos
                BinaryReader r = new BinaryReader(n);

                // Recibe los datos
                int dataLength = r.ReadInt32();
                byte[] dataBuffer = new byte[dataLength];
                r.Read(dataBuffer, 0, dataLength);
                string personaString = Encoding.UTF8.GetString(dataBuffer);

                List<Persona> personas = JsonConvert.DeserializeObject<List<Persona>>(personaString);

                return personas;


            }
        }
    }

    // creamos la clae Persona
    public class Persona
    {
        public int Identificacion { get; set; }
        public string Nombre { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }

    }

}