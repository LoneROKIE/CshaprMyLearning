
public class Principal
{
    public static void Main(string[] args)
    {
       // creo una lista de palabras
       List<string> palabras = new List<string>();

       // creo un hilo que se va a encargar de pedir las palabras 
       Thread hilo1 = new Thread(() => PidePalabra(palabras));
       // creo un segundo hilo que se va a encargar de imprimir las palabras
       Thread hilo2 = new Thread(() => ImprimePalabras(palabras));
        
        // comenzamos los hilos
        hilo1.Start();
        hilo1.Join();
        hilo2.Start();
        //hilo2.Join();
      
   
   
    }

    public static void PidePalabra(List<string> palabras)
    {
       
        for (int i = 0; i < 5; i++) 
        { 
            Console.WriteLine("Digite una palabra");
            string palabra = Console.ReadLine();
            // add palabra en palabras
            palabras.Add(palabra);
        }
    }

    public static void ImprimePalabras(List<string> palabras)
    {
        foreach (string palabra in palabras) { Console.WriteLine("Imprimiendo la palabra {0}",palabra); }
      //  Console.ReadLine();
    }


}