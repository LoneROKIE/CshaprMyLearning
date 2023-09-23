//--------------------------------------------------------------------------
// ========================= EXPRESIONES LAMBDA ============================
//__________________________________________________________________________

// LINK DOC OFICIAL: https://learn.microsoft.com/es-es/dotnet/csharp/language-reference/operators/lambda-expressions#expression-lambdas

// una expresion lambda puede tener cualquiera de las dos formas siguientes

// Una lambda de expresion que tiene una expresion como cuerpo:
// (input-parameters) => expression

// Una lambda de instruccion que tiene un bloque de instrucciones como cuerpo
// (input-parameters) => { <sequence-of-statements>}

/*
 * Para crear una expresión lambda, especifique los parámetros de entrada 
 * (si existen) a la izquierda del operador lambda y una expresión o bloque 
 * de instrucciones en el otro lado.
 */

// Toda expresion lambda se puede convertir en un tipo delegado

/*
 * Si una expresión lambda no devuelve un valor, se puede convertir 
 * en uno de los tipos delegados Action; 
 * de lo contrario, se puede convertir en uno de los tipos delegados Func
 */

int numero = 300;
// expresion lambda action, Action no regresa nada es como void
Action<int> resultado = num =>
{
    if (num >= numero) { Console.WriteLine(num + ", es mayor que: " + numero); }
    else { Console.WriteLine(num + ", es menor que: " + numero); }
};

resultado(1000);
// expresion lambda Func
// <va a recibir un int de entrada> <va a devolver algo que es entero>
Func<int,int,int> tripleMultiplicacion = (x,z) => z * x * numero;

int resultadoMultplicacion = tripleMultiplicacion(10, 2);
Console.WriteLine(resultadoMultplicacion); // imprimimos el resultado


// creamos una expresion lambda que imprime los numeros que recibe
Action<int> print = (number) => Console.WriteLine(number);
//print(5);

// creamos una lista de numeros
List<int> listaNumeros = new List<int>{ 1, 2, 4, 3, 5, 7};
Action<List<int>> mostrar = (listaN) =>
{
    foreach (var item in listaN)
    {
        // usamos nuestra expresion lambda print para imprimir los n de la lista
        print(item);
    }
};

Console.WriteLine("Imprimimos la lista de numeros");
// llamamos a la expresion lambda mostrar
mostrar(listaNumeros);


// FUNCIONES DE ORDEN SUPERIOR, RECIBEN UNA FUNCION
Console.WriteLine("FUNCIONES DE ORDEN SUPERIOR, RECIBEN UNA FUNCION");
Func<int, Func<int, int>, int> fnOrdenSuperior = (numero, fn) =>
{
    if(numero> 100)
    {
        return fn(numero);
    }
    else
    {
        return numero;
    }
};

var res = fnOrdenSuperior(600, (n) => n * 2);
Console.WriteLine(res);