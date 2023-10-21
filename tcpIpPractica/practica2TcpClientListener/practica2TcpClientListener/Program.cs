// TCPListener

using System.Net;
using System.Net.Sockets;
using System.Text;

string serverHostName = "localhost";
IPHostEntry hostEntry = Dns.GetHostEntry(serverHostName);
IPAddress serverIpAddress = hostEntry.AddressList[0]; // Puedes seleccionar la dirección IP adecuada si hay múltiples direcciones

IPEndPoint ipEndPoint = new(serverIpAddress, 9999);

TcpListener listener = new(ipEndPoint);

try
{
    listener.Start();

    using TcpClient handler = await listener.AcceptTcpClientAsync();
    await using NetworkStream stream = handler.GetStream();

    var message = "Hola estas conectado al server tcp";
    var data = Encoding.UTF8.GetBytes(message);
    await stream.WriteAsync(data, 0, data.Length);

    Console.WriteLine("Mensaje enviado: {0}", message);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
    listener.Stop();
}