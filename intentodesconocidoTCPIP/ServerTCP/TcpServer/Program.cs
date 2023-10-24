// este va a ser el servidor al que se conectaran los clientes
// para enviarse mensajes entre ellos


using System.Net;
using System.Net.Sockets;
using System.Text;

IPHostEntry ipHostInfo = await Dns.GetHostEntryAsync("localhost");
IPAddress ipAddress = ipHostInfo.AddressList[0];
IPEndPoint localEndPoint = new IPEndPoint(ipAddress, 9999);


TcpListener server = new TcpListener(localEndPoint);
try
{
    server.Start(); // empezamos a escuchar
    while (true)
    {
        using TcpClient client = await server.AcceptTcpClientAsync(); // aceptamos la conexion
        using NetworkStream stream = client.GetStream(); // obtenemos el stream de la conexion
        byte[] buffer = new byte[1024]; // creamos un buffer para leer los datos
        int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length); // leemos los datos
        string dataReceived = Encoding.ASCII.GetString(buffer, 0, bytesRead); // convertimos los datos a string
        Console.WriteLine($"Received: {dataReceived}"); // mostramos los datos recibidos

        
    }
}
catch (Exception e)
{
    Console.WriteLine(e.ToString());
}
