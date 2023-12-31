﻿using System;
using System.Collections.Generic;

namespace Consola1
{
    class Programa1
    {
        static void Main(string[] args)
        {
            var names = new List<string> { "<name>", "Ana", "Felipe"};

            //imprimimos la lista
            ImprimirLista(names);

            // podemos aniadir mas datos al la lista
            names.Add("Carlos");
            names.Add("Jose");
            // podemos eliminar 
            names.Remove("<name>");

            // imprimimos la lista de nuevo
            Console.WriteLine("\n\n");
            
            //ImprimirLista(names);

            // usamos una expresion lambda para imprimir la lista
            Action<List<string>> mostrarLista = (names) =>
            {
                foreach(var name in names)
                {
                    Console.WriteLine($"Hi, {name}");
                }
            };

            // llamamos a la expresion lambda
            mostrarLista(names);

            // usando indexOf
            Console.WriteLine("\n\n");
            Console.WriteLine("IndexOf");

            var index = names.IndexOf("lucas");
            if(index == -1)
            {
                Console.WriteLine($"When an Item is not found, IndexOf returns {index}");
            }
            else
            {
                Console.WriteLine($"The name {names[index]}, was found at position: {index} ");
            }



        }
        // metodo para imprimir nuestra lista
        static void ImprimirLista(List<string> names)
        {
            foreach (string name in names)
            {
                Console.WriteLine($"Hello, {name.ToUpper()}!");
            }
        }
    }
}