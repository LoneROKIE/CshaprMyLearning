// librerias para el uso de hilos
using System;
using System.Threading;

namespace Ejemplo01Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hilo version .Net6");

            // declaracion del hilo
            Thread hilo1;

            // instanciamos el hilo e indica el metodo que se ejecutara en el hilo
            hilo1 = new Thread(new ThreadStart(RealizarTarea));
            // ejecutamos el hilo
            hilo1.Start();

        }

        public static void RealizarTarea()
        {
            for(int i = 0; i < 50; i++)
            {
                Console.WriteLine("El valor de i es " + i.ToString());
            }
            Console.ReadLine();
        }


    }
}

