
using System;
using System.Threading;

public class Practica2
{

    public static Semaphore semaf; // declaramos el semaforo

    public static void Main(string[] args) 
    {
        // terminamos de definir el semaforo
        semaf = new Semaphore(1, 3);

        // llamamos al metodo hilos
        Hilos();

        Thread.Sleep(1000);
    }

    public static void Hilos()
    {
        // seria los hilos
        for(int i=0; i<10; i++)
        {
            Thread thread = new Thread(new ParameterizedThreadStart(Invitados));
            thread.Start(i);

        }
    }

    public static void Invitados(object args)
    {
        // espera que un invitado entre y es liberado
        Console.WriteLine("Invitado {0} esta esperando para entrar...",args);
        semaf.WaitOne(); // espera 1 campo

        // hace algo una vez entra
        Console.WriteLine("Invitado {0} ya entro y hace algo.....", args);
        Thread.Sleep(1000); // hace algo por un 1 sec

        // invitado ya se va
        Console.WriteLine("Invitado {0} ya se va.....", args);
        semaf.Release(1); // libera 1 inv




    }


}