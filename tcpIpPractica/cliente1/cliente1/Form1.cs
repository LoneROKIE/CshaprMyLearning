using System.Net;
using System.Net.Sockets;

namespace cliente1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        // metodo para enviar mensaje
        private void EnviarMensaje()
        {
            // creamos un socket
            Socket miSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            // creamos un punto de conexion
            IPEndPoint miEndPoint = new IPEndPoint(IPAddress.Parse(""))
        }

    }
}