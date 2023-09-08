using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// FIG. 10.14: EmpleadoBaseMasComision4.cs
// EmpleadoBaseMasComision4 hereda de la clase EmpleadoPorComision3 y accede
// a los miembros private de EmpleadoPorComision3 a traves de las propiedades public
// de EmpleadoPorComision3


namespace EPM
{
    public class EmpleadoBaseMasComision4 : EmpleadoPorComision3
    {

        private decimal salarioBase; // salario base por semana

        // constructor de la clase derivada con seis parametros
        // con una llamada al constructor de la clase base EmpleadoPorComision3
        public EmpleadoBaseMasComision4(string nombre, string apellido, string nss, decimal ventas, decimal tarifa, decimal salario)
            : base(nombre, apellido, nss, ventas, tarifa) // constructor clase base
        {
            salarioBase = salario; // valida el salario base a traves de una propiedad
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
