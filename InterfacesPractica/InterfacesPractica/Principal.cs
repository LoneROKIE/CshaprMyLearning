using InterfacesPractica;
using System;

public class Principal
{
    public static void Main(string[] args)
    {
        // hacemos uso de la interfaz
        var vehiculo1 = new Automovil();
        var vehiculo2 = new Motocicleta();

        Console.WriteLine("Vehiculo 1");

        vehiculo1.Arrancar();
        vehiculo1.Acelerar();
        vehiculo1.Frenar();
        vehiculo1.Detener();

        Console.WriteLine("Vehiculo 2");

        vehiculo2.Arrancar();
        vehiculo2.Acelerar();
        vehiculo2.Frenar();
        vehiculo2.Detener();
        

    }
}