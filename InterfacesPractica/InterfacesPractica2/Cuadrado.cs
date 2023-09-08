using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesPractica2
{
    public class Cuadrado : IFiguraGeometrica
    {

        private double lado { get; set; }

        public Cuadrado(double lado)
        {
            this.lado = lado;
        }

        public void calcArea()
        {
            var resultadoArea = lado * lado;
            Console.WriteLine($"El area del cuadrado es: {resultadoArea}");
        }

        public void calcPerimetro()
        {
            var resultadoPerimetro = lado * 4;
            Console.WriteLine($"El perimetro del cuadrado es: {resultadoPerimetro}");
        }
    }
}
