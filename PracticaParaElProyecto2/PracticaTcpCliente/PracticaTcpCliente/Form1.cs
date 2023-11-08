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

                BinaryReader r = new BinaryReader(n);

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