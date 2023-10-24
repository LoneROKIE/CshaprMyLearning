using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;

new Thread (Server).Start ();
Thread.Sleep (500);
Client();
new Thread(Server).Start();
Thread.Sleep(500);
Client2();
void Client()
{
    using (TcpClient client = new TcpClient("localhost", 9999))
    using (NetworkStream n = client.GetStream())
    {
        BinaryWriter w = new BinaryWriter(n);
        w.Write("Hola");
        w.Flush(); // Envia el mensaje
        Console.WriteLine(new BinaryReader(n).ReadString());
    }
}

void Client2()
{
    using (TcpClient client = new TcpClient("localhost", 9999))
    using (NetworkStream n = client.GetStream())
    {
        BinaryWriter w = new BinaryWriter(n);
        w.Write("Hola SOY EL 2");
        w.Flush(); // Envia el mensaje
        Console.WriteLine(new BinaryReader(n).ReadString()); // lee el mensaje del servidor
    }
}


void Server()
{
    TcpListener listener = new TcpListener (IPAddress.Any, 9999);
    listener.Start ();
    using (TcpClient c = listener.AcceptTcpClient ())
    using (NetworkStream n = c.GetStream())
    {
        string msg = new BinaryReader(n).ReadString();
        BinaryWriter w = new BinaryWriter(n);
        w.Write(msg + " Right back !");
        w.Flush(); // Envia el mensaje
    }
    listener.Stop ();
}
