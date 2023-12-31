﻿using System.Net;
using System.Net.Sockets;
using System.Text;

string serverHostName = "localhost";
IPHostEntry hostEntry = Dns.GetHostEntry(serverHostName);
IPAddress serverIpAddress = hostEntry.AddressList[0]; // Puedes seleccionar la dirección IP adecuada si hay múltiples direcciones

IPEndPoint ipEndPoint = new(serverIpAddress, 9999);

using Socket client = new(
    ipEndPoint.AddressFamily,
    SocketType.Stream,
    ProtocolType.Tcp);

await client.ConnectAsync(ipEndPoint);
while (true)
{
    // send message
    var message = "Hi friends 👋!<|EOM|>";
    var messageBytes = Encoding.UTF8.GetBytes(message);
    _ = await client.SendAsync(messageBytes,SocketFlags.None);

    Console.WriteLine($"Socket client sent message: \"{message}\"");

    // Receive ack
    var buffer = new byte[1_024];
    var received = await client.ReceiveAsync(buffer,SocketFlags.None);
    var response = Encoding.UTF8.GetString(buffer,0,received);

    if(response == "<|ACK|>")
    {
        Console.WriteLine( $"Socket client received acknowledgment: \"{response}\"");
        break;
    }

    // Sample output:
    //     Socket client sent message: "Hi friends 👋!<|EOM|>"
    //     Socket client received acknowledgment: "<|ACK|>"

}

client.Shutdown(SocketShutdown.Both);
