public class Program
{
    private static Mutex mutex = new Mutex();

    static void Main(string[] args)
    {
        Console.WriteLine("Hilos con Mecanismo Mutex");

        for(int i= 1; i <= 250; i++)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Proceso {0} espera por el MUTEX", i);
            Thread proceso = new Thread(new ParameterizedThreadStart(Procesar));
            // inicio del proceso
            proceso.Start(i);
        }
        Console.ReadLine();
    }

    private static void Procesar(object num)
    {
        mutex.WaitOne(); // espera a que el mutex este libre
        try
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Proceso {0} entra al mutex.", num);
            Thread.Sleep(1500);
        }
        finally
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Proceso {0} libera el mutex.", num);
            mutex.ReleaseMutex(); // libera el mutex
        }
    }


}