
public class Program
{
    static int acumulador = 0;
    static object procesoMutuo = new object();

    static void Main(string[] args)
    {
        Console.WriteLine("Hilo con prioridad");

        Thread threadHighest = new Thread(new ThreadStart(AcumulaPositivo));
        Thread threadLowest = new Thread(new ThreadStart(AcumulaNegativo));
        threadHighest.Priority = ThreadPriority.Highest;
        threadLowest.Priority = ThreadPriority.Lowest;

        threadHighest.Start();
        threadLowest.Start();

        Console.ReadLine();
    }

    static void AcumulaPositivo()
    {
        lock (procesoMutuo)
         {
         
        for(int i = 1; i <= 100; i++)
        {
            MetodoAcumulador(true);
            Console.WriteLine(acumulador);
        }
         }
    }

    static void AcumulaNegativo()
    {
        lock (procesoMutuo)
        {
     
        for(int i = 1; i <= 100; i++)
        {
            MetodoAcumulador(false);
            Console.WriteLine(acumulador);
        }
         }
    }

    static void MetodoAcumulador(bool pEsSuma)
    {
        if(pEsSuma)
            acumulador++;
        else
            acumulador--;
    }

}