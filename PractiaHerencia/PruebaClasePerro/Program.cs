

using ClasesPracticaHerencia;

public class PruebaClasePerro
{
    public static void Main(string[] args)
    {

       

        Perro perro = new Perro("mamifero", "Firulais", "Pastor Aleman", "Cafe", "Grande");

        perro.Sonido("guau guau");

        Console.WriteLine(perro);

        perro.EsDomestico("si");

    }
}
