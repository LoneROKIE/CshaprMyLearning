// esta es una practica para aprender bien los semaforos
using System;
using System.Threading; // importamos la clase muy importante

public class EjemploSemap
{
    // semaforo que simula una piscina de recursos
    private static Semaphore _pool;

    // padding interval para hacer que la salida se vea mejor ordenada
    private static int _padding;

    public static void Main() 
    {
        // semaforo max 3
        _pool = new Semaphore(initialCount: 0 , maximumCount: 3);

        // crea y inicia 5 hilos
        for(int i = 1; i<=5; i++)
        {
            Thread t = new Thread(new ParameterizedThreadStart(Worker));
            // EMPIEZA UN NUEVO HILO SEGUN EL INDX
            t.Start(i);
        }

        Thread.Sleep(500);

        Console.WriteLine("Main Thread calls Release(3)");
        _pool.Release(releaseCount: 3);

        Console.WriteLine("Main Thread exits");

    }
    // metodo worker
    private static void Worker(object num)
    {
        // each worker thread begins by requesting the 
        // semaphore
        Console.WriteLine("Thread {0} begins" + "and waits for the semaphore. ", num);

        _pool.WaitOne();

        // A padding interval to make the output more orderly
        int padding = Interlocked.Add(ref _padding, 100);

        Console.WriteLine("Thread {0} enters the semaphore.", num);

        // The thread's "work" consists of sleeping for 
        // about a second. Each thread "works" a little 
        // longer, just to make the output more orderly.
        //
        Thread.Sleep(1000 + padding);

        Console.WriteLine("Thread {0} releases the semaphore.", num);
        Console.WriteLine("Thread {0} previous semaphore count: {1}",
        num, _pool.Release());


    }

}

