using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesPractica2
{
    public class Rectangulo : IFiguraGeometrica
    {
        private  double alturaR { get; set; }
        private double baseR { get; set; }

        public Rectangulo(double alturaR, double baseR)
        {
            this.alturaR = alturaR;
            this.baseR = baseR;
        }


        public void calcArea()
        {
            var resultadoArea = alturaR * baseR;
            Console.WriteLine($"El Area del rectangulo es: {resultadoArea}");
        }

        public void calcPerimetro()
        {
            var resultadoPerimetro = 2 * (alturaR + baseR);
            Console.WriteLine($"El Perimetro del rectangulo es: {resultadoPerimetro}");
        }
    }
}
