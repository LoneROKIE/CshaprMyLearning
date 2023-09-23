// delegados, func y action
public class Programa
{
    public delegate void Mostrar(string cadena);

    public static void Informacion(string cad)
    {
        Console.WriteLine("Hola esta es una cadena informativa: " + cad);
    }

    public static void HacerAlgo(Mostrar funcionaFinal)
    {
        funcionaFinal("Estamos usando un delegado");
    }


    public static void Main(string[] args)
    {
        Mostrar mostrar = Informacion;
        HacerAlgo(mostrar);
    }
}