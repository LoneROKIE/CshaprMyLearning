using System;
using System.Threading;

class Program
{
    public static void Main(string[] args)
    {
        Thread t = new Thread(new ThreadStart(MetodoThread));
        t.Start(); 
        for(int i = 0; i<5; i++)
        {
            Console.WriteLine("Hilo del Main {0}",i);
            Thread.Sleep(1000);
        }
        t.Join();
        Console.ReadLine();
    }

    public static void MetodoThread()
    {
        for(int i = 0; i<10; i++)
        {
            Console.WriteLine("Hilo del metodo: {0}",i);
            Thread.Sleep(1000);
        }
    }
}