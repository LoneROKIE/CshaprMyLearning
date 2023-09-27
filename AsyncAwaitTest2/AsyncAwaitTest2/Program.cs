// Ejemplo async y await

// creamos la clase principal
using System.Text;

public class Principal
{
    // metodo main
    public static async Task Main(string[] args)
    {
        await MetodoAsincrono1("Encender el sarten");
        await MetodoAsincrono2("Cortar los platanos");
        await MetodoAsincrono3("Poner aceite al sarten");
        await MetodoAsincrono4("Poner los platanos en sarten con aceite");
    }

    public static async Task MetodoAsincrono1(string tarea)
    {
       await Task.Delay(2000);
       Console.WriteLine("Tarea: "+tarea+", completada");
    }

    public static async Task MetodoAsincrono2(string tarea)
    {
        await Task.Delay(2500);
        Console.WriteLine("Tarea: " + tarea + ", completada");
    }

    public static async Task MetodoAsincrono3(string tarea)
    {
        await Task.Delay(3000);
        Console.WriteLine("Tarea: " + tarea + ", completada");
    }
    public static async Task MetodoAsincrono4(string tarea)
    {
        await Task.Delay(4000);
        Console.WriteLine("Tarea: " + tarea + ", completada");
    }

}