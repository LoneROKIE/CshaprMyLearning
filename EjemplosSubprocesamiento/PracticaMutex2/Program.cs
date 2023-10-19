using System;
using System.Threading;

public class Ejemplo
{
    // crear un nuevo mutex. El hilo que lo crea no es dueño del mutex.
    private static Mutex mut = new Mutex();
    private const int numIterations = 1;
    private const int numThreads = 3;

    public static void Main(string[] args)
    {
        // create the threads that will use the protected resource.
        for (int i = 0; i < numThreads; i++)
        {
            Thread newThread = new Thread(new ThreadStart(ThreadProc));
            newThread.Name = String.Format("Thread{0}", i + 1);
            newThread.Start(); // inicia el hilo
        }

        // The main thread exits, but the application continues to
        // run until all foreground threads have exited.

    }

    private static void ThreadProc()
    {
        for (int i = 0; i < numIterations; i++)
        {
            UseResource();
        }
    }

    // This method representz a resource that must be synchronized
    // so that only one thread at a time can enter.
    private static void UseResource()
    {
        // wait until it is safe to enter.
        Console.WriteLine("{0} is requesting the mutex", Thread.CurrentThread.Name);

        mut.WaitOne(); // bloquea el mutex

        Console.WriteLine("{0} has entered the protected area", Thread.CurrentThread.Name);

        // Place code to access non-reentrant resources here.

        // Simulate some work.
        Thread.Sleep(500);

        Console.WriteLine("{0} is leaving the protected area", Thread.CurrentThread.Name);

        // Release the Mutex.
        mut.ReleaseMutex(); // libera el mutex
        Console.WriteLine("{0} has released the mutex", Thread.CurrentThread.Name);

    }



}