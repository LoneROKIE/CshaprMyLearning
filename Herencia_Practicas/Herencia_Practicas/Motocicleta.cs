using Herencia_Practicas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Motocicleta : Vehiculo
    {
        // creamos un atributo propio de la clase Motocicleta
        private int cilindrada;

        // Constructor
        public Motocicleta(string marca, string modelo, int cilindrada) : base(marca, modelo)
        {
            this.cilindrada = cilindrada;
        }

        // metodo toString
        public override string ToString()
        {
           // usamos el metodo de la clase padre
            return base.ToString() + " // Cilindrada: " + this.cilindrada + "c";
        }

    }
}
