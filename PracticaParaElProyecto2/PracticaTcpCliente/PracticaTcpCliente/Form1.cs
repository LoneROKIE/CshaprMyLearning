using Microsoft.VisualBasic;
using System.Net.Sockets;

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
                    
                    string msg = textBox1.Text; // mensaje a enviar
                    BinaryWriter w = new BinaryWriter(n);
                    w.Write(msg);
                    w.Flush();
                    Console.WriteLine("Mensaje enviado");


                   
                }
            
        }
    }
}