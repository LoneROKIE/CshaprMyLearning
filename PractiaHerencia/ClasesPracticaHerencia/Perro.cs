using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesPracticaHerencia
{
    public class Perro : Animal // hereda de la clase abstracta Animal, por lo tanto debe implementar los metodos abstractos
    {

        private string raza { get; set; }
        private string color { get; set; }
        private string tamanio { get; set; }

        // constructor
        public Perro(string tipoAnimal, string nombre, string raza, string color, string tamanio) : base(tipoAnimal, nombre)
        {
              this.raza = raza;
              this.color = color;
              this.tamanio = tamanio;
        }


        public override void Sonido(string sonido)
        {
           Console.WriteLine($"El perro hace {sonido}");
        }


        public override bool EsDomestico(string resp)
        {
            if(resp == "si")
            {
                Console.WriteLine("El perro es domestico");
                return true;
            }
            else
            {
                Console.WriteLine("El perro no es domestico");
                return false;
            }

            
        }



        // toString
        public override string ToString()
        {
            return $"{base.ToString()}, Raza: {raza}, color: {color}, tamanio: {tamanio}";
        }

    }
}
