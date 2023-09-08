using Clases;
using Herencia_Practicas;
using System;


public class PruebaHerencia
{
    public static void Main(string[] args)
    {
        // creamos un objeto de la clase Motocicleta
        Motocicleta moto = new Motocicleta("Honda", "Titan", 125);

        // creamos un objeto de la clase Automovil
        Vehiculo auto = new Vehiculo("Peugeot", "206");

        // mostramos los datos de los objetos
        Console.WriteLine(moto.ToString());
        Console.WriteLine(auto.ToString());
    }
}