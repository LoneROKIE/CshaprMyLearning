using System;

/*
 * Las estructuras se guardan en la memoria STACK como si fuera un tipo de dato primitivo
 * al contrario que las clases que guardan su referencia en la memoria HEAP
 * 
 * La sintaxis o declaracion de una Struct es similar a la de una clase solo se debe cambiar
 * 'class' por 'struct'
 * 
 * Las structs son primariamente usadas para representar pequenia cantidad de data
 * que no tienen muchos comportamientos. como el ejemplo de este proyecto.
 * 
 * Las structs no puede tomar valores como nullos, ya que son como tipo primitivos,
 * como si fuera un int por ejemplo
 * 
 * Para decidir si usar clases o struct, va a depender si lo que necesitamos es 
 * un tipo por referencia or un tipo de valor esa es como la differencia mas grande
 * de clases y structs
 * 
 * 
 */


public class Principal
{
    // metodo main
    public static void Main(string[] args)
    {
        Point punto = new Point(10, 9);
        Console.WriteLine($"El punto X es: {punto.X}, El punto Y es: {punto.Y}");

        // no ocupa un constructor
        PairOfInts par;
        par.A = 20;
        par.B = 30;

        PairOfInts par2;
        par2.A = 40;
        par2.B = 50;

        Console.WriteLine($"PAR1 DE ENTEROS STRUCT: par A: {par.A}, par B: {par.B} ");
        Console.WriteLine($"PAR2 DE ENTEROS STRCUT: par A: {par2.A}, par B: {par2.B}");


    }

    public struct Point
    {
        public float X { get; }
        public float Y { get; }

        public Point(float x, float y)
        {
            X = x;
            Y = y;
        }
    }

    public struct PairOfInts
    {
        public int A;
        public int B;
    }


}