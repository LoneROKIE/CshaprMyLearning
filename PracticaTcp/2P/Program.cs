using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;

/*
 * Voy a crear un pequenio programita que permita a un cliente conectarse a un servidor
 * y que el cliente pueda enviar mensajes al servidor y el servidor pueda responderle.
 */

new Thread(Servidor).Start();
Thread.Sleep(500);
Cliente();

void Servidor()
{
    TcpListener listener = new TcpListener(IPAddress.Any, 9999);
    try
    {
        Console.WriteLine("Escuchando en el puerto 9999...");
        listener.Start();

        while (true)
        {
            using (TcpClient client = listener.AcceptTcpClient())
            using (NetworkStream n = client.GetStream())
            {
                string msg = new BinaryReader(n).ReadString();
                Console.WriteLine("Mensaje recibido: " + msg);
                if (msg == "exit")
                {
                    Console.WriteLine("Cerrando servidor...");
                    listener.Stop();
                    break; // Sal del bucle
                }
                else if (msg == "hola")
                {
                    BinaryWriter w = new BinaryWriter(n);
                    w.Write("Hola, soy el servidor");
                    w.Flush();
                }
                else if (msg == "como estas ?")
                {
                    BinaryWriter w = new BinaryWriter(n);
                    w.Write("Bien, gracias por preguntar");
                    w.Flush();
                }
                else
                {
                    BinaryWriter w = new BinaryWriter(n);
                    w.Write("No entiendo tu mensaje perdon");
                    w.Flush();
                }
            }
        }
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}

void Cliente()
{
    while (true)
    {
        using (TcpClient client = new TcpClient("localhost", 9999))
        using (NetworkStream n = client.GetStream())
        {
            Console.Write("Mensaje Para el servidor: ");
            string msg = Console.ReadLine();
            BinaryWriter w = new BinaryWriter(n); 
            w.Write(msg);
            w.Flush();
            Console.WriteLine("Mensaje enviado");

            if (msg == "exit")
            {
                Console.WriteLine("Cerrando cliente...");
                break; // Sal del bucle
            }

            Console.WriteLine(new BinaryReader(n).ReadString()); // lee el mensaje del servidor
        }
    }
}
