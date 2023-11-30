
using Entidades.Data;
using Entidades.Models;
using System;

namespace TuNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Entity Framework Core Migrations!");
            // En teoria ya funciona, ahora solo debo de crear las consultas
            // para insertar, actualizar, borrar y consultar

            AddTrabajo();

            


        }

        // metodo para agregar un trabajo
        public static void AddTrabajo()
        {
            try
            {
                Console.Write("Digite el nombre del trabajo:> ");
                string nombreTrabajo = Console.ReadLine();
                Console.WriteLine("Digite la descripcion del trabajo:> ");
                string descripTrabajo = Console.ReadLine();
                Console.WriteLine("Digite la direccion del lugar de trabajo:> ");
                string direccionTrabajo = Console.ReadLine();
                Console.WriteLine("Digite el numero de telefono de su trabajo:> ");
                string numTelfTrabajo = Console.ReadLine();

                // creamos una instancia de trabajo
                Trabajo trabajo = new Trabajo()
                {

                    NombreTrabajo = nombreTrabajo,
                    Descripcion = descripTrabajo,
                    Direccion = direccionTrabajo,
                    Telefono = numTelfTrabajo
                };

                // declaro el context
                using var practiceContext = new PracticeContext();

                practiceContext.Add(trabajo);
                // salvamos los cambios
                practiceContext.SaveChanges();

            }
            catch(Exception ex)
            {
                Console.WriteLine("Sucedio una excepcion: "+ex.ToString());
            }
        }

        // metodo para agregar una persona
        public static void AddPersona(PracticeContext practiceContext)
        {


        }
     
    }
}
