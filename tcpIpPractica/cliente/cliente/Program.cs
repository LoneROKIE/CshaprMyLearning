// TcpCliente

using System.Net;
using System.Net.Sockets;
using System.Text;

string serverHostName = "localhost";
IPHostEntry hostEntry = Dns.GetHostEntry(serverHostName);
IPAddress serverIpAddress = hostEntry.AddressList[0]; // Puedes seleccionar la dirección IP adecuada si hay múltiples direcciones

IPEndPoint ipEndPoint = new(serverIpAddress, 9999);

using TcpClient client = new();

await client.ConnectAsync(ipEndPoint);

await using NetworkStream stream = client.GetStream();

var buffer = new byte[1024];
int received = await stream.ReadAsync(buffer);

var message = Encoding.UTF8.GetString(buffer, 0, received);
Console.Write($"Mensaje recibido: {message}");


