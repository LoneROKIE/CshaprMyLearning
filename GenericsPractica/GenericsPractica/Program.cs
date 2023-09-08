/*
 * Que son los generics? 
 * Los generics son una forma de parametrizar tipos en .NET y C#.
 * Para que sirven los generics?
 * Sirven para poder reutilizar codigo, ya que podemos crear clases, 
 * interfaces, metodos, etc. que puedan trabajar con cualquier tipo de dato.
 */

using System;

public class Principal
{
    public static void Main(string[] args)
    {
        // usando generics para crear una lista de ints
        List<int> listaEnteros = new List<int>();
        listaEnteros.Add(1);
        listaEnteros.Add(2);

        // vamos a probar el ejemplo 1
        MiClase<string> miClase = new MiClase<string>();

        miClase.MiPropiedad = "Hola mundo";
        miClase.MiMetodo("Hola mundo");

    }
}



// otros ejemplos de generics


// Ejemplo 1:
// Clase generica
public class MiClase<T>
{
    public T MiPropiedad { get; set; }
    public T MiMetodo(T parametro)
    {
        return parametro;
    }
}

// Ejemplo 2:
// Interface generica
public interface IMiInterface<T>
{
    T MiPropiedad { get; set; }
    T MiMetodo(T parametro);
}

// Ejemplo 3:
// Metodo generico
public class Ejemplo3
{
    public T MiMetodo<T>(T parametro)
    {
        return parametro;
    }
}

// Ejemplo 4:
// Clase generica con restriccion
public class Ejemplo4<T> where T : class // T debe ser una clase
{
    public T MiPropiedad { get; set; }
    public T MiMetodo(T parametro)
    {
        return parametro;
    }
}

// Ejemplo 5:
// Clase generica con multiples typos de parametros
public class Ejemplo5<T, U>
{
    public T MiPropiedad { get; set; }
    public U MiPropiedad2 { get; set; }
    public T MiMetodo(T parametro)
    {
        return parametro;
    }
}