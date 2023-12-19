

public class Program
{
    public delegate  void MiDelegado(string msj);
   
    public static void Main(string[] args)
    {
        MiDelegado delegado = new MiDelegado(imprimir);
        HacerAlgo(delegado, "Hola este es un delegado");

        Console.ForegroundColor = ConsoleColor.Red;
        HacerAlgo(imprimir,"ConsoleColor ahora es red");

        Console.ForegroundColor = ConsoleColor.Green;
        HacerAlgo(imprimir, "ConsoleColor ahora es green");

        Console.ForegroundColor = ConsoleColor.Blue;
        HacerAlgo(imprimir, "ConsoleColor ahora es blue");

        Console.ForegroundColor = ConsoleColor.Yellow;
        HacerAlgo(imprimir, "ConsoleColor ahora es yellow");

        Console.ReadKey();
    }

    public static void HacerAlgo(MiDelegado delegado,string mensaje)
    {
        delegado(mensaje);
    }

    public static void imprimir(string msj)
    {
        Console.WriteLine(msj);
    }

}

