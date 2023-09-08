using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesPractica
{
    public class Motocicleta : IVehiculo // implementamos la interfaz
    {
        public void Acelerar()
        {
            Console.WriteLine("La motocicleta esta acelerando");
        }

        public void Arrancar()
        {
            Console.WriteLine("La motocicleta esta arrancando");
        }

        public void Detener()
        {
            Console.WriteLine("La motocicleta esta deteniendose");
        }

        public void Frenar()
        {
            Console.WriteLine("La motocicleta esta frenando");
        }
    }
}
