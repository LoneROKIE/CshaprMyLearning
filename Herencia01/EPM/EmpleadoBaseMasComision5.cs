using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPM
{
    public class EmpleadoBaseMasComision5 : EmpleadoPorComision4
    {
        private decimal salarioBase; // salario base por semana

        // constructor de la clase derivada con seis parametros
        // con una llamada al constructor de la clase base EmpleadoPorComision3
        public EmpleadoBaseMasComision5(string nombre, string apellido, string nss, decimal ventas, decimal tarifa, decimal salario)
            : base(nombre, apellido, nss, ventas, tarifa) // constructor clase base
        {
            salarioBase = salario; // valida el salario base a traves de una propiedad

            Console.WriteLine("\nConstructor de EmpleadoBaseMasComision5:\n" + this);

        }

        // propiedad que obtiene y establece el salario base del empleado por comision con salario base
        public decimal SalarioBase
        {
            get
            {
                return salarioBase;
            }
            set
            {
                salarioBase = (value < 0) ? 0 : value; // valida el salario base
            }
        }


        // calcula los ingresos
        public override decimal Ingresos()
        {
            return SalarioBase + base.Ingresos();
        }

        // devuelve representacion string de un objeto EmpleadoBaseMasComision4
        public override string ToString()
        {
            return string.Format("{0} {1}\n{2}: {3:C}",
                "salario base +", base.ToString(), "salario base", SalarioBase);
        }



    }
}
