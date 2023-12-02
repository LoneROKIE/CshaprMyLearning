
using Entidades.Data;
using Entidades.Models;
using System;
using System.Security.Cryptography.X509Certificates;

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
                Console.Write("Digite la descripcion del trabajo:> ");
                string descripTrabajo = Console.ReadLine();
                Console.Write("Digite la direccion del lugar de trabajo:> ");
                string direccionTrabajo = Console.ReadLine();
                Console.Write("Digite el numero de telefono de su trabajo:> ");
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
            try
            {
                Console.Write("Digite el nombre de la Persona:> ");
                string nombre = Console.ReadLine();
                Console.Write("Digite el Primer Apellido:> ");
                string ape1 = Console.ReadLine();
                Console.Write("Digite el Segundo Apellido:> ");
                string ape2 = Console.ReadLine();
                Console.Write("Digite la direccion:> ");
                string direcc = Console.ReadLine();

                Console.WriteLine();
                Console.WriteLine("[IMPRIMIENDO TRABAJOS]");

                // aqui debo de llamar al metodo que lista los trabajos

                Console.Write("Digite la identificacion que identifique su trabajo:> ");
                string identTra = Console.ReadLine();
            }

        }
     
    }
}
