public class Program
{
    private static Semaphore semaforo = new Semaphore(3, 3); // permite 3 hilos simultaneos

    static void Main(string[] args)
    {
        Console.WriteLine("Hilos con Mecanismo Semaphore");

        for (int i = 0; i < 250; i++)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Proceso {0} espera por el semaforo", i);
            Thread proceso = new Thread(new ParameterizedThreadStart(Procesar));
            proceso.Start(i);
        }
        Console.ReadLine();
    }

    private static void Procesar(object num)
    {
        semaforo.WaitOne(); // solicita el semaforo
        try
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Proceso {0} entra al semaforo", num);
            Thread.Sleep(1500);
        }
        finally
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Proceso {0} libera el semaforo", num);
            semaforo.Release(); // libera el semaforo
        }

    }


}