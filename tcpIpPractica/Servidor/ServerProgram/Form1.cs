using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ServerProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEncenderApagarServidor_Click(object sender, EventArgs e)
        {
            try
            {
                ServidorEncendido();
                label2.Text = "Servidor encendido";
                btnEncenderApagarServidor.Text = "Apagar servidor";
            }
            catch (Exception ex)
            {
                label2.Text = "Servidor apagado";
                MessageBox.Show(ex.Message);
                btnEncenderApagarServidor.Text = "Encender servidor";
            }
        }

        // metodo para cuando se enciende el servidor
        private async void ServidorEncendido()
        {
            string serverHostName = "localhost";
            IPHostEntry hostEntry = Dns.GetHostEntry(serverHostName);
            IPAddress serverIpAdress = hostEntry.AddressList[0];

            IPEndPoint ipEndPoint = new(serverIpAdress, 9999);// esto es la ip y el puerto

            // Esto es para escuchar las peticiones que llegan al servidor
            using Socket listener = new(
                ipEndPoint.AddressFamily,
                SocketType.Stream,
                ProtocolType.Tcp);

            listener.Bind(ipEndPoint);
            listener.Listen(100);

            var handler = await listener.AcceptAsync();

            while (true)
            {
                // recibe los datos del cliente para enviarlos 
                // al otro cliente
                byte[] buffer = new byte[1024];
                int bytesRec = handler.Receive(buffer);
                string data = Encoding.ASCII.GetString(buffer, 0, bytesRec);

                // envia los datos al otro cliente
                byte[] msg = Encoding.ASCII.GetBytes(data);
                handler.Send(msg);

                // muestra los datos en el servidor
                richTextBox1.Text += data + "\r\n";

            }
        }

    }
}