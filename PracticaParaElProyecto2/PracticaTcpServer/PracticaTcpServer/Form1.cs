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
           Thread th =  new Thread(EncenderServidor);
            th.Start();
        }

        // metodo para encender el servidor y escuchar peticiones
        private async void EncenderServidor()
        {
          
            try
            {
                // se crea un objeto de la clase TcpListener
                TcpListener servidor = new TcpListener(IPAddress.Any, 9999);
                servidor.Start(); // se inicia el servidor
                // ciclo infinito para escuchar peticiones
                while (true)
                {
                    using TcpClient client = await servidor.AcceptTcpClientAsync(); // acepta la peticion
                    richTextBox1.AppendText("Cliente conectado" + Environment.NewLine);
                    using NetworkStream stream = client.GetStream(); // obtiene el flujo de datos
                    // que es el flujo de datos ?
                    // es un flujo de datos que se envia y recibe por medio de la red 
                    // es decir, es un flujo de datos que se envia y recibe por medio de internet

                    // buffer para almacenar los datos que envia el cliente
                    byte[] buffer = new byte[1024]; // buffer para almacenar los datos que envia el cliente
                    int byteLeidos = await stream.ReadAsync(buffer, 0, buffer.Length); // lee los datos que envia el cliente

                    // se crea un objeto de la clase StreamReader para leer los datos que envia el cliente
                    using StreamReader reader = new StreamReader(stream);

                    // convertimos los datos que envia el cliente a string
                    string dataReceived = Encoding.ASCII.GetString(buffer, 0, byteLeidos);

                    // usamos los datos que envia el cliente
                    richTextBox1.AppendText("Cliente dice: " + dataReceived + Environment.NewLine);

                }

            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}