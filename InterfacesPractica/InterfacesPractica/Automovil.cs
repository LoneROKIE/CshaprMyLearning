using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesPractica
{
    public class Automovil : IVehiculo // implemento la interfaz IVEHICULO
    {
        public void Acelerar()
        {
            Console.WriteLine("El automovil esta acelerando");
        }

        public void Arrancar()
        {
            Console.WriteLine("El automovil estar arrancando");
        }

        public void Detener()
        {
            Console.WriteLine("El automovil se esta Deteniendo");
        }

        public void Frenar()
        {
            Console.WriteLine("El automovil esta frenando");
        }
    }
}
