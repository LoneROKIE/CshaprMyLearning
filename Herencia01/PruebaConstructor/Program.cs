// FIG. 10.18: PruebaConstructor.cs
// Muestra el orden en el que se llaman los constructores de la clase base y la clase derivada.

using EPM;
using System;

public class PruebaConstructor
{
    public static void Main(string[] args)
    {
        EmpleadoPorComision4 empleado1 = new EmpleadoPorComision4("Bob", "Lewis", "333-33-3333", 5000.00M, .04M);

        Console.WriteLine(); // imprime una linea en blanco
        EmpleadoBaseMasComision5 empleado2 = new EmpleadoBaseMasComision5("Lisa", "Jones", "555-55-5555", 2000.00M, .06M, 800.00M);

        Console.WriteLine(); // imprime una linea en blanco
        EmpleadoBaseMasComision5 empleado3 = new EmpleadoBaseMasComision5("Mark", "Sands", "888-88-8888", 8000.00M, .15M, 2000.00M);

    }
}