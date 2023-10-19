using System;
using System.Collections.Generic;
using System.Threading;

public class PrimoCalculator
{
    static List<int> numerosPrimos = new List<int>();
    static object lockObj = new object();

    static void Main(string[] args)
    {
        int inicioRango = 1;
        int finRango = 100;
        int numSubrangos = 4;

        List<Thread> hilos = new List<Thread>();

        int tamanoSubrango = (finRango - inicioRango + 1) / numSubrangos;

        for (int i = 0; i < numSubrangos; i++)
        {
            int inicioSubrango = inicioRango + i * tamanoSubrango;
            int finSubrango = inicioSubrango + tamanoSubrango - 1;

            Thread hilo = new Thread(() => EncontrarPrimosEnSubrango(inicioSubrango, finSubrango));
            hilos.Add(hilo);
            hilo.Start();
        }

        foreach (Thread hilo in hilos)
        {
            hilo.Join();
        }

        // Imprimir números primos encontrados
        Console.WriteLine("Números primos encontrados:");
        foreach (int primo in numerosPrimos)
        {
            Console.Write(primo + " ");
        }
    }

    static bool EsPrimo(int numero)
    {
        if (numero <= 1) return false;
        if (numero <= 3) return true;

        if (numero % 2 == 0 || numero % 3 == 0) return false;

        for (int i = 5; i * i <= numero; i += 6)
        {
            if (numero % i == 0 || numero % (i + 2) == 0)
                return false;
        }

        return true;
    }

    static void EncontrarPrimosEnSubrango(int inicio, int fin)
    {
        for (int numero = inicio; numero <= fin; numero++)
        {
            if (EsPrimo(numero))
            {
                lock (lockObj)
                {
                    numerosPrimos.Add(numero);
                }
            }
        }
    }
}
